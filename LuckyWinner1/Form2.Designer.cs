
namespace LuckyWinner1
{
    partial class FormOtchet
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
            this.dataGridViewO = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewO)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewO
            // 
            this.dataGridViewO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewO.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewO.Name = "dataGridViewO";
            this.dataGridViewO.Size = new System.Drawing.Size(760, 328);
            this.dataGridViewO.TabIndex = 0;
            // 
            // FormOtchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(784, 365);
            this.Controls.Add(this.dataGridViewO);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "FormOtchet";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormOtchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewO;
    }
}