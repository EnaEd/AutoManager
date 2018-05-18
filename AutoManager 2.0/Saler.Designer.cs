namespace AutoManager_2._0
{
    partial class Saler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chckBxFindEx = new System.Windows.Forms.CheckBox();
            this.grpBxFindEx = new System.Windows.Forms.GroupBox();
            this.cmbBxVinCode = new System.Windows.Forms.ComboBox();
            this.lblVinCode = new System.Windows.Forms.Label();
            this.cmbBxBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBxModel = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblPrice = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stLblNameEmpl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnFind = new System.Windows.Forms.Button();
            this.stLblEmpl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBxFindEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 156);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chckBxFindEx
            // 
            this.chckBxFindEx.AutoSize = true;
            this.chckBxFindEx.Location = new System.Drawing.Point(401, 29);
            this.chckBxFindEx.Name = "chckBxFindEx";
            this.chckBxFindEx.Size = new System.Drawing.Size(130, 17);
            this.chckBxFindEx.TabIndex = 3;
            this.chckBxFindEx.Text = "Расширенный поиск";
            this.chckBxFindEx.UseVisualStyleBackColor = true;
            this.chckBxFindEx.CheckedChanged += new System.EventHandler(this.chckBxFindEx_CheckedChanged);
            // 
            // grpBxFindEx
            // 
            this.grpBxFindEx.Controls.Add(this.lblPrice);
            this.grpBxFindEx.Controls.Add(this.trackBar1);
            this.grpBxFindEx.Controls.Add(this.lblModel);
            this.grpBxFindEx.Controls.Add(this.cmbBxModel);
            this.grpBxFindEx.Controls.Add(this.lblBrand);
            this.grpBxFindEx.Controls.Add(this.cmbBxBrand);
            this.grpBxFindEx.Controls.Add(this.lblVinCode);
            this.grpBxFindEx.Controls.Add(this.cmbBxVinCode);
            this.grpBxFindEx.Location = new System.Drawing.Point(13, 51);
            this.grpBxFindEx.Name = "grpBxFindEx";
            this.grpBxFindEx.Size = new System.Drawing.Size(679, 122);
            this.grpBxFindEx.TabIndex = 4;
            this.grpBxFindEx.TabStop = false;
            this.grpBxFindEx.Text = "Расширенный поиск";
            this.grpBxFindEx.Visible = false;
            // 
            // cmbBxVinCode
            // 
            this.cmbBxVinCode.FormattingEnabled = true;
            this.cmbBxVinCode.Location = new System.Drawing.Point(6, 30);
            this.cmbBxVinCode.Name = "cmbBxVinCode";
            this.cmbBxVinCode.Size = new System.Drawing.Size(203, 21);
            this.cmbBxVinCode.TabIndex = 0;
            // 
            // lblVinCode
            // 
            this.lblVinCode.AutoSize = true;
            this.lblVinCode.Location = new System.Drawing.Point(215, 33);
            this.lblVinCode.Name = "lblVinCode";
            this.lblVinCode.Size = new System.Drawing.Size(47, 13);
            this.lblVinCode.TabIndex = 1;
            this.lblVinCode.Text = "VinCode";
            // 
            // cmbBxBrand
            // 
            this.cmbBxBrand.FormattingEnabled = true;
            this.cmbBxBrand.Location = new System.Drawing.Point(280, 20);
            this.cmbBxBrand.Name = "cmbBxBrand";
            this.cmbBxBrand.Size = new System.Drawing.Size(192, 21);
            this.cmbBxBrand.TabIndex = 2;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(478, 23);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(40, 13);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Марка";
            // 
            // cmbBxModel
            // 
            this.cmbBxModel.FormattingEnabled = true;
            this.cmbBxModel.Location = new System.Drawing.Point(280, 48);
            this.cmbBxModel.Name = "cmbBxModel";
            this.cmbBxModel.Size = new System.Drawing.Size(192, 21);
            this.cmbBxModel.TabIndex = 4;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(478, 51);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 13);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Модель";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(280, 76);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(192, 45);
            this.trackBar1.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(479, 76);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Цена";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLblNameEmpl,
            this.stLblEmpl,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(706, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stLblNameEmpl
            // 
            this.stLblNameEmpl.Name = "stLblNameEmpl";
            this.stLblNameEmpl.Size = new System.Drawing.Size(0, 17);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(291, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Поиск";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // stLblEmpl
            // 
            this.stLblEmpl.Name = "stLblEmpl";
            this.stLblEmpl.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // Saler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 392);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpBxFindEx);
            this.Controls.Add(this.chckBxFindEx);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Saler";
            this.Text = "Saler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBxFindEx.ResumeLayout(false);
            this.grpBxFindEx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chckBxFindEx;
        private System.Windows.Forms.GroupBox grpBxFindEx;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbBxModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBxBrand;
        private System.Windows.Forms.Label lblVinCode;
        private System.Windows.Forms.ComboBox cmbBxVinCode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stLblNameEmpl;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ToolStripStatusLabel stLblEmpl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}