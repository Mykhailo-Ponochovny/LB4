using System.ComponentModel;

namespace Lab4_CSHARP_Variant3.Windows
{
    partial class AddSubjectDialog
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
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва предмета:";
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Location = new System.Drawing.Point(218, 36);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(329, 29);
            this.textBoxSubjectName.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(218, 71);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(166, 33);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddSubjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 141);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSubjectName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(615, 180);
            this.Name = "AddSubjectDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додати предмет";
            this.Load += new System.EventHandler(this.AddSubjectDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSubjectName;

        #endregion
    }
}