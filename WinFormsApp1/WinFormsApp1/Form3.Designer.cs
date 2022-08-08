namespace WinFormsApp1
{
    partial class Form3
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
            this.atxt = new System.Windows.Forms.TextBox();
            this.btxt = new System.Windows.Forms.TextBox();
            this.ctxt = new System.Windows.Forms.TextBox();
            this.respuestap = new System.Windows.Forms.TextBox();
            this.respuestan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculartbtn = new System.Windows.Forms.Button();
            this.limpiarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // atxt
            // 
            this.atxt.Location = new System.Drawing.Point(73, 27);
            this.atxt.Name = "atxt";
            this.atxt.Size = new System.Drawing.Size(100, 23);
            this.atxt.TabIndex = 0;
            // 
            // btxt
            // 
            this.btxt.Location = new System.Drawing.Point(73, 77);
            this.btxt.Name = "btxt";
            this.btxt.Size = new System.Drawing.Size(100, 23);
            this.btxt.TabIndex = 1;
            // 
            // ctxt
            // 
            this.ctxt.Location = new System.Drawing.Point(73, 127);
            this.ctxt.Name = "ctxt";
            this.ctxt.Size = new System.Drawing.Size(100, 23);
            this.ctxt.TabIndex = 2;
            // 
            // respuestap
            // 
            this.respuestap.Location = new System.Drawing.Point(257, 27);
            this.respuestap.Name = "respuestap";
            this.respuestap.Size = new System.Drawing.Size(100, 23);
            this.respuestap.TabIndex = 3;
            // 
            // respuestan
            // 
            this.respuestan.Location = new System.Drawing.Point(257, 77);
            this.respuestan.Name = "respuestan";
            this.respuestan.Size = new System.Drawing.Size(100, 23);
            this.respuestan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inserte a :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inserte b: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inserte c: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "X+ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "X- :";
            // 
            // calculartbtn
            // 
            this.calculartbtn.Location = new System.Drawing.Point(73, 183);
            this.calculartbtn.Name = "calculartbtn";
            this.calculartbtn.Size = new System.Drawing.Size(75, 23);
            this.calculartbtn.TabIndex = 10;
            this.calculartbtn.Text = "Calcular";
            this.calculartbtn.UseVisualStyleBackColor = true;
            this.calculartbtn.Click += new System.EventHandler(this.calculartbtn_Click);
            // 
            // limpiarbtn
            // 
            this.limpiarbtn.Location = new System.Drawing.Point(188, 183);
            this.limpiarbtn.Name = "limpiarbtn";
            this.limpiarbtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarbtn.TabIndex = 11;
            this.limpiarbtn.Text = "Limpiar";
            this.limpiarbtn.UseVisualStyleBackColor = true;
            this.limpiarbtn.Click += new System.EventHandler(this.limpiarbtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 265);
            this.Controls.Add(this.limpiarbtn);
            this.Controls.Add(this.calculartbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.respuestan);
            this.Controls.Add(this.respuestap);
            this.Controls.Add(this.ctxt);
            this.Controls.Add(this.btxt);
            this.Controls.Add(this.atxt);
            this.Name = "Form3";
            this.Text = "Ecuaciones de segundo grado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox atxt;
        private TextBox btxt;
        private TextBox ctxt;
        private TextBox respuestap;
        private TextBox respuestan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button calculartbtn;
        private Button limpiarbtn;
    }
}