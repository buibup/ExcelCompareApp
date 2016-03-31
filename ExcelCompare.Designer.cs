namespace ExcelCompareApp
{
    partial class ExcelCompare
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbFile1 = new System.Windows.Forms.GroupBox();
            this.lblMsgFile1 = new System.Windows.Forms.Label();
            this.Sheet = new System.Windows.Forms.Label();
            this.cbSheetFile1 = new System.Windows.Forms.ComboBox();
            this.btnChooseFil1 = new System.Windows.Forms.Button();
            this.gbFile2 = new System.Windows.Forms.GroupBox();
            this.lblMsgFile2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseFil2 = new System.Windows.Forms.Button();
            this.cbSheetFile2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblMsgResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.gbFile1.SuspendLayout();
            this.gbFile2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 36);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(326, 20);
            this.textBox2.TabIndex = 10;
            // 
            // gbFile1
            // 
            this.gbFile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbFile1.Controls.Add(this.lblMsgFile1);
            this.gbFile1.Controls.Add(this.Sheet);
            this.gbFile1.Controls.Add(this.cbSheetFile1);
            this.gbFile1.Controls.Add(this.btnChooseFil1);
            this.gbFile1.Controls.Add(this.textBox1);
            this.gbFile1.Location = new System.Drawing.Point(11, 12);
            this.gbFile1.Name = "gbFile1";
            this.gbFile1.Size = new System.Drawing.Size(414, 119);
            this.gbFile1.TabIndex = 22;
            this.gbFile1.TabStop = false;
            this.gbFile1.Text = "File1";
            // 
            // lblMsgFile1
            // 
            this.lblMsgFile1.AutoSize = true;
            this.lblMsgFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMsgFile1.Location = new System.Drawing.Point(30, 99);
            this.lblMsgFile1.Name = "lblMsgFile1";
            this.lblMsgFile1.Size = new System.Drawing.Size(0, 17);
            this.lblMsgFile1.TabIndex = 24;
            // 
            // Sheet
            // 
            this.Sheet.AutoSize = true;
            this.Sheet.Location = new System.Drawing.Point(259, 69);
            this.Sheet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sheet.Name = "Sheet";
            this.Sheet.Size = new System.Drawing.Size(72, 13);
            this.Sheet.TabIndex = 26;
            this.Sheet.Text = "Choose sheet";
            // 
            // cbSheetFile1
            // 
            this.cbSheetFile1.FormattingEnabled = true;
            this.cbSheetFile1.Location = new System.Drawing.Point(33, 66);
            this.cbSheetFile1.Margin = new System.Windows.Forms.Padding(2);
            this.cbSheetFile1.Name = "cbSheetFile1";
            this.cbSheetFile1.Size = new System.Drawing.Size(222, 21);
            this.cbSheetFile1.TabIndex = 25;
            this.cbSheetFile1.SelectedIndexChanged += new System.EventHandler(this.cbSheetFile1_SelectedIndexChanged);
            // 
            // btnChooseFil1
            // 
            this.btnChooseFil1.BackColor = System.Drawing.Color.Wheat;
            this.btnChooseFil1.Location = new System.Drawing.Point(333, 36);
            this.btnChooseFil1.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseFil1.Name = "btnChooseFil1";
            this.btnChooseFil1.Size = new System.Drawing.Size(81, 20);
            this.btnChooseFil1.TabIndex = 15;
            this.btnChooseFil1.Text = "Select file";
            this.btnChooseFil1.UseVisualStyleBackColor = false;
            this.btnChooseFil1.Click += new System.EventHandler(this.btnChooseFil1_Click);
            // 
            // gbFile2
            // 
            this.gbFile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbFile2.Controls.Add(this.lblMsgFile2);
            this.gbFile2.Controls.Add(this.label1);
            this.gbFile2.Controls.Add(this.btnChooseFil2);
            this.gbFile2.Controls.Add(this.cbSheetFile2);
            this.gbFile2.Controls.Add(this.textBox2);
            this.gbFile2.Location = new System.Drawing.Point(466, 12);
            this.gbFile2.Name = "gbFile2";
            this.gbFile2.Size = new System.Drawing.Size(414, 119);
            this.gbFile2.TabIndex = 23;
            this.gbFile2.TabStop = false;
            this.gbFile2.Text = "File2";
            // 
            // lblMsgFile2
            // 
            this.lblMsgFile2.AutoSize = true;
            this.lblMsgFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMsgFile2.Location = new System.Drawing.Point(30, 99);
            this.lblMsgFile2.Name = "lblMsgFile2";
            this.lblMsgFile2.Size = new System.Drawing.Size(0, 17);
            this.lblMsgFile2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Choose sheet";
            // 
            // btnChooseFil2
            // 
            this.btnChooseFil2.BackColor = System.Drawing.Color.Wheat;
            this.btnChooseFil2.Location = new System.Drawing.Point(333, 36);
            this.btnChooseFil2.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseFil2.Name = "btnChooseFil2";
            this.btnChooseFil2.Size = new System.Drawing.Size(81, 20);
            this.btnChooseFil2.TabIndex = 16;
            this.btnChooseFil2.Text = "Select file";
            this.btnChooseFil2.UseVisualStyleBackColor = false;
            this.btnChooseFil2.Click += new System.EventHandler(this.btnChooseFil2_Click);
            // 
            // cbSheetFile2
            // 
            this.cbSheetFile2.FormattingEnabled = true;
            this.cbSheetFile2.Location = new System.Drawing.Point(33, 66);
            this.cbSheetFile2.Margin = new System.Windows.Forms.Padding(2);
            this.cbSheetFile2.Name = "cbSheetFile2";
            this.cbSheetFile2.Size = new System.Drawing.Size(222, 21);
            this.cbSheetFile2.TabIndex = 27;
            this.cbSheetFile2.SelectedIndexChanged += new System.EventHandler(this.cbSheetFile2_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(868, 330);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCompare.Location = new System.Drawing.Point(11, 150);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(93, 34);
            this.btnCompare.TabIndex = 25;
            this.btnCompare.Text = "Compare Excel";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblMsgResult
            // 
            this.lblMsgResult.AutoSize = true;
            this.lblMsgResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMsgResult.Location = new System.Drawing.Point(110, 159);
            this.lblMsgResult.Name = "lblMsgResult";
            this.lblMsgResult.Size = new System.Drawing.Size(0, 17);
            this.lblMsgResult.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(11, 526);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 31);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(793, 526);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(86, 31);
            this.btnExportToExcel.TabIndex = 29;
            this.btnExportToExcel.Text = "ExportToExcel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // ExcelCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(892, 567);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMsgResult);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbFile1);
            this.Controls.Add(this.gbFile2);
            this.Name = "ExcelCompare";
            this.Text = "ExcelCompare";
            this.Load += new System.EventHandler(this.ExcelCompare_Load);
            this.gbFile1.ResumeLayout(false);
            this.gbFile1.PerformLayout();
            this.gbFile2.ResumeLayout(false);
            this.gbFile2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbFile1;
        private System.Windows.Forms.GroupBox gbFile2;
        private System.Windows.Forms.Label lblMsgFile1;
        private System.Windows.Forms.Label Sheet;
        private System.Windows.Forms.ComboBox cbSheetFile1;
        private System.Windows.Forms.Button btnChooseFil1;
        private System.Windows.Forms.Label lblMsgFile2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseFil2;
        private System.Windows.Forms.ComboBox cbSheetFile2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblMsgResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

