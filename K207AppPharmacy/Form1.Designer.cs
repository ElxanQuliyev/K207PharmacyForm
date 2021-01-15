
namespace K207AppPharmacy
{
    partial class Form1
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
            this.btnBuyMedicine = new System.Windows.Forms.Button();
            this.ckBuyMedList = new System.Windows.Forms.CheckedListBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.nmBuyCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuyMedName = new System.Windows.Forms.TextBox();
            this.SellMedicinePanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.firmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgMedicineList = new System.Windows.Forms.DataGridView();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnOpenBarcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyCount)).BeginInit();
            this.SellMedicinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicineList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuyMedicine
            // 
            this.btnBuyMedicine.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBuyMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyMedicine.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyMedicine.ForeColor = System.Drawing.Color.Honeydew;
            this.btnBuyMedicine.Location = new System.Drawing.Point(174, 188);
            this.btnBuyMedicine.Name = "btnBuyMedicine";
            this.btnBuyMedicine.Size = new System.Drawing.Size(88, 37);
            this.btnBuyMedicine.TabIndex = 25;
            this.btnBuyMedicine.Text = "Buy";
            this.btnBuyMedicine.UseVisualStyleBackColor = false;
            this.btnBuyMedicine.Click += new System.EventHandler(this.btnBuyMedicine_Click);
            // 
            // ckBuyMedList
            // 
            this.ckBuyMedList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBuyMedList.ColumnWidth = 150;
            this.ckBuyMedList.FormattingEnabled = true;
            this.ckBuyMedList.Location = new System.Drawing.Point(174, 14);
            this.ckBuyMedList.MultiColumn = true;
            this.ckBuyMedList.Name = "ckBuyMedList";
            this.ckBuyMedList.Size = new System.Drawing.Size(327, 154);
            this.ckBuyMedList.TabIndex = 24;
            this.ckBuyMedList.SelectedIndexChanged += new System.EventHandler(this.ckBuyMedList_SelectedIndexChanged);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.Honeydew;
            this.btnAddMedicine.Location = new System.Drawing.Point(8, 132);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(88, 37);
            this.btnAddMedicine.TabIndex = 16;
            this.btnAddMedicine.Text = "Add";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // nmBuyCount
            // 
            this.nmBuyCount.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmBuyCount.Location = new System.Drawing.Point(8, 103);
            this.nmBuyCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmBuyCount.Name = "nmBuyCount";
            this.nmBuyCount.Size = new System.Drawing.Size(160, 23);
            this.nmBuyCount.TabIndex = 15;
            this.nmBuyCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(4, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Count";
            // 
            // txtBuyMedName
            // 
            this.txtBuyMedName.Enabled = false;
            this.txtBuyMedName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyMedName.Location = new System.Drawing.Point(8, 37);
            this.txtBuyMedName.Name = "txtBuyMedName";
            this.txtBuyMedName.Size = new System.Drawing.Size(160, 23);
            this.txtBuyMedName.TabIndex = 0;
            // 
            // SellMedicinePanel
            // 
            this.SellMedicinePanel.Controls.Add(this.btnBuyMedicine);
            this.SellMedicinePanel.Controls.Add(this.ckBuyMedList);
            this.SellMedicinePanel.Controls.Add(this.btnAddMedicine);
            this.SellMedicinePanel.Controls.Add(this.nmBuyCount);
            this.SellMedicinePanel.Controls.Add(this.label7);
            this.SellMedicinePanel.Controls.Add(this.label6);
            this.SellMedicinePanel.Controls.Add(this.txtBuyMedName);
            this.SellMedicinePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SellMedicinePanel.Location = new System.Drawing.Point(463, 31);
            this.SellMedicinePanel.Name = "SellMedicinePanel";
            this.SellMedicinePanel.Size = new System.Drawing.Size(533, 283);
            this.SellMedicinePanel.TabIndex = 25;
            this.SellMedicinePanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(4, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Medicine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Həm istifadə tarixi,həmdə sayı bitib";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 21);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Son istifadə tarixi bitib";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 21);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 20);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // firmsToolStripMenuItem
            // 
            this.firmsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firmsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.firmsToolStripMenuItem.Name = "firmsToolStripMenuItem";
            this.firmsToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.firmsToolStripMenuItem.Text = "Firms";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.medicineToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.medicineToolStripMenuItem.Text = "Medicine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Məhsul sayı bitib";
            // 
            // dtgMedicineList
            // 
            this.dtgMedicineList.AllowUserToAddRows = false;
            this.dtgMedicineList.AllowUserToDeleteRows = false;
            this.dtgMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicineList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicineList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgMedicineList.Location = new System.Drawing.Point(0, 314);
            this.dtgMedicineList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgMedicineList.Name = "dtgMedicineList";
            this.dtgMedicineList.ReadOnly = true;
            this.dtgMedicineList.Size = new System.Drawing.Size(996, 201);
            this.dtgMedicineList.TabIndex = 17;
            this.dtgMedicineList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMedicineList_RowHeaderMouseDoubleClick);
            // 
            // cmbTags
            // 
            this.cmbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.IntegralHeight = false;
            this.cmbTags.ItemHeight = 18;
            this.cmbTags.Location = new System.Drawing.Point(199, 275);
            this.cmbTags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(154, 26);
            this.cmbTags.TabIndex = 16;
            this.cmbTags.SelectedIndexChanged += new System.EventHandler(this.cmbTags_SelectedIndexChanged);
            this.cmbTags.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbTags_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(193, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tags";
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(19, 275);
            this.cmbMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(154, 26);
            this.cmbMedicine.TabIndex = 14;
            this.cmbMedicine.SelectedIndexChanged += new System.EventHandler(this.cmbMedicine_SelectedIndexChanged);
            this.cmbMedicine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbMedicine_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(13, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Medicine";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineToolStripMenuItem,
            this.firmsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(996, 31);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnOpenBarcode
            // 
            this.btnOpenBarcode.BackColor = System.Drawing.Color.Orange;
            this.btnOpenBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBarcode.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBarcode.ForeColor = System.Drawing.Color.Honeydew;
            this.btnOpenBarcode.Location = new System.Drawing.Point(274, 164);
            this.btnOpenBarcode.Name = "btnOpenBarcode";
            this.btnOpenBarcode.Size = new System.Drawing.Size(141, 36);
            this.btnOpenBarcode.TabIndex = 26;
            this.btnOpenBarcode.Text = "Open Barcode";
            this.btnOpenBarcode.UseVisualStyleBackColor = false;
            this.btnOpenBarcode.Click += new System.EventHandler(this.btnOpenBarcode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 515);
            this.Controls.Add(this.btnOpenBarcode);
            this.Controls.Add(this.SellMedicinePanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgMedicineList);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMedicine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyCount)).EndInit();
            this.SellMedicinePanel.ResumeLayout(false);
            this.SellMedicinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicineList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuyMedicine;
        private System.Windows.Forms.CheckedListBox ckBuyMedList;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.NumericUpDown nmBuyCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuyMedName;
        private System.Windows.Forms.Panel SellMedicinePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem firmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgMedicineList;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnOpenBarcode;
    }
}

