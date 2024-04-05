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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dateWorkout
            // 
            this.dateWorkout.Location = new System.Drawing.Point(63, 5);
            this.dateWorkout.Name = "dateWorkout";
            this.dateWorkout.Size = new System.Drawing.Size(200, 20);
            this.dateWorkout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exercise Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weight";
            // 
            // txtSets
            // 
            this.txtSets.Location = new System.Drawing.Point(13, 83);
            this.txtSets.Name = "txtSets";
            this.txtSets.Size = new System.Drawing.Size(100, 20);
            this.txtSets.TabIndex = 6;
            // 
            // txtReps
            // 
            this.txtReps.Location = new System.Drawing.Point(225, 83);
            this.txtReps.Name = "txtReps";
            this.txtReps.Size = new System.Drawing.Size(100, 20);
            this.txtReps.TabIndex = 7;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(119, 83);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 8;
            // 
            // btnAddWorkout
            // 
            this.btnAddWorkout.Location = new System.Drawing.Point(95, 109);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(145, 23);
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
            this.dataGridViewWorkoutHistory.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewWorkoutHistory.TabIndex = 10;
            // 
            // cmbExerciseName
            // 
            this.cmbExerciseName.FormattingEnabled = true;
            this.cmbExerciseName.Location = new System.Drawing.Point(109, 43);
            this.cmbExerciseName.Name = "cmbExerciseName";
            this.cmbExerciseName.Size = new System.Drawing.Size(121, 21);
            this.cmbExerciseName.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 162);
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
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutHistory)).EndInit();
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
    }
}