using System.ComponentModel;

namespace Lab4_CSHARP.Windows
{
    partial class ChangeStudentGradeDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChooseSubject = new System.Windows.Forms.Button();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChooseStudent = new System.Windows.Forms.Button();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownGrade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(453, 143);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(156, 29);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(72, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оцінка:";
            // 
            // buttonChooseSubject
            // 
            this.buttonChooseSubject.Enabled = false;
            this.buttonChooseSubject.Location = new System.Drawing.Point(453, 105);
            this.buttonChooseSubject.Name = "buttonChooseSubject";
            this.buttonChooseSubject.Size = new System.Drawing.Size(156, 32);
            this.buttonChooseSubject.TabIndex = 6;
            this.buttonChooseSubject.Text = "Обрати";
            this.buttonChooseSubject.UseVisualStyleBackColor = true;
            this.buttonChooseSubject.Click += new System.EventHandler(this.buttonChooseSubject_Click);
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.Enabled = false;
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(154, 105);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(293, 32);
            this.comboBoxSubjects.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предмет:";
            // 
            // buttonChooseStudent
            // 
            this.buttonChooseStudent.Location = new System.Drawing.Point(453, 67);
            this.buttonChooseStudent.Name = "buttonChooseStudent";
            this.buttonChooseStudent.Size = new System.Drawing.Size(156, 32);
            this.buttonChooseStudent.TabIndex = 4;
            this.buttonChooseStudent.Text = "Обрати";
            this.buttonChooseStudent.UseVisualStyleBackColor = true;
            this.buttonChooseStudent.Click += new System.EventHandler(this.buttonChooseStudent_Click);
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(154, 67);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(293, 32);
            this.comboBoxStudents.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(57, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Студент:";
            // 
            // numericUpDownGrade
            // 
            this.numericUpDownGrade.Enabled = false;
            this.numericUpDownGrade.Location = new System.Drawing.Point(154, 143);
            this.numericUpDownGrade.Name = "numericUpDownGrade";
            this.numericUpDownGrade.Size = new System.Drawing.Size(293, 29);
            this.numericUpDownGrade.TabIndex = 7;
            // 
            // ChangeStudentGradeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 246);
            this.Controls.Add(this.numericUpDownGrade);
            this.Controls.Add(this.buttonChooseStudent);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonChooseSubject);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(690, 285);
            this.Name = "ChangeStudentGradeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Зміна оцінки";
            this.Load += new System.EventHandler(this.ChangeStudentGradeDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChooseSubject;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChooseStudent;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownGrade;

        #endregion
    }
}