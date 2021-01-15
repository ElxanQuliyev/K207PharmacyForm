
namespace K207AppPharmacy
{
    partial class BarcodeReaderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.SellMedicinePanel = new System.Windows.Forms.Panel();
            this.btnBuyMedicine = new System.Windows.Forms.Button();
            this.ckBuyMedList = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nmBuyCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuyMedName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SellMedicinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera:";
            // 
            // cmbCamera
            // 
            this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(76, 13);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(173, 21);
            this.cmbCamera.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(16, 65);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(405, 234);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(16, 318);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(233, 20);
            this.txtBarcode.TabIndex = 3;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.Honeydew;
            this.btnAddMedicine.Location = new System.Drawing.Point(333, 310);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(88, 37);
            this.btnAddMedicine.TabIndex = 17;
            this.btnAddMedicine.Text = "Start";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // SellMedicinePanel
            // 
            this.SellMedicinePanel.Controls.Add(this.btnBuyMedicine);
            this.SellMedicinePanel.Controls.Add(this.ckBuyMedList);
            this.SellMedicinePanel.Controls.Add(this.button1);
            this.SellMedicinePanel.Controls.Add(this.nmBuyCount);
            this.SellMedicinePanel.Controls.Add(this.label7);
            this.SellMedicinePanel.Controls.Add(this.label6);
            this.SellMedicinePanel.Controls.Add(this.txtBuyMedName);
            this.SellMedicinePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SellMedicinePanel.Location = new System.Drawing.Point(466, 0);
            this.SellMedicinePanel.Name = "SellMedicinePanel";
            this.SellMedicinePanel.Size = new System.Drawing.Size(533, 450);
            this.SellMedicinePanel.TabIndex = 26;
            this.SellMedicinePanel.Visible = false;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(8, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // txtBuyMedName
            // 
            this.txtBuyMedName.Enabled = false;
            this.txtBuyMedName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyMedName.Location = new System.Drawing.Point(8, 37);
            this.txtBuyMedName.Name = "txtBuyMedName";
            this.txtBuyMedName.Size = new System.Drawing.Size(160, 23);
            this.txtBuyMedName.TabIndex = 0;
            // 
            // BarcodeReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.SellMedicinePanel);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cmbCamera);
            this.Controls.Add(this.label1);
            this.Name = "BarcodeReaderForm";
            this.Text = "BarcodeReaderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BarcodeReaderForm_FormClosing);
            this.Load += new System.EventHandler(this.BarcodeReaderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.SellMedicinePanel.ResumeLayout(false);
            this.SellMedicinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Panel SellMedicinePanel;
        private System.Windows.Forms.Button btnBuyMedicine;
        private System.Windows.Forms.CheckedListBox ckBuyMedList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nmBuyCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuyMedName;
    }
}