using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Call LoadExercises when the form loads
            LoadExercises();
        }

        private void LoadExercises()
        {
            // Placeholder for database loading logic
            // TODO: Replace with actual database call to populate cmbExerciseName
            cmbExerciseName.Items.Add("Exercise 1"); // Example item - remove later
            cmbExerciseName.Items.Add("Exercise 2"); // Example item - remove later
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            // Placeholder for adding a workout
            // Here, add code to collect data from the form controls and add a workout entry to the database
            MessageBox.Show("Workout added!"); // Placeholder feedback
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
