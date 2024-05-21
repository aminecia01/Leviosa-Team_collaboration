using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite; //added to use the SQLite .NET provider
using System.IO;  // For handling file and directory operations.
using System.Windows.Forms;  // For displaying messages to the user.


namespace Leviosa.Data
{
    internal class DatabaseHelper
    {
        private static string dbConnectionStr = @"Data Source=.\Database\Leviosa.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(dbConnectionStr);
        }

        // Method to add a workout to the database
        public static void AddWorkout(DateTime date, string exerciseName, int sets, int reps, float weight)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = "INSERT INTO Workouts (Date, ExerciseName, Sets, Reps, Weight) VALUES (@Date, @ExerciseName, @Sets, @Reps, @Weight)";
                        cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@ExerciseName", exerciseName);
                        cmd.Parameters.AddWithValue("@Sets", sets);
                        cmd.Parameters.AddWithValue("@Reps", reps);
                        cmd.Parameters.AddWithValue("@Weight", weight);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding workout: " + ex.Message);
                throw;
            }
        }

        // Method to update a workout in the database
        public static void UpdateWorkout(int id, DateTime date, string exerciseName, int sets, int reps, float weight)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = "UPDATE Workouts SET Date = @Date, ExerciseName = @ExerciseName, Sets = @Sets, Reps = @Reps, Weight = @Weight WHERE ID = @ID";
                        cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@ExerciseName", exerciseName);
                        cmd.Parameters.AddWithValue("@Sets", sets);
                        cmd.Parameters.AddWithValue("@Reps", reps);
                        cmd.Parameters.AddWithValue("@Weight", weight);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating workout: " + ex.Message);
                throw;
            }
        }

        // Method to delete a workout from the database
        public static void DeleteWorkout(int id)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = "DELETE FROM Workouts WHERE ID = @ID";
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting workout: " + ex.Message);
                throw;
            }
        }

        // Method to retrieve all workouts from the database
        public static DataTable GetWorkouts()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("SELECT * FROM Workouts ORDER BY Date DESC", conn))
                    {
                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving workouts: " + ex.Message);
                throw;
            }
            return dt;
        }

        // Method to add an exercise to the database
        public static void AddExerciseToDatabase(string exerciseName)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = "INSERT INTO Exercises (ExerciseName) VALUES (@ExerciseName) ON CONFLICT(ExerciseName) DO NOTHING;";
                        cmd.Parameters.AddWithValue("@ExerciseName", exerciseName);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding exercise: " + ex.Message);
                throw;
            }
        }

        // Method to retrieve all exercise names from the database
        public static List<string> GetExerciseNames()
        {
            List<string> exerciseNames = new List<string>();
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("SELECT ExerciseName FROM Exercises ORDER BY ExerciseName", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                exerciseNames.Add(reader["ExerciseName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving exercise names: " + ex.Message);
                throw;
            }
            return exerciseNames;
        }
        public static DataTable GetWeeklyWorkoutSummary()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = @"
                SELECT strftime('%Y-%W', Date) AS Week,
                       COUNT(*) AS TotalWorkouts,
                       SUM(Sets) AS TotalSets,
                       SUM(Reps) AS TotalReps,
                       SUM(Weight) AS TotalWeight,
                       AVG(Sets) AS AverageSets,
                       AVG(Reps) AS AverageReps,
                       AVG(Weight) AS AverageWeight
                FROM Workouts
                GROUP BY strftime('%Y-%W', Date)
                ORDER BY Week DESC;";
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public static DataTable GetTotalWeightPerSession()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = @"
                SELECT Date, SUM(Weight * Sets * Reps) AS TotalWeight
                FROM Workouts
                GROUP BY Date
                ORDER BY Date DESC;";
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public static void BackupDatabase()
        {
            // Path to the original database
            string sourcePath = @".\Database\Leviosa.db";
            // Directory to store backups, within the existing database directory
            string backupDirectory = @".\Leviosa\Database\Backups";
            // Backup file name with a timestamp for uniqueness
            string backupFileName = $"Leviosa_backup_{DateTime.Now:yyyyMMddHHmmss}.db";
            // Full path for the backup file
            string backupPath = Path.Combine(backupDirectory, backupFileName);

            try
            {
                // Ensure the backup directory exists
                if (!Directory.Exists(backupDirectory))
                {
                    Directory.CreateDirectory(backupDirectory);
                }

                // Copy the database file to the backup directory
                File.Copy(sourcePath, backupPath, true);
                MessageBox.Show("Backup created successfully at: " + backupPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create backup: " + ex.Message);
            }
        }

    }
}
