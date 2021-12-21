namespace Gamma
{
    partial class MainForm1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.clouseButton = new System.Windows.Forms.Label();
            this.labelTItle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSeans = new System.Windows.Forms.Panel();
            this.buttonOtchet = new System.Windows.Forms.Button();
            this.buttonPokupka = new System.Windows.Forms.Button();
            this.buttonSeans = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.clouseButton);
            this.panel2.Controls.Add(this.labelTItle);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 98);
            this.panel2.TabIndex = 0;
            // 
            // clouseButton
            // 
            this.clouseButton.AutoSize = true;
            this.clouseButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.clouseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clouseButton.ForeColor = System.Drawing.Color.Crimson;
            this.clouseButton.Location = new System.Drawing.Point(763, 0);
            this.clouseButton.Name = "clouseButton";
            this.clouseButton.Size = new System.Drawing.Size(37, 42);
            this.clouseButton.TabIndex = 1;
            this.clouseButton.Text = "x";
            this.clouseButton.Click += new System.EventHandler(this.clouseButton_Click);
            // 
            // labelTItle
            // 
            this.labelTItle.AutoSize = true;
            this.labelTItle.Font = new System.Drawing.Font("MineCrafter 3", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTItle.ForeColor = System.Drawing.SystemColors.Info;
            this.labelTItle.Location = new System.Drawing.Point(318, 18);
            this.labelTItle.Name = "labelTItle";
            this.labelTItle.Size = new System.Drawing.Size(202, 60);
            this.labelTItle.TabIndex = 0;
            this.labelTItle.Text = "Gamma";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.panelSeans);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 508);
            this.panel1.TabIndex = 7;
            // 
            // panelSeans
            // 
            this.panelSeans.Location = new System.Drawing.Point(0, 104);
            this.panelSeans.Name = "panelSeans";
            this.panelSeans.Size = new System.Drawing.Size(800, 404);
            this.panelSeans.TabIndex = 6;
            // 
            // buttonOtchet
            // 
            this.buttonOtchet.BackColor = System.Drawing.Color.Indigo;
            this.buttonOtchet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOtchet.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.buttonOtchet.FlatAppearance.BorderSize = 0;
            this.buttonOtchet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOtchet.Font = new System.Drawing.Font("MineCrafter 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOtchet.ForeColor = System.Drawing.Color.OldLace;
            this.buttonOtchet.Location = new System.Drawing.Point(541, 531);
            this.buttonOtchet.Name = "buttonOtchet";
            this.buttonOtchet.Size = new System.Drawing.Size(260, 69);
            this.buttonOtchet.TabIndex = 5;
            this.buttonOtchet.Text = "Отчет";
            this.buttonOtchet.UseVisualStyleBackColor = false;
            this.buttonOtchet.Click += new System.EventHandler(this.buttonOtchet_Click);
            // 
            // buttonPokupka
            // 
            this.buttonPokupka.BackColor = System.Drawing.Color.Indigo;
            this.buttonPokupka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPokupka.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonPokupka.FlatAppearance.BorderSize = 0;
            this.buttonPokupka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPokupka.Font = new System.Drawing.Font("MineCrafter 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPokupka.ForeColor = System.Drawing.Color.OldLace;
            this.buttonPokupka.Location = new System.Drawing.Point(254, 531);
            this.buttonPokupka.Name = "buttonPokupka";
            this.buttonPokupka.Size = new System.Drawing.Size(288, 69);
            this.buttonPokupka.TabIndex = 4;
            this.buttonPokupka.Text = "Покупка";
            this.buttonPokupka.UseVisualStyleBackColor = false;
            this.buttonPokupka.Click += new System.EventHandler(this.buttonPokupka_Click);
            // 
            // buttonSeans
            // 
            this.buttonSeans.BackColor = System.Drawing.Color.Indigo;
            this.buttonSeans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSeans.FlatAppearance.BorderSize = 0;
            this.buttonSeans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeans.Font = new System.Drawing.Font("MineCrafter 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeans.ForeColor = System.Drawing.Color.OldLace;
            this.buttonSeans.Location = new System.Drawing.Point(1, 531);
            this.buttonSeans.Name = "buttonSeans";
            this.buttonSeans.Size = new System.Drawing.Size(260, 69);
            this.buttonSeans.TabIndex = 1;
            this.buttonSeans.Text = "Сеансы";
            this.buttonSeans.UseVisualStyleBackColor = false;
            this.buttonSeans.Click += new System.EventHandler(this.buttonSeans_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOtchet);
            this.Controls.Add(this.buttonPokupka);
            this.Controls.Add(this.buttonSeans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm1";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label clouseButton;
        private System.Windows.Forms.Label labelTItle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSeans;
        private System.Windows.Forms.Button buttonOtchet;
        private System.Windows.Forms.Button buttonPokupka;
        private System.Windows.Forms.Panel panelSeans;
    }
}