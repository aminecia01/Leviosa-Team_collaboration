namespace Leviosa
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dateWorkout = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSets = new System.Windows.Forms.TextBox();
            this.txtReps = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.dataGridViewWorkoutHistory = new System.Windows.Forms.DataGridView();
            this.cmbExerciseName = new System.Windows.Forms.ComboBox();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.txtNewExercise = new System.Windows.Forms.TextBox();
            this.btnEditWorkout = new System.Windows.Forms.Button();
            this.btnDeleteWorkout = new System.Windows.Forms.Button();
            this.dataGridViewWeeklySummary = new System.Windows.Forms.DataGridView();
            this.dataGridViewTotalWeightPerSession = new System.Windows.Forms.DataGridView();
            this.chartProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklySummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalWeightPerSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // dateWorkout
            // 
            this.dateWorkout.Location = new System.Drawing.Point(62, 174);
            this.dateWorkout.Name = "dateWorkout";
            this.dateWorkout.Size = new System.Drawing.Size(216, 20);
            this.dateWorkout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exercise Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weight";
            // 
            // txtSets
            // 
            this.txtSets.Location = new System.Drawing.Point(12, 119);
            this.txtSets.Name = "txtSets";
            this.txtSets.Size = new System.Drawing.Size(100, 20);
            this.txtSets.TabIndex = 6;
            // 
            // txtReps
            // 
            this.txtReps.Location = new System.Drawing.Point(225, 119);
            this.txtReps.Name = "txtReps";
            this.txtReps.Size = new System.Drawing.Size(100, 20);
            this.txtReps.TabIndex = 7;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(119, 119);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 8;
            // 
            // btnAddWorkout
            // 
            this.btnAddWorkout.Location = new System.Drawing.Point(119, 145);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(100, 23);
            this.btnAddWorkout.TabIndex = 9;
            this.btnAddWorkout.Text = "Add Workout";
            this.btnAddWorkout.UseVisualStyleBackColor = true;
            this.btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click);
            // 
            // dataGridViewWorkoutHistory
            // 
            this.dataGridViewWorkoutHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkoutHistory.Location = new System.Drawing.Point(331, 5);
            this.dataGridViewWorkoutHistory.Name = "dataGridViewWorkoutHistory";
            this.dataGridViewWorkoutHistory.Size = new System.Drawing.Size(440, 189);
            this.dataGridViewWorkoutHistory.TabIndex = 10;
            // 
            // cmbExerciseName
            // 
            this.cmbExerciseName.FormattingEnabled = true;
            this.cmbExerciseName.Location = new System.Drawing.Point(109, 79);
            this.cmbExerciseName.Name = "cmbExerciseName";
            this.cmbExerciseName.Size = new System.Drawing.Size(121, 21);
            this.cmbExerciseName.TabIndex = 11;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Location = new System.Drawing.Point(119, 37);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(100, 23);
            this.btnAddExercise.TabIndex = 12;
            this.btnAddExercise.Text = "Add Exercise";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // txtNewExercise
            // 
            this.txtNewExercise.Location = new System.Drawing.Point(119, 12);
            this.txtNewExercise.Name = "txtNewExercise";
            this.txtNewExercise.Size = new System.Drawing.Size(100, 20);
            this.txtNewExercise.TabIndex = 13;
            // 
            // btnEditWorkout
            // 
            this.btnEditWorkout.Location = new System.Drawing.Point(12, 145);
            this.btnEditWorkout.Name = "btnEditWorkout";
            this.btnEditWorkout.Size = new System.Drawing.Size(100, 23);
            this.btnEditWorkout.TabIndex = 14;
            this.btnEditWorkout.Text = "Edit Workout";
            this.btnEditWorkout.UseVisualStyleBackColor = true;
            this.btnEditWorkout.Click += new System.EventHandler(this.btnEditWorkout_Click);
            // 
            // btnDeleteWorkout
            // 
            this.btnDeleteWorkout.Location = new System.Drawing.Point(225, 145);
            this.btnDeleteWorkout.Name = "btnDeleteWorkout";
            this.btnDeleteWorkout.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteWorkout.TabIndex = 15;
            this.btnDeleteWorkout.Text = "Delete Workout";
            this.btnDeleteWorkout.UseVisualStyleBackColor = true;
            this.btnDeleteWorkout.Click += new System.EventHandler(this.btnDeleteWorkout_Click);
            // 
            // dataGridViewWeeklySummary
            // 
            this.dataGridViewWeeklySummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeeklySummary.Location = new System.Drawing.Point(225, 200);
            this.dataGridViewWeeklySummary.Name = "dataGridViewWeeklySummary";
            this.dataGridViewWeeklySummary.Size = new System.Drawing.Size(546, 155);
            this.dataGridViewWeeklySummary.TabIndex = 16;
            // 
            // dataGridViewTotalWeightPerSession
            // 
            this.dataGridViewTotalWeightPerSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotalWeightPerSession.Location = new System.Drawing.Point(12, 200);
            this.dataGridViewTotalWeightPerSession.Name = "dataGridViewTotalWeightPerSession";
            this.dataGridViewTotalWeightPerSession.Size = new System.Drawing.Size(207, 155);
            this.dataGridViewTotalWeightPerSession.TabIndex = 17;
            // 
            // chartProgress
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProgress.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProgress.Legends.Add(legend1);
            this.chartProgress.Location = new System.Drawing.Point(12, 361);
            this.chartProgress.Name = "chartProgress";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProgress.Series.Add(series1);
            this.chartProgress.Size = new System.Drawing.Size(759, 218);
            this.chartProgress.TabIndex = 18;
            this.chartProgress.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 591);
            this.Controls.Add(this.chartProgress);
            this.Controls.Add(this.dataGridViewTotalWeightPerSession);
            this.Controls.Add(this.dataGridViewWeeklySummary);
            this.Controls.Add(this.btnDeleteWorkout);
            this.Controls.Add(this.btnEditWorkout);
            this.Controls.Add(this.txtNewExercise);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.cmbExerciseName);
            this.Controls.Add(this.dataGridViewWorkoutHistory);
            this.Controls.Add(this.btnAddWorkout);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtReps);
            this.Controls.Add(this.txtSets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateWorkout);
            this.Name = "MainForm";
            this.Text = "Leviosa - Fitness Tracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklySummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalWeightPerSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateWorkout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSets;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnAddWorkout;
        private System.Windows.Forms.DataGridView dataGridViewWorkoutHistory;
        private System.Windows.Forms.ComboBox cmbExerciseName;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.TextBox txtNewExercise;
        private System.Windows.Forms.Button btnEditWorkout;
        private System.Windows.Forms.Button btnDeleteWorkout;
        private System.Windows.Forms.DataGridView dataGridViewWeeklySummary;
        private System.Windows.Forms.DataGridView dataGridViewTotalWeightPerSession;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProgress;
    }
}