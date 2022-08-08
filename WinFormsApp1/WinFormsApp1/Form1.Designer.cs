namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pantalla = new System.Windows.Forms.TextBox();
            this.Dividir = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Restar = new System.Windows.Forms.Button();
            this.Sumar = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.Nueve = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.logaritmo = new System.Windows.Forms.Button();
            this.Tangente = new System.Windows.Forms.Button();
            this.coseno = new System.Windows.Forms.Button();
            this.Seno = new System.Windows.Forms.Button();
            this.tangentehiper = new System.Windows.Forms.Button();
            this.cosenohiper = new System.Windows.Forms.Button();
            this.senohiper = new System.Windows.Forms.Button();
            this.arcoseno = new System.Windows.Forms.Button();
            this.arcocoseno = new System.Windows.Forms.Button();
            this.Arcotangente = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.euler = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.integralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integralDiscretaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecuacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecuacionesDeSegundoGradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pantalla.Location = new System.Drawing.Point(12, 44);
            this.pantalla.MaxLength = 30;
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(663, 125);
            this.pantalla.TabIndex = 0;
            this.pantalla.TextChanged += new System.EventHandler(this.pantalla_TextChanged);
            // 
            // Dividir
            // 
            this.Dividir.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dividir.Location = new System.Drawing.Point(681, 120);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(107, 49);
            this.Dividir.TabIndex = 1;
            this.Dividir.Text = "÷";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // Multiplicar
            // 
            this.Multiplicar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Multiplicar.Location = new System.Drawing.Point(681, 175);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(107, 49);
            this.Multiplicar.TabIndex = 2;
            this.Multiplicar.Text = "x";
            this.Multiplicar.UseVisualStyleBackColor = true;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // Restar
            // 
            this.Restar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Restar.Location = new System.Drawing.Point(681, 230);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(107, 49);
            this.Restar.TabIndex = 3;
            this.Restar.Text = "-";
            this.Restar.UseVisualStyleBackColor = true;
            this.Restar.Click += new System.EventHandler(this.Restar_Click);
            // 
            // Sumar
            // 
            this.Sumar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sumar.Location = new System.Drawing.Point(681, 285);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(107, 49);
            this.Sumar.TabIndex = 4;
            this.Sumar.Text = "+";
            this.Sumar.UseVisualStyleBackColor = true;
            this.Sumar.Click += new System.EventHandler(this.Sumar_Click);
            // 
            // Igual
            // 
            this.Igual.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Igual.Location = new System.Drawing.Point(597, 340);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(191, 49);
            this.Igual.TabIndex = 5;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // tres
            // 
            this.tres.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tres.Location = new System.Drawing.Point(597, 285);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(78, 49);
            this.tres.TabIndex = 6;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // seis
            // 
            this.seis.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seis.Location = new System.Drawing.Point(597, 230);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(78, 49);
            this.seis.TabIndex = 7;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // Nueve
            // 
            this.Nueve.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nueve.Location = new System.Drawing.Point(597, 175);
            this.Nueve.Name = "Nueve";
            this.Nueve.Size = new System.Drawing.Size(78, 49);
            this.Nueve.TabIndex = 8;
            this.Nueve.Text = "9";
            this.Nueve.UseVisualStyleBackColor = true;
            this.Nueve.Click += new System.EventHandler(this.Nueve_Click);
            // 
            // dos
            // 
            this.dos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dos.Location = new System.Drawing.Point(513, 285);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(78, 49);
            this.dos.TabIndex = 9;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // cinco
            // 
            this.cinco.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinco.Location = new System.Drawing.Point(513, 230);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(78, 49);
            this.cinco.TabIndex = 10;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // ocho
            // 
            this.ocho.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ocho.Location = new System.Drawing.Point(513, 175);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(78, 49);
            this.ocho.TabIndex = 11;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // uno
            // 
            this.uno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uno.Location = new System.Drawing.Point(429, 285);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(78, 49);
            this.uno.TabIndex = 12;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // cuatro
            // 
            this.cuatro.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cuatro.Location = new System.Drawing.Point(429, 230);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(78, 49);
            this.cuatro.TabIndex = 13;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // siete
            // 
            this.siete.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siete.Location = new System.Drawing.Point(429, 175);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(78, 49);
            this.siete.TabIndex = 14;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = true;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // cero
            // 
            this.cero.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cero.Location = new System.Drawing.Point(429, 340);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(78, 49);
            this.cero.TabIndex = 15;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // punto
            // 
            this.punto.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.punto.Location = new System.Drawing.Point(513, 340);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(78, 49);
            this.punto.TabIndex = 16;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // logaritmo
            // 
            this.logaritmo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logaritmo.Location = new System.Drawing.Point(160, 340);
            this.logaritmo.Name = "logaritmo";
            this.logaritmo.Size = new System.Drawing.Size(246, 49);
            this.logaritmo.TabIndex = 17;
            this.logaritmo.Text = "Ln";
            this.logaritmo.UseVisualStyleBackColor = true;
            this.logaritmo.Click += new System.EventHandler(this.logaritmo_Click);
            // 
            // Tangente
            // 
            this.Tangente.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tangente.Location = new System.Drawing.Point(328, 285);
            this.Tangente.Name = "Tangente";
            this.Tangente.Size = new System.Drawing.Size(78, 49);
            this.Tangente.TabIndex = 18;
            this.Tangente.Text = "Tan";
            this.Tangente.UseVisualStyleBackColor = true;
            this.Tangente.Click += new System.EventHandler(this.Tangente_Click);
            // 
            // coseno
            // 
            this.coseno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coseno.Location = new System.Drawing.Point(328, 230);
            this.coseno.Name = "coseno";
            this.coseno.Size = new System.Drawing.Size(78, 49);
            this.coseno.TabIndex = 19;
            this.coseno.Text = "Cos";
            this.coseno.UseVisualStyleBackColor = true;
            this.coseno.Click += new System.EventHandler(this.button3_Click);
            // 
            // Seno
            // 
            this.Seno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Seno.Location = new System.Drawing.Point(328, 175);
            this.Seno.Name = "Seno";
            this.Seno.Size = new System.Drawing.Size(78, 49);
            this.Seno.TabIndex = 20;
            this.Seno.Text = "Sen";
            this.Seno.UseVisualStyleBackColor = true;
            this.Seno.Click += new System.EventHandler(this.Seno_Click);
            // 
            // tangentehiper
            // 
            this.tangentehiper.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tangentehiper.Location = new System.Drawing.Point(244, 285);
            this.tangentehiper.Name = "tangentehiper";
            this.tangentehiper.Size = new System.Drawing.Size(78, 49);
            this.tangentehiper.TabIndex = 22;
            this.tangentehiper.Text = "Htan";
            this.tangentehiper.UseVisualStyleBackColor = true;
            this.tangentehiper.Click += new System.EventHandler(this.tangentehiper_Click);
            // 
            // cosenohiper
            // 
            this.cosenohiper.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cosenohiper.Location = new System.Drawing.Point(244, 230);
            this.cosenohiper.Name = "cosenohiper";
            this.cosenohiper.Size = new System.Drawing.Size(78, 49);
            this.cosenohiper.TabIndex = 23;
            this.cosenohiper.Text = "Hcos";
            this.cosenohiper.UseVisualStyleBackColor = true;
            this.cosenohiper.Click += new System.EventHandler(this.cosenohiper_Click);
            // 
            // senohiper
            // 
            this.senohiper.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senohiper.Location = new System.Drawing.Point(244, 175);
            this.senohiper.Name = "senohiper";
            this.senohiper.Size = new System.Drawing.Size(78, 49);
            this.senohiper.TabIndex = 24;
            this.senohiper.Text = "Hsen";
            this.senohiper.UseVisualStyleBackColor = true;
            this.senohiper.Click += new System.EventHandler(this.senohiper_Click);
            // 
            // arcoseno
            // 
            this.arcoseno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arcoseno.Location = new System.Drawing.Point(160, 175);
            this.arcoseno.Name = "arcoseno";
            this.arcoseno.Size = new System.Drawing.Size(78, 49);
            this.arcoseno.TabIndex = 25;
            this.arcoseno.Text = "Asen";
            this.arcoseno.UseVisualStyleBackColor = true;
            this.arcoseno.Click += new System.EventHandler(this.arcoseno_Click);
            // 
            // arcocoseno
            // 
            this.arcocoseno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arcocoseno.Location = new System.Drawing.Point(160, 230);
            this.arcocoseno.Name = "arcocoseno";
            this.arcocoseno.Size = new System.Drawing.Size(78, 49);
            this.arcocoseno.TabIndex = 26;
            this.arcocoseno.Text = "Acos";
            this.arcocoseno.UseVisualStyleBackColor = true;
            this.arcocoseno.Click += new System.EventHandler(this.arcocoseno_Click);
            // 
            // Arcotangente
            // 
            this.Arcotangente.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Arcotangente.Location = new System.Drawing.Point(160, 285);
            this.Arcotangente.Name = "Arcotangente";
            this.Arcotangente.Size = new System.Drawing.Size(78, 49);
            this.Arcotangente.TabIndex = 27;
            this.Arcotangente.Text = "Atan";
            this.Arcotangente.UseVisualStyleBackColor = true;
            this.Arcotangente.Click += new System.EventHandler(this.Arcotangente_Click);
            // 
            // Raiz
            // 
            this.Raiz.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Raiz.Location = new System.Drawing.Point(12, 175);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(142, 49);
            this.Raiz.TabIndex = 29;
            this.Raiz.Text = "√ ";
            this.Raiz.UseVisualStyleBackColor = true;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // potencia
            // 
            this.potencia.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.potencia.Location = new System.Drawing.Point(12, 230);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(142, 49);
            this.potencia.TabIndex = 30;
            this.potencia.Text = "^";
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // euler
            // 
            this.euler.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.euler.Location = new System.Drawing.Point(12, 285);
            this.euler.Name = "euler";
            this.euler.Size = new System.Drawing.Size(142, 49);
            this.euler.TabIndex = 31;
            this.euler.Text = "E";
            this.euler.UseVisualStyleBackColor = true;
            this.euler.Click += new System.EventHandler(this.euler_Click);
            // 
            // pi
            // 
            this.pi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pi.Location = new System.Drawing.Point(12, 340);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(142, 49);
            this.pi.TabIndex = 32;
            this.pi.Text = "PI";
            this.pi.UseVisualStyleBackColor = true;
            this.pi.Click += new System.EventHandler(this.pi_Click);
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.limpiar.Location = new System.Drawing.Point(681, 65);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(107, 49);
            this.limpiar.TabIndex = 33;
            this.limpiar.Text = "AC";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integralesToolStripMenuItem,
            this.ecuacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // integralesToolStripMenuItem
            // 
            this.integralesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integralDiscretaToolStripMenuItem});
            this.integralesToolStripMenuItem.Name = "integralesToolStripMenuItem";
            this.integralesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.integralesToolStripMenuItem.Text = "Integrales";
            // 
            // integralDiscretaToolStripMenuItem
            // 
            this.integralDiscretaToolStripMenuItem.Name = "integralDiscretaToolStripMenuItem";
            this.integralDiscretaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.integralDiscretaToolStripMenuItem.Text = "Curva de agnesi";
            this.integralDiscretaToolStripMenuItem.Click += new System.EventHandler(this.integralDiscretaToolStripMenuItem_Click);
            // 
            // ecuacionesToolStripMenuItem
            // 
            this.ecuacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ecuacionesDeSegundoGradoToolStripMenuItem});
            this.ecuacionesToolStripMenuItem.Name = "ecuacionesToolStripMenuItem";
            this.ecuacionesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.ecuacionesToolStripMenuItem.Text = "Ecuaciones";
            // 
            // ecuacionesDeSegundoGradoToolStripMenuItem
            // 
            this.ecuacionesDeSegundoGradoToolStripMenuItem.Name = "ecuacionesDeSegundoGradoToolStripMenuItem";
            this.ecuacionesDeSegundoGradoToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.ecuacionesDeSegundoGradoToolStripMenuItem.Text = "Ecuaciones de Segundo Grado";
            this.ecuacionesDeSegundoGradoToolStripMenuItem.Click += new System.EventHandler(this.ecuacionesDeSegundoGradoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.euler);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.Arcotangente);
            this.Controls.Add(this.arcocoseno);
            this.Controls.Add(this.arcoseno);
            this.Controls.Add(this.senohiper);
            this.Controls.Add(this.cosenohiper);
            this.Controls.Add(this.tangentehiper);
            this.Controls.Add(this.Seno);
            this.Controls.Add(this.coseno);
            this.Controls.Add(this.Tangente);
            this.Controls.Add(this.logaritmo);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.Nueve);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Sumar);
            this.Controls.Add(this.Restar);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox pantalla;
        private Button Dividir;
        private Button Multiplicar;
        private Button Restar;
        private Button Sumar;
        private Button Igual;
        private Button tres;
        private Button seis;
        private Button Nueve;
        private Button dos;
        private Button cinco;
        private Button ocho;
        private Button uno;
        private Button cuatro;
        private Button siete;
        private Button cero;
        private Button punto;
        private Button logaritmo;
        private Button Tangente;
        private Button coseno;
        private Button Seno;
        private Button tangentehiper;
        private Button cosenohiper;
        private Button senohiper;
        private Button arcoseno;
        private Button arcocoseno;
        private Button Arcotangente;
        private Button Raiz;
        private Button potencia;
        private Button euler;
        private Button pi;
        private Button limpiar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem integralesToolStripMenuItem;
        private ToolStripMenuItem integralDiscretaToolStripMenuItem;
        private ToolStripMenuItem ecuacionesToolStripMenuItem;
        private ToolStripMenuItem ecuacionesDeSegundoGradoToolStripMenuItem;
    }
}