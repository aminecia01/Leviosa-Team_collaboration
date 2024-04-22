using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leviosa.Data;

namespace Leviosa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadWorkouts(); // Load workouts into the DataGridView
        }

        private void LoadExercises()
        {
            // This method will be updated to dynamically load exercises from the database
            cmbExerciseName.Items.Clear(); // Clear existing items
            cmbExerciseName.Items.Add("Exercise 1"); // Placeholder items
            cmbExerciseName.Items.Add("Exercise 2");
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            // Add validation and error handling as necessary
            try
            {
                // Parsing input values from the form controls
                var date = dateWorkout.Value;
                var exerciseName = cmbExerciseName.SelectedItem.ToString();
                var sets = int.Parse(txtSets.Text);
                var reps = int.Parse(txtReps.Text);
                var weight = float.Parse(txtWeight.Text);

                // Adding a workout to the database
                DatabaseHelper.AddWorkout(date, exerciseName, sets, reps, weight);

                // Refresh the DataGridView to show the newly added workout
                LoadWorkouts();

                MessageBox.Show("Workout added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add workout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadWorkouts()
        {
            // Load workouts from the database and display them in the DataGridView
            dataGridViewWorkoutHistory.DataSource = DatabaseHelper.GetWorkouts();
            dataGridViewWorkoutHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            string newExerciseName = txtNewExercise.Text.Trim();

            if (!string.IsNullOrEmpty(newExerciseName))
            {
                if (!cmbExerciseName.Items.Contains(newExerciseName))
                {
                    // Add the new exercise to the ComboBox
                    cmbExerciseName.Items.Add(newExerciseName);
                    cmbExerciseName.SelectedItem = newExerciseName;

                    // Call method to add the new exercise to the database
                    DatabaseHelper.AddExerciseToDatabase(newExerciseName); // Corrected variable name

                }
                else
                {
                    MessageBox.Show("This exercise already exists.", "Duplicate Exercise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid exercise name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

