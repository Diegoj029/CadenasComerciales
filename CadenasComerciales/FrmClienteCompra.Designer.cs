namespace CadenasComerciales {
    partial class FrmClienteCompra {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.DtgArticulos = new System.Windows.Forms.DataGridView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCons = new System.Windows.Forms.Button();
            this.DtgPagos = new System.Windows.Forms.DataGridView();
            this.lblCompra = new System.Windows.Forms.Label();
            this.CboCompra = new System.Windows.Forms.ComboBox();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.lblEtiquetaFecha = new System.Windows.Forms.Label();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgArticulos
            // 
            this.DtgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgArticulos.Location = new System.Drawing.Point(239, 92);
            this.DtgArticulos.Name = "DtgArticulos";
            this.DtgArticulos.Size = new System.Drawing.Size(396, 164);
            this.DtgArticulos.TabIndex = 0;
            this.DtgArticulos.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 13);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(12, 29);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(144, 21);
            this.CboCliente.TabIndex = 3;
            this.CboCliente.SelectedIndexChanged += new System.EventHandler(this.CboCliente_SelectedIndexChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(236, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "YYYYmmDD";
            this.dtpFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFecha.Location = new System.Drawing.Point(239, 30);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // btnCons
            // 
            this.btnCons.Enabled = false;
            this.btnCons.Location = new System.Drawing.Point(514, 27);
            this.btnCons.Name = "btnCons";
            this.btnCons.Size = new System.Drawing.Size(105, 23);
            this.btnCons.TabIndex = 8;
            this.btnCons.Text = "Consultar";
            this.btnCons.UseVisualStyleBackColor = true;
            this.btnCons.Click += new System.EventHandler(this.btnCons_Click);
            // 
            // DtgPagos
            // 
            this.DtgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPagos.Location = new System.Drawing.Point(15, 274);
            this.DtgPagos.Name = "DtgPagos";
            this.DtgPagos.Size = new System.Drawing.Size(620, 164);
            this.DtgPagos.TabIndex = 9;
            this.DtgPagos.Visible = false;
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(15, 90);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(46, 13);
            this.lblCompra.TabIndex = 11;
            this.lblCompra.Text = "Compra:";
            this.lblCompra.Visible = false;
            // 
            // CboCompra
            // 
            this.CboCompra.FormattingEnabled = true;
            this.CboCompra.Location = new System.Drawing.Point(15, 106);
            this.CboCompra.Name = "CboCompra";
            this.CboCompra.Size = new System.Drawing.Size(144, 21);
            this.CboCompra.TabIndex = 10;
            this.CboCompra.Visible = false;
            this.CboCompra.SelectedIndexChanged += new System.EventHandler(this.CboCompra_SelectedIndexChanged);
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Location = new System.Drawing.Point(236, 76);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(50, 13);
            this.lblArticulos.TabIndex = 12;
            this.lblArticulos.Text = "Articulos:";
            this.lblArticulos.Visible = false;
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Location = new System.Drawing.Point(15, 258);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(40, 13);
            this.lblPagos.TabIndex = 13;
            this.lblPagos.Text = "Pagos:";
            this.lblPagos.Visible = false;
            // 
            // lblEtiquetaFecha
            // 
            this.lblEtiquetaFecha.AutoSize = true;
            this.lblEtiquetaFecha.Location = new System.Drawing.Point(15, 167);
            this.lblEtiquetaFecha.Name = "lblEtiquetaFecha";
            this.lblEtiquetaFecha.Size = new System.Drawing.Size(40, 13);
            this.lblEtiquetaFecha.TabIndex = 14;
            this.lblEtiquetaFecha.Text = "Fecha:";
            this.lblEtiquetaFecha.Visible = false;
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Location = new System.Drawing.Point(15, 190);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(0, 13);
            this.lblFechaCompra.TabIndex = 15;
            this.lblFechaCompra.Visible = false;
            // 
            // FrmClienteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.lblFechaCompra);
            this.Controls.Add(this.lblEtiquetaFecha);
            this.Controls.Add(this.lblPagos);
            this.Controls.Add(this.lblArticulos);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.CboCompra);
            this.Controls.Add(this.DtgPagos);
            this.Controls.Add(this.btnCons);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.CboCliente);
            this.Controls.Add(this.DtgArticulos);
            this.Name = "FrmClienteCompra";
            this.Text = "FrmCompraCliente";
            this.Load += new System.EventHandler(this.FrmClienteCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgArticulos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCons;
        private System.Windows.Forms.DataGridView DtgPagos;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.ComboBox CboCompra;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblEtiquetaFecha;
        private System.Windows.Forms.Label lblFechaCompra;
    }
}