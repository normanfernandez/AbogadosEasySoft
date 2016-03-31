namespace AbogadosEasySoft.Views
{
    partial class Frm_Compras
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCompradorId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCompradorSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtCompradorApellido = new System.Windows.Forms.TextBox();
            this.txtCompradorSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtCompradorNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVendedorId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVendedorSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtVendedorApellido = new System.Windows.Forms.TextBox();
            this.txtVendedorSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtVendedorNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCompraId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionCompleta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTipoMobilaria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(423, 349);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(261, 349);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCompradorId);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCompradorSegundoApellido);
            this.groupBox1.Controls.Add(this.txtCompradorApellido);
            this.groupBox1.Controls.Add(this.txtCompradorSegundoNombre);
            this.groupBox1.Controls.Add(this.txtCompradorNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 167);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Comprador";
            // 
            // txtCompradorId
            // 
            this.txtCompradorId.Location = new System.Drawing.Point(105, 29);
            this.txtCompradorId.Name = "txtCompradorId";
            this.txtCompradorId.Size = new System.Drawing.Size(100, 20);
            this.txtCompradorId.TabIndex = 9;
            this.txtCompradorId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompradorId_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "No. identificacón";
            // 
            // txtCompradorSegundoApellido
            // 
            this.txtCompradorSegundoApellido.Enabled = false;
            this.txtCompradorSegundoApellido.Location = new System.Drawing.Point(105, 141);
            this.txtCompradorSegundoApellido.Name = "txtCompradorSegundoApellido";
            this.txtCompradorSegundoApellido.Size = new System.Drawing.Size(100, 20);
            this.txtCompradorSegundoApellido.TabIndex = 7;
            // 
            // txtCompradorApellido
            // 
            this.txtCompradorApellido.Enabled = false;
            this.txtCompradorApellido.Location = new System.Drawing.Point(105, 115);
            this.txtCompradorApellido.Name = "txtCompradorApellido";
            this.txtCompradorApellido.Size = new System.Drawing.Size(100, 20);
            this.txtCompradorApellido.TabIndex = 6;
            // 
            // txtCompradorSegundoNombre
            // 
            this.txtCompradorSegundoNombre.Enabled = false;
            this.txtCompradorSegundoNombre.Location = new System.Drawing.Point(105, 89);
            this.txtCompradorSegundoNombre.Name = "txtCompradorSegundoNombre";
            this.txtCompradorSegundoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtCompradorSegundoNombre.TabIndex = 5;
            // 
            // txtCompradorNombre
            // 
            this.txtCompradorNombre.Enabled = false;
            this.txtCompradorNombre.Location = new System.Drawing.Point(105, 63);
            this.txtCompradorNombre.Name = "txtCompradorNombre";
            this.txtCompradorNombre.Size = new System.Drawing.Size(100, 20);
            this.txtCompradorNombre.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Segundo Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Primer Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVendedorId);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtVendedorSegundoApellido);
            this.groupBox2.Controls.Add(this.txtVendedorApellido);
            this.groupBox2.Controls.Add(this.txtVendedorSegundoNombre);
            this.groupBox2.Controls.Add(this.txtVendedorNombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(284, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 167);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Vendedor";
            // 
            // txtVendedorId
            // 
            this.txtVendedorId.Location = new System.Drawing.Point(102, 29);
            this.txtVendedorId.Name = "txtVendedorId";
            this.txtVendedorId.Size = new System.Drawing.Size(100, 20);
            this.txtVendedorId.TabIndex = 10;
            this.txtVendedorId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendedorId_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "No. identificacón";
            // 
            // txtVendedorSegundoApellido
            // 
            this.txtVendedorSegundoApellido.Enabled = false;
            this.txtVendedorSegundoApellido.Location = new System.Drawing.Point(102, 137);
            this.txtVendedorSegundoApellido.Name = "txtVendedorSegundoApellido";
            this.txtVendedorSegundoApellido.Size = new System.Drawing.Size(100, 20);
            this.txtVendedorSegundoApellido.TabIndex = 7;
            // 
            // txtVendedorApellido
            // 
            this.txtVendedorApellido.Enabled = false;
            this.txtVendedorApellido.Location = new System.Drawing.Point(102, 111);
            this.txtVendedorApellido.Name = "txtVendedorApellido";
            this.txtVendedorApellido.Size = new System.Drawing.Size(100, 20);
            this.txtVendedorApellido.TabIndex = 6;
            // 
            // txtVendedorSegundoNombre
            // 
            this.txtVendedorSegundoNombre.Enabled = false;
            this.txtVendedorSegundoNombre.Location = new System.Drawing.Point(102, 85);
            this.txtVendedorSegundoNombre.Name = "txtVendedorSegundoNombre";
            this.txtVendedorSegundoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtVendedorSegundoNombre.TabIndex = 5;
            // 
            // txtVendedorNombre
            // 
            this.txtVendedorNombre.Enabled = false;
            this.txtVendedorNombre.Location = new System.Drawing.Point(102, 59);
            this.txtVendedorNombre.Name = "txtVendedorNombre";
            this.txtVendedorNombre.Size = new System.Drawing.Size(100, 20);
            this.txtVendedorNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Segundo Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Segundo Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Primer Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCompraId);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(15, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 41);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda Compra";
            // 
            // txtCompraId
            // 
            this.txtCompraId.Location = new System.Drawing.Point(78, 13);
            this.txtCompraId.Name = "txtCompraId";
            this.txtCompraId.Size = new System.Drawing.Size(116, 20);
            this.txtCompraId.TabIndex = 1;
            this.txtCompraId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompraId_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "No. Compra";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(129, 120);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ciudad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDescripcionCompleta);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtTipoMobilaria);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(261, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 105);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Compra";
            // 
            // txtDescripcionCompleta
            // 
            this.txtDescripcionCompleta.Location = new System.Drawing.Point(125, 41);
            this.txtDescripcionCompleta.MaxLength = 50;
            this.txtDescripcionCompleta.Multiline = true;
            this.txtDescripcionCompleta.Name = "txtDescripcionCompleta";
            this.txtDescripcionCompleta.Size = new System.Drawing.Size(154, 58);
            this.txtDescripcionCompleta.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Descripción Completa";
            // 
            // txtTipoMobilaria
            // 
            this.txtTipoMobilaria.Location = new System.Drawing.Point(125, 16);
            this.txtTipoMobilaria.MaxLength = 10;
            this.txtTipoMobilaria.Name = "txtTipoMobilaria";
            this.txtTipoMobilaria.Size = new System.Drawing.Size(116, 20);
            this.txtTipoMobilaria.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tipo Mobilaria";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPrecio);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(584, 53);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 36);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Precio de Ventas";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(88, 13);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(116, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Precio Compra";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(363, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "COMPRAS";
            // 
            // Frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 384);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Frm_Compras";
            this.Text = "Frm_Compras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCompradorSegundoApellido;
        private System.Windows.Forms.TextBox txtCompradorApellido;
        private System.Windows.Forms.TextBox txtCompradorSegundoNombre;
        private System.Windows.Forms.TextBox txtCompradorNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVendedorSegundoApellido;
        private System.Windows.Forms.TextBox txtVendedorApellido;
        private System.Windows.Forms.TextBox txtVendedorSegundoNombre;
        private System.Windows.Forms.TextBox txtVendedorNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCompraId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDescripcionCompleta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTipoMobilaria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCompradorId;
        private System.Windows.Forms.TextBox txtVendedorId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
    }
}