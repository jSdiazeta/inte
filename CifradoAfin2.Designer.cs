namespace CifradoAfin2
{
    partial class CifradoAfin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CifradoAfin2));
            this.dtgProceso = new System.Windows.Forms.DataGridView();
            this.txtCriptograma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDescifrar = new System.Windows.Forms.RadioButton();
            this.btnCifrar = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKDesplazamiento = new System.Windows.Forms.TextBox();
            this.txtADecimacion = new System.Windows.Forms.TextBox();
            this.txtMensajeClaro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cripto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Constante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equivalente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProceso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgProceso
            // 
            this.dtgProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mensaje,
            this.Equivalente,
            this.Factor,
            this.Constante,
            this.MOD,
            this.cripto});
            this.dtgProceso.Location = new System.Drawing.Point(81, 295);
            this.dtgProceso.Name = "dtgProceso";
            this.dtgProceso.Size = new System.Drawing.Size(769, 290);
            this.dtgProceso.TabIndex = 35;
            // 
            // txtCriptograma
            // 
            this.txtCriptograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriptograma.Location = new System.Drawing.Point(322, 223);
            this.txtCriptograma.Multiline = true;
            this.txtCriptograma.Name = "txtCriptograma";
            this.txtCriptograma.Size = new System.Drawing.Size(213, 31);
            this.txtCriptograma.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(94, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "Criptograma:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(713, 223);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 31);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.Lime;
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(599, 223);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(108, 31);
            this.btnEjecutar.TabIndex = 31;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjectuar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDescifrar);
            this.groupBox1.Controls.Add(this.btnCifrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(599, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 117);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.AutoSize = true;
            this.btnDescifrar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescifrar.Location = new System.Drawing.Point(59, 66);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(116, 30);
            this.btnDescifrar.TabIndex = 1;
            this.btnDescifrar.Text = "Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = true;
            this.btnDescifrar.Click += new System.EventHandler(this.btnDescifrar_Click);
            // 
            // btnCifrar
            // 
            this.btnCifrar.AutoSize = true;
            this.btnCifrar.Checked = true;
            this.btnCifrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCifrar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCifrar.Location = new System.Drawing.Point(59, 28);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(84, 30);
            this.btnCifrar.TabIndex = 0;
            this.btnCifrar.TabStop = true;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, -58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "METODO DE CIFRADO: AFIN";
            // 
            // txtKDesplazamiento
            // 
            this.txtKDesplazamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKDesplazamiento.Location = new System.Drawing.Point(322, 177);
            this.txtKDesplazamiento.Multiline = true;
            this.txtKDesplazamiento.Name = "txtKDesplazamiento";
            this.txtKDesplazamiento.Size = new System.Drawing.Size(213, 31);
            this.txtKDesplazamiento.TabIndex = 28;
            this.txtKDesplazamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK_KeyPress);
            // 
            // txtADecimacion
            // 
            this.txtADecimacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADecimacion.Location = new System.Drawing.Point(322, 135);
            this.txtADecimacion.Multiline = true;
            this.txtADecimacion.Name = "txtADecimacion";
            this.txtADecimacion.Size = new System.Drawing.Size(213, 31);
            this.txtADecimacion.TabIndex = 27;
            this.txtADecimacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtMensajeClaro
            // 
            this.txtMensajeClaro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeClaro.Location = new System.Drawing.Point(322, 93);
            this.txtMensajeClaro.Multiline = true;
            this.txtMensajeClaro.Name = "txtMensajeClaro";
            this.txtMensajeClaro.Size = new System.Drawing.Size(213, 31);
            this.txtMensajeClaro.TabIndex = 26;
            this.txtMensajeClaro.TextChanged += new System.EventHandler(this.txtClaro_changued);
            this.txtMensajeClaro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensajeClaro_Key);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(94, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Desplazamiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(96, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Factor decimacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(96, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Texto en claro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MidnightBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(291, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(399, 36);
            this.label6.TabIndex = 36;
            this.label6.Text = "METODO DE CIFRADO: AFIN";
            // 
            // cripto
            // 
            this.cripto.Frozen = true;
            this.cripto.HeaderText = "CRIPTOGRAMA";
            this.cripto.Name = "cripto";
            this.cripto.ReadOnly = true;
            this.cripto.Width = 130;
            // 
            // MOD
            // 
            this.MOD.Frozen = true;
            this.MOD.HeaderText = "MOD 27";
            this.MOD.Name = "MOD";
            this.MOD.ReadOnly = true;
            this.MOD.Width = 120;
            // 
            // Constante
            // 
            this.Constante.Frozen = true;
            this.Constante.HeaderText = "Constante Desplazamiento";
            this.Constante.Name = "Constante";
            this.Constante.ReadOnly = true;
            // 
            // Factor
            // 
            this.Factor.Frozen = true;
            this.Factor.HeaderText = "Factor Decimacion";
            this.Factor.Name = "Factor";
            this.Factor.ReadOnly = true;
            this.Factor.Width = 120;
            // 
            // Equivalente
            // 
            this.Equivalente.Frozen = true;
            this.Equivalente.HeaderText = "Equivalente Numerico";
            this.Equivalente.Name = "Equivalente";
            this.Equivalente.ReadOnly = true;
            this.Equivalente.Width = 120;
            // 
            // Mensaje
            // 
            this.Mensaje.Frozen = true;
            this.Mensaje.HeaderText = "Mensaje en claro";
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.ReadOnly = true;
            this.Mensaje.Width = 140;
            // 
            // CifradoAfin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CifradoAfin2.Properties.Resources.cifrado;
            this.ClientSize = new System.Drawing.Size(940, 616);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgProceso);
            this.Controls.Add(this.txtCriptograma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKDesplazamiento);
            this.Controls.Add(this.txtADecimacion);
            this.Controls.Add(this.txtMensajeClaro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CifradoAfin2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifrado Afin";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProceso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProceso;
        private System.Windows.Forms.TextBox txtCriptograma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnDescifrar;
        public System.Windows.Forms.RadioButton btnCifrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKDesplazamiento;
        private System.Windows.Forms.TextBox txtADecimacion;
        private System.Windows.Forms.TextBox txtMensajeClaro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equivalente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Constante;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cripto;
    }
}

