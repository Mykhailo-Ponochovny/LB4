using System.ComponentModel;

namespace Lab4_CSHARP.Windows
{
    partial class AddStudentToSubjectDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownGrade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студент:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(55, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Предмет:";
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(157, 37);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(277, 32);
            this.comboBoxStudents.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(215, 149);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 32);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Зарахувати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(157, 75);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(277, 32);
            this.comboBoxSubjects.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(76, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оцінка:";
            // 
            // numericUpDownGrade
            // 
            this.numericUpDownGrade.Location = new System.Drawing.Point(157, 114);
            this.numericUpDownGrade.Name = "numericUpDownGrade";
            this.numericUpDownGrade.Size = new System.Drawing.Size(277, 29);
            this.numericUpDownGrade.TabIndex = 5;
            // 
            // AddStudentToSubjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 206);
            this.Controls.Add(this.numericUpDownGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(545, 245);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(545, 245);
            this.Name = "AddStudentToSubjectDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Зарахувати студента на курс";
            this.Load += new System.EventHandler(this.AddStudentToSubjectDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown numericUpDownGrade;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ComboBox comboBoxSubjects;

        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}