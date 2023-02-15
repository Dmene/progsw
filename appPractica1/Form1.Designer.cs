
namespace appPractica1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtVrDocena = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFactuurar = new System.Windows.Forms.Button();
            this.grbAPagar = new System.Windows.Forms.GroupBox();
            this.lblTotAPag = new System.Windows.Forms.Label();
            this.lblVrIVA = new System.Windows.Forms.Label();
            this.lblDcto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grbAPagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(110, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vr. Docena :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(110, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad (nids) :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(110, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 11);
            this.label3.TabIndex = 2;
            this.label3.Text = "% IVA";
            // 
            // lblSubTot
            // 
            this.lblSubTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTot.Location = new System.Drawing.Point(40, 28);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(94, 20);
            this.lblSubTot.TabIndex = 3;
            this.lblSubTot.Text = "Subtotal:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(108, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(270, 31);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Piñata Las Orquideas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(236, 128);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 5;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(236, 89);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 6;
            // 
            // txtVrDocena
            // 
            this.txtVrDocena.Location = new System.Drawing.Point(236, 50);
            this.txtVrDocena.Name = "txtVrDocena";
            this.txtVrDocena.Size = new System.Drawing.Size(100, 20);
            this.txtVrDocena.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(118, 173);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnFactuurar
            // 
            this.btnFactuurar.Location = new System.Drawing.Point(261, 173);
            this.btnFactuurar.Name = "btnFactuurar";
            this.btnFactuurar.Size = new System.Drawing.Size(75, 23);
            this.btnFactuurar.TabIndex = 9;
            this.btnFactuurar.Text = "facturar";
            this.btnFactuurar.UseVisualStyleBackColor = true;
            // 
            // grbAPagar
            // 
            this.grbAPagar.Controls.Add(this.textBox4);
            this.grbAPagar.Controls.Add(this.textBox3);
            this.grbAPagar.Controls.Add(this.textBox2);
            this.grbAPagar.Controls.Add(this.textBox1);
            this.grbAPagar.Controls.Add(this.lblTotAPag);
            this.grbAPagar.Controls.Add(this.lblVrIVA);
            this.grbAPagar.Controls.Add(this.lblDcto);
            this.grbAPagar.Controls.Add(this.lblSubTot);
            this.grbAPagar.Location = new System.Drawing.Point(59, 215);
            this.grbAPagar.Name = "grbAPagar";
            this.grbAPagar.Size = new System.Drawing.Size(341, 167);
            this.grbAPagar.TabIndex = 10;
            this.grbAPagar.TabStop = false;
            this.grbAPagar.Text = "A Pagar";
            this.grbAPagar.Visible = false;
            // 
            // lblTotAPag
            // 
            this.lblTotAPag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotAPag.Location = new System.Drawing.Point(40, 132);
            this.lblTotAPag.Name = "lblTotAPag";
            this.lblTotAPag.Size = new System.Drawing.Size(94, 21);
            this.lblTotAPag.TabIndex = 11;
            this.lblTotAPag.Text = "total a pagar";
            // 
            // lblVrIVA
            // 
            this.lblVrIVA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVrIVA.Location = new System.Drawing.Point(40, 101);
            this.lblVrIVA.Name = "lblVrIVA";
            this.lblVrIVA.Size = new System.Drawing.Size(81, 13);
            this.lblVrIVA.TabIndex = 12;
            this.lblVrIVA.Text = "vr iva";
            // 
            // lblDcto
            // 
            this.lblDcto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcto.Location = new System.Drawing.Point(40, 66);
            this.lblDcto.Name = "lblDcto";
            this.lblDcto.Size = new System.Drawing.Size(94, 17);
            this.lblDcto.TabIndex = 13;
            this.lblDcto.Text = "Descuento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(177, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 405);
            this.ControlBox = false;
            this.Controls.Add(this.grbAPagar);
            this.Controls.Add(this.btnFactuurar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtVrDocena);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Practica  1";
            this.grbAPagar.ResumeLayout(false);
            this.grbAPagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubTot;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtVrDocena;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFactuurar;
        private System.Windows.Forms.GroupBox grbAPagar;
        private System.Windows.Forms.Label lblTotAPag;
        private System.Windows.Forms.Label lblVrIVA;
        private System.Windows.Forms.Label lblDcto;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

