namespace VisualProgramming_CourseWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip_MainForm = new System.Windows.Forms.ToolStrip();
            this.toolStrip_AboutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox_forPrint = new System.Windows.Forms.GroupBox();
            this.listBox_forPrint = new System.Windows.Forms.ListBox();
            this.groupBox_teachersList = new System.Windows.Forms.GroupBox();
            this.listBox_teachersList = new System.Windows.Forms.ListBox();
            this.chooseButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.dataGridView_table = new System.Windows.Forms.DataGridView();
            this.button_chooseRow = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.TableLabel = new System.Windows.Forms.Label();
            this.toolStrip_MainForm.SuspendLayout();
            this.groupBox_forPrint.SuspendLayout();
            this.groupBox_teachersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.TablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_MainForm
            // 
            this.toolStrip_MainForm.BackColor = System.Drawing.Color.LightCyan;
            this.toolStrip_MainForm.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_MainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_AboutButton,
            this.toolStripSeparator1});
            this.toolStrip_MainForm.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_MainForm.Name = "toolStrip_MainForm";
            this.toolStrip_MainForm.Size = new System.Drawing.Size(1038, 25);
            this.toolStrip_MainForm.TabIndex = 0;
            this.toolStrip_MainForm.Text = "toolStrip1";
            // 
            // toolStrip_AboutButton
            // 
            this.toolStrip_AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_AboutButton.Image")));
            this.toolStrip_AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_AboutButton.Name = "toolStrip_AboutButton";
            this.toolStrip_AboutButton.Size = new System.Drawing.Size(91, 22);
            this.toolStrip_AboutButton.Text = "Об автошколе";
            this.toolStrip_AboutButton.Click += new System.EventHandler(this.toolStrip_AboutButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox_forPrint
            // 
            this.groupBox_forPrint.Controls.Add(this.listBox_forPrint);
            this.groupBox_forPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_forPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_forPrint.ForeColor = System.Drawing.Color.White;
            this.groupBox_forPrint.Location = new System.Drawing.Point(31, 80);
            this.groupBox_forPrint.Name = "groupBox_forPrint";
            this.groupBox_forPrint.Size = new System.Drawing.Size(308, 136);
            this.groupBox_forPrint.TabIndex = 1;
            this.groupBox_forPrint.TabStop = false;
            this.groupBox_forPrint.Text = "Печать документов";
            // 
            // listBox_forPrint
            // 
            this.listBox_forPrint.BackColor = System.Drawing.Color.RoyalBlue;
            this.listBox_forPrint.ItemHeight = 15;
            this.listBox_forPrint.Items.AddRange(new object[] {
            "Заявление на принятие курсанта",
            "Заявка на регистрацию учебных групп",
            "Заявление на допуск сдачи экзамена в ГИБДД",
            "Платёжное поручение за сдачу экзамена в ГИБДД",
            "Экзаменационный протокол",
            "Экзаменационная карточка водителя",
            "Свидетельство об окончании автошколы"});
            this.listBox_forPrint.Location = new System.Drawing.Point(6, 19);
            this.listBox_forPrint.Name = "listBox_forPrint";
            this.listBox_forPrint.Size = new System.Drawing.Size(296, 109);
            this.listBox_forPrint.TabIndex = 2;
            // 
            // groupBox_teachersList
            // 
            this.groupBox_teachersList.Controls.Add(this.listBox_teachersList);
            this.groupBox_teachersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_teachersList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_teachersList.ForeColor = System.Drawing.Color.White;
            this.groupBox_teachersList.Location = new System.Drawing.Point(31, 278);
            this.groupBox_teachersList.Name = "groupBox_teachersList";
            this.groupBox_teachersList.Size = new System.Drawing.Size(308, 121);
            this.groupBox_teachersList.TabIndex = 2;
            this.groupBox_teachersList.TabStop = false;
            this.groupBox_teachersList.Text = "Список преподавателей";
            // 
            // listBox_teachersList
            // 
            this.listBox_teachersList.BackColor = System.Drawing.Color.RoyalBlue;
            this.listBox_teachersList.ItemHeight = 15;
            this.listBox_teachersList.Location = new System.Drawing.Point(6, 20);
            this.listBox_teachersList.Name = "listBox_teachersList";
            this.listBox_teachersList.Size = new System.Drawing.Size(296, 94);
            this.listBox_teachersList.TabIndex = 2;
            // 
            // chooseButton
            // 
            this.chooseButton.BackColor = System.Drawing.Color.White;
            this.chooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseButton.Location = new System.Drawing.Point(131, 405);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(104, 38);
            this.chooseButton.TabIndex = 3;
            this.chooseButton.Text = "Выбрать преподавателя";
            this.chooseButton.UseVisualStyleBackColor = false;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.PeachPuff;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.Location = new System.Drawing.Point(120, 23);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(148, 29);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Найти курсанта";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.White;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_print.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_print.Location = new System.Drawing.Point(131, 222);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(104, 29);
            this.button_print.TabIndex = 5;
            this.button_print.Text = "Печать";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // dataGridView_table
            // 
            this.dataGridView_table.AllowUserToAddRows = false;
            this.dataGridView_table.AllowUserToDeleteRows = false;
            this.dataGridView_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_table.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView_table.Location = new System.Drawing.Point(3, 31);
            this.dataGridView_table.MultiSelect = false;
            this.dataGridView_table.Name = "dataGridView_table";
            this.dataGridView_table.ReadOnly = true;
            this.dataGridView_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_table.Size = new System.Drawing.Size(636, 355);
            this.dataGridView_table.TabIndex = 6;
            // 
            // button_chooseRow
            // 
            this.button_chooseRow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_chooseRow.BackColor = System.Drawing.Color.White;
            this.button_chooseRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_chooseRow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_chooseRow.Location = new System.Drawing.Point(244, 410);
            this.button_chooseRow.Name = "button_chooseRow";
            this.button_chooseRow.Size = new System.Drawing.Size(148, 23);
            this.button_chooseRow.TabIndex = 7;
            this.button_chooseRow.Text = "Выбрать курсанта";
            this.button_chooseRow.UseVisualStyleBackColor = false;
            this.button_chooseRow.Click += new System.EventHandler(this.button_chooseRow_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Controls.Add(this.findButton);
            this.MainPanel.Controls.Add(this.groupBox_forPrint);
            this.MainPanel.Controls.Add(this.groupBox_teachersList);
            this.MainPanel.Controls.Add(this.button_print);
            this.MainPanel.Controls.Add(this.chooseButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.Location = new System.Drawing.Point(0, 25);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(376, 465);
            this.MainPanel.TabIndex = 8;
            // 
            // TablePanel
            // 
            this.TablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TablePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablePanel.Controls.Add(this.TableLabel);
            this.TablePanel.Controls.Add(this.button_chooseRow);
            this.TablePanel.Controls.Add(this.dataGridView_table);
            this.TablePanel.Location = new System.Drawing.Point(392, 28);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(646, 453);
            this.TablePanel.TabIndex = 9;
            // 
            // TableLabel
            // 
            this.TableLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableLabel.ForeColor = System.Drawing.Color.White;
            this.TableLabel.Location = new System.Drawing.Point(255, 5);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(137, 18);
            this.TableLabel.TabIndex = 8;
            this.TableLabel.Text = "Список курсантов";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1038, 490);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.toolStrip_MainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.toolStrip_MainForm.ResumeLayout(false);
            this.toolStrip_MainForm.PerformLayout();
            this.groupBox_forPrint.ResumeLayout(false);
            this.groupBox_teachersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_MainForm;
        private System.Windows.Forms.ToolStripButton toolStrip_AboutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox_forPrint;
        private System.Windows.Forms.ListBox listBox_forPrint;
        private System.Windows.Forms.GroupBox groupBox_teachersList;
        private System.Windows.Forms.ListBox listBox_teachersList;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.DataGridView dataGridView_table;
        private System.Windows.Forms.Button button_chooseRow;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.Label TableLabel;
    }
}