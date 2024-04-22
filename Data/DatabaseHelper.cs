using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite; //added to use the SQLite .NET provider

namespace Leviosa.Data
{
    internal class DatabaseHelper
    {
        private static string dbConnectionStr = @"Data Source=C:\Users\jsocs\OneDrive\Documents\School\IT488\Project\Leviosa\Database\Leviosa.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(dbConnectionStr);
        }

        // Method to add a workout to the database
        public static void AddWorkout(DateTime date, string exerciseName, int sets, int reps, float weight)
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

        // Method to retrieve all workouts from the database
        public static DataTable GetWorkouts()
        {
            DataTable dt = new DataTable();
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
            return dt;
        }

        // New method to add an exercise to the database
        public static void AddExerciseToDatabase(string exerciseName)
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
    }
}

