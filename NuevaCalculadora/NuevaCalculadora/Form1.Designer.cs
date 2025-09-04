namespace NuevaCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.btnresta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnBA = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnpi = new System.Windows.Forms.Button();
            this.btnsen = new System.Windows.Forms.Button();
            this.btncos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnexp = new System.Windows.Forms.Button();
            this.btnMmas = new System.Windows.Forms.Button();
            this.btnMmenos = new System.Windows.Forms.Button();
            this.btnMc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Location = new System.Drawing.Point(188, 70);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.ReadOnly = true;
            this.Pantalla.Size = new System.Drawing.Size(330, 26);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pantalla.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnresta
            // 
            this.btnresta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnresta.Location = new System.Drawing.Point(98, 102);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(75, 74);
            this.btnresta.TabIndex = 1;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = false;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 74);
            this.button3.TabIndex = 4;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 74);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 430);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 74);
            this.button5.TabIndex = 5;
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(98, 350);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 74);
            this.button7.TabIndex = 9;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(98, 270);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 74);
            this.button8.TabIndex = 8;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(98, 190);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 74);
            this.button9.TabIndex = 7;
            this.button9.Text = "2";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsuma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsuma.Location = new System.Drawing.Point(17, 102);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 74);
            this.btnsuma.TabIndex = 6;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = false;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(178, 430);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 74);
            this.button11.TabIndex = 15;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(179, 350);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 74);
            this.button12.TabIndex = 14;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(179, 270);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 74);
            this.button13.TabIndex = 13;
            this.button13.Text = "6";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(179, 190);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 74);
            this.button14.TabIndex = 12;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnmultiplicacion.Location = new System.Drawing.Point(187, 102);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(75, 74);
            this.btnmultiplicacion.TabIndex = 11;
            this.btnmultiplicacion.Text = "*";
            this.btnmultiplicacion.UseVisualStyleBackColor = false;
            this.btnmultiplicacion.Click += new System.EventHandler(this.btnmultiplicacion_Click);
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(268, 350);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(75, 154);
            this.btnigual.TabIndex = 20;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.Info;
            this.btnlimpiar.Location = new System.Drawing.Point(362, 350);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 154);
            this.btnlimpiar.TabIndex = 18;
            this.btnlimpiar.Text = "CE";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnBA
            // 
            this.btnBA.BackColor = System.Drawing.SystemColors.Info;
            this.btnBA.Location = new System.Drawing.Point(443, 350);
            this.btnBA.Name = "btnBA";
            this.btnBA.Size = new System.Drawing.Size(75, 154);
            this.btnBA.TabIndex = 17;
            this.btnBA.Text = "BA";
            this.btnBA.UseVisualStyleBackColor = false;
            this.btnBA.Click += new System.EventHandler(this.btnBA_Click);
            // 
            // btndivision
            // 
            this.btndivision.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndivision.Location = new System.Drawing.Point(268, 102);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(75, 74);
            this.btndivision.TabIndex = 16;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = false;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click);
            // 
            // btnpi
            // 
            this.btnpi.Location = new System.Drawing.Point(362, 270);
            this.btnpi.Name = "btnpi";
            this.btnpi.Size = new System.Drawing.Size(75, 74);
            this.btnpi.TabIndex = 21;
            this.btnpi.Text = "π";
            this.btnpi.UseVisualStyleBackColor = true;
            this.btnpi.Click += new System.EventHandler(this.btnpi_Click);
            // 
            // btnsen
            // 
            this.btnsen.Location = new System.Drawing.Point(268, 270);
            this.btnsen.Name = "btnsen";
            this.btnsen.Size = new System.Drawing.Size(75, 74);
            this.btnsen.TabIndex = 22;
            this.btnsen.Text = "Sen";
            this.btnsen.UseVisualStyleBackColor = true;
            this.btnsen.Click += new System.EventHandler(this.btnsen_Click);
            // 
            // btncos
            // 
            this.btncos.Location = new System.Drawing.Point(268, 190);
            this.btncos.Name = "btncos";
            this.btncos.Size = new System.Drawing.Size(75, 74);
            this.btncos.TabIndex = 23;
            this.btncos.Text = "Cos";
            this.btncos.UseVisualStyleBackColor = true;
            this.btncos.Click += new System.EventHandler(this.btncos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(362, 190);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(75, 74);
            this.btnTan.TabIndex = 24;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btntan_Click);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(443, 102);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(75, 162);
            this.btnPow.TabIndex = 25;
            this.btnPow.Text = "xʸ";
            this.btnPow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(362, 102);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(75, 74);
            this.btnRaiz.TabIndex = 27;
            this.btnRaiz.Text = "raiz";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnexp
            // 
            this.btnexp.Location = new System.Drawing.Point(443, 270);
            this.btnexp.Name = "btnexp";
            this.btnexp.Size = new System.Drawing.Size(75, 74);
            this.btnexp.TabIndex = 28;
            this.btnexp.Text = "exp";
            this.btnexp.UseVisualStyleBackColor = true;
            this.btnexp.Click += new System.EventHandler(this.btnexp_Click);
            // 
            // btnMmas
            // 
            this.btnMmas.Location = new System.Drawing.Point(525, 102);
            this.btnMmas.Name = "btnMmas";
            this.btnMmas.Size = new System.Drawing.Size(75, 74);
            this.btnMmas.TabIndex = 29;
            this.btnMmas.Text = "M+";
            this.btnMmas.UseVisualStyleBackColor = true;
            this.btnMmas.Click += new System.EventHandler(this.btnMmas_Click);
            // 
            // btnMmenos
            // 
            this.btnMmenos.Location = new System.Drawing.Point(525, 190);
            this.btnMmenos.Name = "btnMmenos";
            this.btnMmenos.Size = new System.Drawing.Size(75, 74);
            this.btnMmenos.TabIndex = 30;
            this.btnMmenos.Text = "M-";
            this.btnMmenos.UseVisualStyleBackColor = true;
            this.btnMmenos.Click += new System.EventHandler(this.btnMmenos_Click);
            // 
            // btnMc
            // 
            this.btnMc.Location = new System.Drawing.Point(525, 271);
            this.btnMc.Name = "btnMc";
            this.btnMc.Size = new System.Drawing.Size(75, 73);
            this.btnMc.TabIndex = 31;
            this.btnMc.Text = "MC";
            this.btnMc.UseVisualStyleBackColor = true;
            this.btnMc.Click += new System.EventHandler(this.btnMc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 521);
            this.Controls.Add(this.btnMc);
            this.Controls.Add(this.btnMmenos);
            this.Controls.Add(this.btnMmas);
            this.Controls.Add(this.btnexp);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btncos);
            this.Controls.Add(this.btnsen);
            this.Controls.Add(this.btnpi);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnBA);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.Pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnBA;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnpi;
        private System.Windows.Forms.Button btnsen;
        private System.Windows.Forms.Button btncos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnexp;
        private System.Windows.Forms.Button btnMmas;
        private System.Windows.Forms.Button btnMmenos;
        private System.Windows.Forms.Button btnMc;
    }
}

