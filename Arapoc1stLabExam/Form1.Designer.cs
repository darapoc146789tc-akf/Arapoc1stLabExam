namespace Arapoc1stLabExam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_Initial = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "D: Danielle    E: Edward    F:Fatima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Sales Person Initial:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount of Sale:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Submit.Location = new System.Drawing.Point(194, 315);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(83, 36);
            this.Btn_Submit.TabIndex = 3;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = false;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Btn_Clear.Location = new System.Drawing.Point(309, 315);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(82, 39);
            this.Btn_Clear.TabIndex = 4;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Location = new System.Drawing.Point(416, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Print Summary";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_Initial
            // 
            this.txt_Initial.Location = new System.Drawing.Point(416, 176);
            this.txt_Initial.Name = "txt_Initial";
            this.txt_Initial.Size = new System.Drawing.Size(100, 26);
            this.txt_Initial.TabIndex = 6;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(416, 226);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(100, 26);
            this.txt_Amount.TabIndex = 7;
            this.txt_Amount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_Display
            // 
            this.lbl_Display.AutoSize = true;
            this.lbl_Display.Location = new System.Drawing.Point(190, 387);
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.Size = new System.Drawing.Size(0, 20);
            this.lbl_Display.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Display);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.txt_Initial);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_Initial;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label lbl_Display;
    }
}

