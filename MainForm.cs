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
using System.Windows.Forms.DataVisualization.Charting;

namespace Leviosa
{
    public partial class MainForm : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        public MainForm()
        {
            InitializeComponent();
            InitializeValidation();
        }

        private void InitializeValidation()
        {
            txtSets.Validating += ValidateNumericInput;
            txtReps.Validating += ValidateNumericInput;
            txtWeight.Validating += ValidateNumericInput;
            dateWorkout.Validating += ValidateDateInput;
        }

        private void ValidateNumericInput(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!int.TryParse(textBox.Text, out int result) || result <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Please enter a valid positive number.");
            }
            else
            {
                errorProvider.SetError(textBox, string.Empty);
            }
        }

        private void ValidateDateInput(object sender, CancelEventArgs e)
        {
            DateTimePicker datePicker = sender as DateTimePicker;
            if (datePicker.Value.Date > DateTime.Now.Date)
            {
                e.Cancel = true;
                errorProvider.SetError(datePicker, "Date cannot be in the future.");
            }
            else
            {
                errorProvider.SetError(datePicker, string.Empty);
            }
        }

        private bool ValidateWorkoutForm()
        {
            bool isValid = true;
            // Trigger all controls' validation
            foreach (Control control in Controls)
            {
                if (!ValidateChildren(ValidationConstraints.Enabled))
                    isValid = false;
            }

            return isValid;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadWorkouts();
            LoadExercises();
            LoadWeeklyWorkoutSummary(); // Newly added method to load weekly summaries
            LoadTotalWeightPerSession(); // Load the total weight per session
            SetupChart();  // Setup chart configurations
            LoadChartData();  // Load data into the chart
                              // other load methods
        }

        private void LoadExercises()
        {
            var exercises = DatabaseHelper.GetExerciseNames();
            cmbExerciseName.Items.Clear();
            foreach (var exercise in exercises)
            {
                cmbExerciseName.Items.Add(exercise);
            }
            if (cmbExerciseName.Items.Count > 0)
                cmbExerciseName.SelectedIndex = 0;
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            if (!ValidateWorkoutForm())
            {
                MessageBox.Show("Please correct the highlighted errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var date = dateWorkout.Value;
                var exerciseName = cmbExerciseName.SelectedItem.ToString();
                var sets = int.Parse(txtSets.Text);
                var reps = int.Parse(txtReps.Text);
                var weight = float.Parse(txtWeight.Text);

                DatabaseHelper.AddWorkout(date, exerciseName, sets, reps, weight);
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
            dataGridViewWorkoutHistory.DataSource = DatabaseHelper.GetWorkouts();
            dataGridViewWorkoutHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            SetupDataGridViewColumns();
        }

        private void SetupDataGridViewColumns()
        {
            if (dataGridViewWorkoutHistory.Columns["ID"] != null)
                dataGridViewWorkoutHistory.Columns["ID"].Visible = false;

            if (dataGridViewWorkoutHistory.Columns["ExerciseName"] != null)
                dataGridViewWorkoutHistory.Columns["ExerciseName"].DisplayIndex = 0;
            if (dataGridViewWorkoutHistory.Columns["Date"] != null)
                dataGridViewWorkoutHistory.Columns["Date"].DisplayIndex = 1;
            if (dataGridViewWorkoutHistory.Columns["Sets"] != null)
                dataGridViewWorkoutHistory.Columns["Sets"].DisplayIndex = 2;
            if (dataGridViewWorkoutHistory.Columns["Reps"] != null)
                dataGridViewWorkoutHistory.Columns["Reps"].DisplayIndex = 3;
            if (dataGridViewWorkoutHistory.Columns["Weight"] != null)
                dataGridViewWorkoutHistory.Columns["Weight"].DisplayIndex = 4;

            dataGridViewWorkoutHistory.Refresh();
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            string newExerciseName = txtNewExercise.Text.Trim();
            if (!string.IsNullOrEmpty(newExerciseName))
            {
                if (!cmbExerciseName.Items.Contains(newExerciseName))
                {
                    cmbExerciseName.Items.Add(newExerciseName);
                    cmbExerciseName.SelectedItem = newExerciseName;
                    DatabaseHelper.AddExerciseToDatabase(newExerciseName);
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

        private void btnEditWorkout_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkoutHistory.CurrentRow != null)
            {
                int id;
                DateTime date;
                int sets;
                int reps;
                float weight;

                bool idParsed = int.TryParse(dataGridViewWorkoutHistory.CurrentRow.Cells["ID"].Value.ToString(), out id);
                bool setsParsed = int.TryParse(dataGridViewWorkoutHistory.CurrentRow.Cells["Sets"].Value.ToString(), out sets);
                bool repsParsed = int.TryParse(dataGridViewWorkoutHistory.CurrentRow.Cells["Reps"].Value.ToString(), out reps);
                bool weightParsed = float.TryParse(dataGridViewWorkoutHistory.CurrentRow.Cells["Weight"].Value.ToString(), out weight);
                bool dateParsed = DateTime.TryParse(dataGridViewWorkoutHistory.CurrentRow.Cells["Date"].Value.ToString(), out date);

                if (idParsed && setsParsed && repsParsed && weightParsed && dateParsed)
                {
                    string exerciseName = cmbExerciseName.SelectedItem.ToString();
                    DatabaseHelper.UpdateWorkout(id, date, exerciseName, sets, reps, weight);
                    LoadWorkouts();
                    MessageBox.Show("Workout updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: Please check that all inputs are in the correct format.", "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteWorkout_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkoutHistory.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridViewWorkoutHistory.CurrentRow.Cells["ID"].Value);
                if (MessageBox.Show("Are you sure you want to delete this workout?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DatabaseHelper.DeleteWorkout(id);
                    LoadWorkouts();
                    MessageBox.Show("Workout deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void LoadWeeklyWorkoutSummary()
        {
            dataGridViewWeeklySummary.DataSource = DatabaseHelper.GetWeeklyWorkoutSummary();
            dataGridViewWeeklySummary.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewWeeklySummary.Refresh();  // Refresh the grid to show the updated data.
        }
        private void LoadTotalWeightPerSession()
        {
            dataGridViewTotalWeightPerSession.DataSource = DatabaseHelper.GetTotalWeightPerSession();
            dataGridViewTotalWeightPerSession.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewTotalWeightPerSession.Refresh();  // Refresh to display the latest data.
        }
        private void SetupChart()
        {
            chartProgress.Series.Clear();
            chartProgress.ChartAreas.Add(new ChartArea("MainArea"));

            Series totalWeightSeries = new Series("Total Weight Lifted")
            {
                ChartType = SeriesChartType.Line,  // Choose line chart, you can choose others like Bar, Column, etc.
                Color = Color.Blue,
                BorderWidth = 2
            };
            chartProgress.Series.Add(totalWeightSeries);

            // Setup other properties
            chartProgress.ChartAreas["MainArea"].AxisX.Title = "Date";
            chartProgress.ChartAreas["MainArea"].AxisY.Title = "Total Weight Lifted";
        }
        private void LoadChartData()
        {
            var data = DatabaseHelper.GetTotalWeightPerSession();  // Ensure this method returns DataTable
            Series series = chartProgress.Series["Total Weight Lifted"];
            series.Points.Clear();

            foreach (DataRow row in data.Rows)
            {
                series.Points.AddXY(Convert.ToDateTime(row["Date"]).ToShortDateString(), row["TotalWeight"]);
            }
        }
    }
}
