﻿namespace ERPIntegra
{
    partial class frmIngresoValores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoValores));
            this.dgvdenominaciones = new System.Windows.Forms.DataGridView();
            this.denID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtMonto2 = new System.Windows.Forms.TextBox();
            this.lblMonto1 = new System.Windows.Forms.Label();
            this.txtMonto1 = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdenominaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdenominaciones
            // 
            this.dgvdenominaciones.AllowUserToAddRows = false;
            this.dgvdenominaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdenominaciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdenominaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdenominaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denID,
            this.denDescr,
            this.denValor,
            this.denTipo,
            this.Cantidad,
            this.Importe});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdenominaciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdenominaciones.Location = new System.Drawing.Point(19, 14);
            this.dgvdenominaciones.Name = "dgvdenominaciones";
            this.dgvdenominaciones.RowHeadersVisible = false;
            this.dgvdenominaciones.RowTemplate.Height = 28;
            this.dgvdenominaciones.Size = new System.Drawing.Size(396, 662);
            this.dgvdenominaciones.TabIndex = 44;
            this.dgvdenominaciones.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdenominaciones_CellValueChanged);
            this.dgvdenominaciones.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvdenominaciones_EditingControlShowing);
            // 
            // denID
            // 
            this.denID.DataPropertyName = "denId";
            this.denID.HeaderText = "ID";
            this.denID.Name = "denID";
            this.denID.Visible = false;
            // 
            // denDescr
            // 
            this.denDescr.DataPropertyName = "denDescr";
            this.denDescr.HeaderText = "Denominación";
            this.denDescr.Name = "denDescr";
            this.denDescr.ReadOnly = true;
            // 
            // denValor
            // 
            this.denValor.DataPropertyName = "denValor";
            this.denValor.HeaderText = "Valor";
            this.denValor.Name = "denValor";
            this.denValor.Visible = false;
            // 
            // denTipo
            // 
            this.denTipo.DataPropertyName = "denTipo";
            this.denTipo.HeaderText = "Tipo";
            this.denTipo.Name = "denTipo";
            this.denTipo.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad Ingresada";
            this.Cantidad.Name = "Cantidad";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(621, 574);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 51);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(621, 454);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 51);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(621, 116);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(189, 26);
            this.txtTotal.TabIndex = 41;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblTotal.Location = new System.Drawing.Point(464, 116);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(133, 20);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "Total ingresado";
            // 
            // txtMonto2
            // 
            this.txtMonto2.Enabled = false;
            this.txtMonto2.Location = new System.Drawing.Point(621, 72);
            this.txtMonto2.Name = "txtMonto2";
            this.txtMonto2.Size = new System.Drawing.Size(189, 26);
            this.txtMonto2.TabIndex = 39;
            // 
            // lblMonto1
            // 
            this.lblMonto1.AutoSize = true;
            this.lblMonto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblMonto1.Location = new System.Drawing.Point(466, 75);
            this.lblMonto1.Name = "lblMonto1";
            this.lblMonto1.Size = new System.Drawing.Size(111, 20);
            this.lblMonto1.TabIndex = 38;
            this.lblMonto1.Text = "Total billetes";
            // 
            // txtMonto1
            // 
            this.txtMonto1.Enabled = false;
            this.txtMonto1.Location = new System.Drawing.Point(621, 30);
            this.txtMonto1.Name = "txtMonto1";
            this.txtMonto1.Size = new System.Drawing.Size(189, 26);
            this.txtMonto1.TabIndex = 37;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblMonto.Location = new System.Drawing.Point(464, 33);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(127, 20);
            this.lblMonto.TabIndex = 36;
            this.lblMonto.Text = "Total monedas";
            // 
            // frmIngresoValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(830, 700);
            this.Controls.Add(this.dgvdenominaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtMonto2);
            this.Controls.Add(this.lblMonto1);
            this.Controls.Add(this.txtMonto1);
            this.Controls.Add(this.lblMonto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmIngresoValores";
            this.Text = "Ingreso de valores";
            this.Load += new System.EventHandler(this.frmIngresoValores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIngresoValores_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdenominaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdenominaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn denID;
        private System.Windows.Forms.DataGridViewTextBoxColumn denDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn denValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn denTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtMonto2;
        private System.Windows.Forms.Label lblMonto1;
        private System.Windows.Forms.TextBox txtMonto1;
        private System.Windows.Forms.Label lblMonto;
    }
}