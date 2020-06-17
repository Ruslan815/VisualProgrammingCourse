namespace VisualProgramming_CourseWork
{
    partial class findStudentForm
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
            this.label_find = new System.Windows.Forms.Label();
            this.label_fullName = new System.Windows.Forms.Label();
            this.label_protocolNum = new System.Windows.Forms.Label();
            this.label_certificateNum = new System.Windows.Forms.Label();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.textBox_protocolNum = new System.Windows.Forms.TextBox();
            this.textBox_certificateNum = new System.Windows.Forms.TextBox();
            this.label_studentData = new System.Windows.Forms.Label();
            this.button_findStudent = new System.Windows.Forms.Button();
            this.listBox_studentData = new System.Windows.Forms.ListBox();
            this.panel_FindStudent = new System.Windows.Forms.Panel();
            this.panel_FindStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_find
            // 
            this.label_find.AutoSize = true;
            this.label_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_find.Location = new System.Drawing.Point(174, 5);
            this.label_find.Name = "label_find";
            this.label_find.Size = new System.Drawing.Size(293, 26);
            this.label_find.TabIndex = 0;
            this.label_find.Text = "Поиск курсанта автошколы";
            // 
            // label_fullName
            // 
            this.label_fullName.AutoSize = true;
            this.label_fullName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fullName.Location = new System.Drawing.Point(0, 45);
            this.label_fullName.Name = "label_fullName";
            this.label_fullName.Size = new System.Drawing.Size(90, 15);
            this.label_fullName.TabIndex = 1;
            this.label_fullName.Text = "ФИО курсанта:";
            // 
            // label_protocolNum
            // 
            this.label_protocolNum.AutoSize = true;
            this.label_protocolNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_protocolNum.Location = new System.Drawing.Point(0, 73);
            this.label_protocolNum.Name = "label_protocolNum";
            this.label_protocolNum.Size = new System.Drawing.Size(81, 15);
            this.label_protocolNum.TabIndex = 2;
            this.label_protocolNum.Text = "Протокол №:";
            // 
            // label_certificateNum
            // 
            this.label_certificateNum.AutoSize = true;
            this.label_certificateNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_certificateNum.Location = new System.Drawing.Point(0, 101);
            this.label_certificateNum.Name = "label_certificateNum";
            this.label_certificateNum.Size = new System.Drawing.Size(112, 15);
            this.label_certificateNum.TabIndex = 3;
            this.label_certificateNum.Text = "Свидетельство №:";
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_fullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_fullName.Location = new System.Drawing.Point(96, 43);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(371, 20);
            this.textBox_fullName.TabIndex = 4;
            // 
            // textBox_protocolNum
            // 
            this.textBox_protocolNum.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_protocolNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_protocolNum.Location = new System.Drawing.Point(96, 72);
            this.textBox_protocolNum.Name = "textBox_protocolNum";
            this.textBox_protocolNum.Size = new System.Drawing.Size(169, 20);
            this.textBox_protocolNum.TabIndex = 5;
            // 
            // textBox_certificateNum
            // 
            this.textBox_certificateNum.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_certificateNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_certificateNum.Location = new System.Drawing.Point(127, 100);
            this.textBox_certificateNum.Name = "textBox_certificateNum";
            this.textBox_certificateNum.Size = new System.Drawing.Size(138, 20);
            this.textBox_certificateNum.TabIndex = 6;
            // 
            // label_studentData
            // 
            this.label_studentData.AutoSize = true;
            this.label_studentData.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_studentData.Location = new System.Drawing.Point(226, 197);
            this.label_studentData.Name = "label_studentData";
            this.label_studentData.Size = new System.Drawing.Size(142, 16);
            this.label_studentData.TabIndex = 8;
            this.label_studentData.Text = "Данные о курсанте: ";
            // 
            // button_findStudent
            // 
            this.button_findStudent.BackColor = System.Drawing.Color.White;
            this.button_findStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_findStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_findStudent.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_findStudent.Location = new System.Drawing.Point(244, 148);
            this.button_findStudent.Name = "button_findStudent";
            this.button_findStudent.Size = new System.Drawing.Size(109, 31);
            this.button_findStudent.TabIndex = 9;
            this.button_findStudent.Text = "Поиск";
            this.button_findStudent.UseVisualStyleBackColor = false;
            this.button_findStudent.Click += new System.EventHandler(this.button_findStudent_Click);
            // 
            // listBox_studentData
            // 
            this.listBox_studentData.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listBox_studentData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listBox_studentData.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_studentData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox_studentData.FormattingEnabled = true;
            this.listBox_studentData.ItemHeight = 15;
            this.listBox_studentData.Location = new System.Drawing.Point(15, 218);
            this.listBox_studentData.Name = "listBox_studentData";
            this.listBox_studentData.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_studentData.Size = new System.Drawing.Size(583, 334);
            this.listBox_studentData.TabIndex = 10;
            // 
            // panel_FindStudent
            // 
            this.panel_FindStudent.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_FindStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_FindStudent.Controls.Add(this.listBox_studentData);
            this.panel_FindStudent.Controls.Add(this.label_find);
            this.panel_FindStudent.Controls.Add(this.button_findStudent);
            this.panel_FindStudent.Controls.Add(this.label_fullName);
            this.panel_FindStudent.Controls.Add(this.label_studentData);
            this.panel_FindStudent.Controls.Add(this.label_protocolNum);
            this.panel_FindStudent.Controls.Add(this.textBox_certificateNum);
            this.panel_FindStudent.Controls.Add(this.label_certificateNum);
            this.panel_FindStudent.Controls.Add(this.textBox_protocolNum);
            this.panel_FindStudent.Controls.Add(this.textBox_fullName);
            this.panel_FindStudent.Location = new System.Drawing.Point(12, 13);
            this.panel_FindStudent.Name = "panel_FindStudent";
            this.panel_FindStudent.Size = new System.Drawing.Size(619, 566);
            this.panel_FindStudent.TabIndex = 11;
            // 
            // findStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(642, 591);
            this.Controls.Add(this.panel_FindStudent);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(658, 630);
            this.MinimumSize = new System.Drawing.Size(658, 630);
            this.Name = "findStudentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск курсанта автошколы";
            this.panel_FindStudent.ResumeLayout(false);
            this.panel_FindStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_find;
        private System.Windows.Forms.Label label_fullName;
        private System.Windows.Forms.Label label_protocolNum;
        private System.Windows.Forms.Label label_certificateNum;
        private System.Windows.Forms.Label label_studentData;
        private System.Windows.Forms.Button button_findStudent;
        public System.Windows.Forms.TextBox textBox_fullName;
        public System.Windows.Forms.TextBox textBox_protocolNum;
        public System.Windows.Forms.TextBox textBox_certificateNum;
        private System.Windows.Forms.ListBox listBox_studentData;
        private System.Windows.Forms.Panel panel_FindStudent;
    }
}