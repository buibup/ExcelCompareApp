namespace ExcelCompareApp
{
    partial class Test
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.firstExcel_txt = new System.Windows.Forms.TextBox();
            this.secondExcel_txt = new System.Windows.Forms.TextBox();
            this.compare_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // firstExcel_txt
            // 
            this.firstExcel_txt.Location = new System.Drawing.Point(49, 58);
            this.firstExcel_txt.Name = "firstExcel_txt";
            this.firstExcel_txt.Size = new System.Drawing.Size(100, 20);
            this.firstExcel_txt.TabIndex = 0;
            // 
            // secondExcel_txt
            // 
            this.secondExcel_txt.Location = new System.Drawing.Point(365, 61);
            this.secondExcel_txt.Name = "secondExcel_txt";
            this.secondExcel_txt.Size = new System.Drawing.Size(100, 20);
            this.secondExcel_txt.TabIndex = 1;
            // 
            // compare_btn
            // 
            this.compare_btn.Location = new System.Drawing.Point(213, 58);
            this.compare_btn.Name = "compare_btn";
            this.compare_btn.Size = new System.Drawing.Size(75, 23);
            this.compare_btn.TabIndex = 2;
            this.compare_btn.Text = "Compare";
            this.compare_btn.UseVisualStyleBackColor = true;
            this.compare_btn.Click += new System.EventHandler(this.compare_btn_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 261);
            this.Controls.Add(this.compare_btn);
            this.Controls.Add(this.secondExcel_txt);
            this.Controls.Add(this.firstExcel_txt);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox firstExcel_txt;
        private System.Windows.Forms.TextBox secondExcel_txt;
        private System.Windows.Forms.Button compare_btn;
    }
}