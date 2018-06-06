namespace Prvocisla
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
            this.Velkost = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.TextBox();
            this.Vypis = new System.Windows.Forms.TextBox();
            this.Prvocisla = new System.Windows.Forms.TextBox();
            this.vytvorPole = new System.Windows.Forms.Button();
            this.zistiPrvocisla = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.saveAs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Velkost
            // 
            this.Velkost.Location = new System.Drawing.Point(28, 56);
            this.Velkost.Name = "Velkost";
            this.Velkost.Size = new System.Drawing.Size(100, 22);
            this.Velkost.TabIndex = 0;
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(287, 57);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(100, 22);
            this.Min.TabIndex = 1;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(547, 57);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(100, 22);
            this.Max.TabIndex = 2;
            // 
            // Vypis
            // 
            this.Vypis.Location = new System.Drawing.Point(29, 148);
            this.Vypis.Multiline = true;
            this.Vypis.Name = "Vypis";
            this.Vypis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Vypis.Size = new System.Drawing.Size(617, 83);
            this.Vypis.TabIndex = 3;
            // 
            // Prvocisla
            // 
            this.Prvocisla.Location = new System.Drawing.Point(30, 334);
            this.Prvocisla.Multiline = true;
            this.Prvocisla.Name = "Prvocisla";
            this.Prvocisla.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Prvocisla.Size = new System.Drawing.Size(617, 83);
            this.Prvocisla.TabIndex = 4;
            // 
            // vytvorPole
            // 
            this.vytvorPole.Location = new System.Drawing.Point(276, 112);
            this.vytvorPole.Name = "vytvorPole";
            this.vytvorPole.Size = new System.Drawing.Size(120, 30);
            this.vytvorPole.TabIndex = 5;
            this.vytvorPole.Text = "Generuj pole";
            this.vytvorPole.UseVisualStyleBackColor = true;
            this.vytvorPole.Click += new System.EventHandler(this.vytvorPole_Click);
            // 
            // zistiPrvocisla
            // 
            this.zistiPrvocisla.Location = new System.Drawing.Point(276, 298);
            this.zistiPrvocisla.Name = "zistiPrvocisla";
            this.zistiPrvocisla.Size = new System.Drawing.Size(120, 30);
            this.zistiPrvocisla.TabIndex = 6;
            this.zistiPrvocisla.Text = "Vypis prvocisla";
            this.zistiPrvocisla.UseVisualStyleBackColor = true;
            this.zistiPrvocisla.Click += new System.EventHandler(this.zistiPrvocisla_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Textovy subor (.txt) |.txt";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(28, 497);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 23);
            this.save.TabIndex = 7;
            this.save.Text = "Uložiť";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAs
            // 
            this.saveAs.Location = new System.Drawing.Point(134, 497);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(100, 23);
            this.saveAs.TabIndex = 8;
            this.saveAs.Text = "Uložiť ako";
            this.saveAs.UseVisualStyleBackColor = true;
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Velkost poľa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Minimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Maximum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 532);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveAs);
            this.Controls.Add(this.save);
            this.Controls.Add(this.zistiPrvocisla);
            this.Controls.Add(this.vytvorPole);
            this.Controls.Add(this.Prvocisla);
            this.Controls.Add(this.Vypis);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Velkost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Velkost;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox Vypis;
        private System.Windows.Forms.TextBox Prvocisla;
        private System.Windows.Forms.Button vytvorPole;
        private System.Windows.Forms.Button zistiPrvocisla;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button saveAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

