namespace WinFormsApp1
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
            this.Ntxt = new System.Windows.Forms.TextBox();
            this.dxtxt = new System.Windows.Forms.TextBox();
            this.PItxt = new System.Windows.Forms.TextBox();
            this.Areatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Calcularbtn = new System.Windows.Forms.Button();
            this.Borrarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ntxt
            // 
            this.Ntxt.Location = new System.Drawing.Point(152, 38);
            this.Ntxt.Name = "Ntxt";
            this.Ntxt.Size = new System.Drawing.Size(100, 23);
            this.Ntxt.TabIndex = 0;
            this.Ntxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dxtxt
            // 
            this.dxtxt.Location = new System.Drawing.Point(152, 85);
            this.dxtxt.Name = "dxtxt";
            this.dxtxt.Size = new System.Drawing.Size(100, 23);
            this.dxtxt.TabIndex = 1;
            // 
            // PItxt
            // 
            this.PItxt.Location = new System.Drawing.Point(385, 85);
            this.PItxt.Name = "PItxt";
            this.PItxt.Size = new System.Drawing.Size(100, 23);
            this.PItxt.TabIndex = 2;
            // 
            // Areatxt
            // 
            this.Areatxt.Location = new System.Drawing.Point(385, 38);
            this.Areatxt.Name = "Areatxt";
            this.Areatxt.Size = new System.Drawing.Size(100, 23);
            this.Areatxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduzca N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introduzca Dx:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(347, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "PI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(321, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // Calcularbtn
            // 
            this.Calcularbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calcularbtn.Location = new System.Drawing.Point(150, 159);
            this.Calcularbtn.Name = "Calcularbtn";
            this.Calcularbtn.Size = new System.Drawing.Size(102, 64);
            this.Calcularbtn.TabIndex = 8;
            this.Calcularbtn.Text = "Calcular";
            this.Calcularbtn.UseVisualStyleBackColor = true;
            this.Calcularbtn.Click += new System.EventHandler(this.Calcularbtn_Click);
            // 
            // Borrarbtn
            // 
            this.Borrarbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Borrarbtn.Location = new System.Drawing.Point(383, 159);
            this.Borrarbtn.Name = "Borrarbtn";
            this.Borrarbtn.Size = new System.Drawing.Size(102, 64);
            this.Borrarbtn.TabIndex = 9;
            this.Borrarbtn.Text = "Borrar";
            this.Borrarbtn.UseVisualStyleBackColor = true;
            this.Borrarbtn.Click += new System.EventHandler(this.Borrarbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 332);
            this.Controls.Add(this.Borrarbtn);
            this.Controls.Add(this.Calcularbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Areatxt);
            this.Controls.Add(this.PItxt);
            this.Controls.Add(this.dxtxt);
            this.Controls.Add(this.Ntxt);
            this.Name = "Form2";
            this.Text = "Integralediscreta";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Ntxt;
        private TextBox dxtxt;
        private TextBox PItxt;
        private TextBox Areatxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Calcularbtn;
        private Button Borrarbtn;
    }
}