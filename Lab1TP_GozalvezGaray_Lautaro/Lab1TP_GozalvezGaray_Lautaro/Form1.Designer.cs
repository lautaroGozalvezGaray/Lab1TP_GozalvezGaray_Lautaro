﻿
namespace Lab1TP_GozalvezGaray_Lautaro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboVehiculo = new System.Windows.Forms.ComboBox();
            this.lstCochera = new System.Windows.Forms.ListBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEgresar = new System.Windows.Forms.Button();
            this.txtBuscarDominio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDominio);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.lstCochera);
            this.groupBox1.Controls.Add(this.cboVehiculo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 518);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dominio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cochera";
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.Location = new System.Drawing.Point(186, 116);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(150, 28);
            this.cboVehiculo.TabIndex = 4;
            // 
            // lstCochera
            // 
            this.lstCochera.FormattingEnabled = true;
            this.lstCochera.ItemHeight = 20;
            this.lstCochera.Location = new System.Drawing.Point(186, 178);
            this.lstCochera.Name = "lstCochera";
            this.lstCochera.Size = new System.Drawing.Size(150, 264);
            this.lstCochera.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIngresar.Location = new System.Drawing.Point(390, 56);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(117, 72);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "&Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(186, 49);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(150, 26);
            this.txtDominio.TabIndex = 7;
            this.txtDominio.TextChanged += new System.EventHandler(this.txtDominio_TextChanged);
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscarDominio);
            this.groupBox2.Controls.Add(this.btnEgresar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.lblImporte);
            this.groupBox2.Controls.Add(this.lblEgreso);
            this.groupBox2.Controls.Add(this.lblIngreso);
            this.groupBox2.Controls.Add(this.lblUbicacion);
            this.groupBox2.Controls.Add(this.lblTipoVehiculo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(613, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 518);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EGRESO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dominio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Vehiculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ubicacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ingreso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Egreso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Importe";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.BackColor = System.Drawing.Color.White;
            this.lblTipoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(193, 116);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(134, 25);
            this.lblTipoVehiculo.TabIndex = 14;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.BackColor = System.Drawing.Color.White;
            this.lblUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUbicacion.Location = new System.Drawing.Point(193, 178);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(134, 25);
            this.lblUbicacion.TabIndex = 15;
            // 
            // lblIngreso
            // 
            this.lblIngreso.BackColor = System.Drawing.Color.White;
            this.lblIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIngreso.Location = new System.Drawing.Point(193, 226);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(181, 25);
            this.lblIngreso.TabIndex = 16;
            // 
            // lblEgreso
            // 
            this.lblEgreso.BackColor = System.Drawing.Color.White;
            this.lblEgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEgreso.Location = new System.Drawing.Point(193, 274);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(181, 25);
            this.lblEgreso.TabIndex = 17;
            // 
            // lblImporte
            // 
            this.lblImporte.BackColor = System.Drawing.Color.White;
            this.lblImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImporte.ForeColor = System.Drawing.Color.Red;
            this.lblImporte.Location = new System.Drawing.Point(193, 328);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(181, 63);
            this.lblImporte.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(346, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 53);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEgresar
            // 
            this.btnEgresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEgresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEgresar.Location = new System.Drawing.Point(217, 416);
            this.btnEgresar.Name = "btnEgresar";
            this.btnEgresar.Size = new System.Drawing.Size(125, 72);
            this.btnEgresar.TabIndex = 20;
            this.btnEgresar.Text = "&Egresar";
            this.btnEgresar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarDominio
            // 
            this.txtBuscarDominio.Location = new System.Drawing.Point(190, 56);
            this.txtBuscarDominio.Name = "txtBuscarDominio";
            this.txtBuscarDominio.Size = new System.Drawing.Size(137, 26);
            this.txtBuscarDominio.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamiento Central";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox lstCochera;
        private System.Windows.Forms.ComboBox cboVehiculo;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEgresar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarDominio;
    }
}

