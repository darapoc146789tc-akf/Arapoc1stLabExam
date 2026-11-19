namespace Arapoc1stLabExam
{
    partial class Form2
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
            this.Sum = new System.Windows.Forms.Label();
            this.lbl_Danielle = new System.Windows.Forms.Label();
            this.lbl_Edward = new System.Windows.Forms.Label();
            this.lbl_Fatima = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(331, 99);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(133, 22);
            this.Sum.TabIndex = 0;
            this.Sum.Text = "Sales Summary";
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // lbl_Danielle
            // 
            this.lbl_Danielle.AutoSize = true;
            this.lbl_Danielle.Location = new System.Drawing.Point(205, 140);
            this.lbl_Danielle.Name = "lbl_Danielle";
            this.lbl_Danielle.Size = new System.Drawing.Size(70, 20);
            this.lbl_Danielle.TabIndex = 1;
            this.lbl_Danielle.Text = "Danielle:";
            // 
            // lbl_Edward
            // 
            this.lbl_Edward.AutoSize = true;
            this.lbl_Edward.Location = new System.Drawing.Point(205, 192);
            this.lbl_Edward.Name = "lbl_Edward";
            this.lbl_Edward.Size = new System.Drawing.Size(67, 20);
            this.lbl_Edward.TabIndex = 2;
            this.lbl_Edward.Text = "Edward:";
            this.lbl_Edward.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Fatima
            // 
            this.lbl_Fatima.AutoSize = true;
            this.lbl_Fatima.Location = new System.Drawing.Point(205, 237);
            this.lbl_Fatima.Name = "lbl_Fatima";
            this.lbl_Fatima.Size = new System.Drawing.Size(62, 20);
            this.lbl_Fatima.TabIndex = 3;
            this.lbl_Fatima.Text = "Fatima:";
            this.lbl_Fatima.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(205, 284);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(48, 20);
            this.lbl_Total.TabIndex = 4;
            this.lbl_Total.Text = "Total:";
            this.lbl_Total.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(366, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Fatima);
            this.Controls.Add(this.lbl_Edward);
            this.Controls.Add(this.lbl_Danielle);
            this.Controls.Add(this.Sum);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label lbl_Danielle;
        private System.Windows.Forms.Label lbl_Edward;
        private System.Windows.Forms.Label lbl_Fatima;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button button1;
    }
}