
namespace appPractica1
{
    partial class frmPedido
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
            this.lblSu = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtVrDocena = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.grbAPagar = new System.Windows.Forms.GroupBox();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.lblDscto = new System.Windows.Forms.Label();
            this.lblVrIVA = new System.Windows.Forms.Label();
            this.lblTotAPag = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.grbAPagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(52, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vr. Docena :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(50, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad (nids) :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(50, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 11);
            this.label3.TabIndex = 2;
            this.label3.Text = "% IVA";
            // 
            // lblSu
            // 
            this.lblSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSu.Location = new System.Drawing.Point(40, 28);
            this.lblSu.Name = "lblSu";
            this.lblSu.Size = new System.Drawing.Size(94, 20);
            this.lblSu.TabIndex = 3;
            this.lblSu.Text = "Subtotal:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(44, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(270, 31);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Piñata Las Orquideas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(165, 125);
            this.txtIVA.MaxLength = 5;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 5;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(165, 89);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 6;
            // 
            // txtVrDocena
            // 
            this.txtVrDocena.Location = new System.Drawing.Point(165, 53);
            this.txtVrDocena.Name = "txtVrDocena";
            this.txtVrDocena.Size = new System.Drawing.Size(100, 20);
            this.txtVrDocena.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Location = new System.Drawing.Point(71, 173);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFacturar.Location = new System.Drawing.Point(190, 173);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 23);
            this.btnFacturar.TabIndex = 9;
            this.btnFacturar.Text = "facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            // 
            // grbAPagar
            // 
            this.grbAPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grbAPagar.Controls.Add(this.lblTotAPag);
            this.grbAPagar.Controls.Add(this.lblVrIVA);
            this.grbAPagar.Controls.Add(this.lblDscto);
            this.grbAPagar.Controls.Add(this.lblSubTot);
            this.grbAPagar.Controls.Add(this.lblTot);
            this.grbAPagar.Controls.Add(this.lblV);
            this.grbAPagar.Controls.Add(this.lblD);
            this.grbAPagar.Controls.Add(this.lblSu);
            this.grbAPagar.Location = new System.Drawing.Point(12, 216);
            this.grbAPagar.Name = "grbAPagar";
            this.grbAPagar.Size = new System.Drawing.Size(302, 167);
            this.grbAPagar.TabIndex = 10;
            this.grbAPagar.TabStop = false;
            this.grbAPagar.Text = "A Pagar";
            this.grbAPagar.Visible = false;
            // 
            // lblTot
            // 
            this.lblTot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTot.Location = new System.Drawing.Point(39, 123);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(94, 21);
            this.lblTot.TabIndex = 11;
            this.lblTot.Text = "total a pagar";
            // 
            // lblV
            // 
            this.lblV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblV.Location = new System.Drawing.Point(40, 101);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(81, 13);
            this.lblV.TabIndex = 12;
            this.lblV.Text = "vr iva";
            // 
            // lblD
            // 
            this.lblD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblD.Location = new System.Drawing.Point(40, 66);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(94, 17);
            this.lblD.TabIndex = 13;
            this.lblD.Text = "Descuento";
            // 
            // lblSubTot
            // 
            this.lblSubTot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSubTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTot.Location = new System.Drawing.Point(163, 28);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(100, 23);
            this.lblSubTot.TabIndex = 18;
            // 
            // lblDscto
            // 
            this.lblDscto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDscto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDscto.Location = new System.Drawing.Point(163, 57);
            this.lblDscto.Name = "lblDscto";
            this.lblDscto.Size = new System.Drawing.Size(100, 26);
            this.lblDscto.TabIndex = 19;
            // 
            // lblVrIVA
            // 
            this.lblVrIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblVrIVA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVrIVA.Location = new System.Drawing.Point(163, 92);
            this.lblVrIVA.Name = "lblVrIVA";
            this.lblVrIVA.Size = new System.Drawing.Size(100, 22);
            this.lblVrIVA.TabIndex = 20;
            // 
            // lblTotAPag
            // 
            this.lblTotAPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTotAPag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotAPag.Location = new System.Drawing.Point(163, 123);
            this.lblTotAPag.Name = "lblTotAPag";
            this.lblTotAPag.Size = new System.Drawing.Size(100, 21);
            this.lblTotAPag.TabIndex = 21;
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTerminar.Location = new System.Drawing.Point(200, 389);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 11;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 444);
            this.ControlBox = false;
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.grbAPagar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtVrDocena);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPedido";
            this.Text = "Practica  1";
            this.grbAPagar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSu;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtVrDocena;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.GroupBox grbAPagar;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblTotAPag;
        private System.Windows.Forms.Label lblVrIVA;
        private System.Windows.Forms.Label lblDscto;
        private System.Windows.Forms.Label lblSubTot;
        private System.Windows.Forms.Button btnTerminar;
    }
}

