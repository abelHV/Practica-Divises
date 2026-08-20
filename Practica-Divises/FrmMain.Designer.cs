namespace Practica_Divises
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuIconaSysTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Canvi = new System.Windows.Forms.ToolStripMenuItem();
            this.Historial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icoSysTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbDivises1 = new System.Windows.Forms.ComboBox();
            this.cbDivises2 = new System.Windows.Forms.ComboBox();
            this.lbTitol = new System.Windows.Forms.Label();
            this.lbDivisa1 = new System.Windows.Forms.Label();
            this.lbDivisa2 = new System.Windows.Forms.Label();
            this.nupValor = new System.Windows.Forms.NumericUpDown();
            this.btMostrar = new System.Windows.Forms.Button();
            this.dtpDataInici = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.nupHistorialImport = new System.Windows.Forms.NumericUpDown();
            this.cbHistorialOrigen = new System.Windows.Forms.ComboBox();
            this.cbHistorialDesti = new System.Windows.Forms.ComboBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lbValor1 = new System.Windows.Forms.Label();
            this.lbValor2 = new System.Windows.Forms.Label();
            this.lbResultatDestiActual = new System.Windows.Forms.Label();
            this.lbResultatOrigenActual = new System.Windows.Forms.Label();
            this.btMostrarHistorial = new System.Windows.Forms.Button();
            this.mnuIconaSysTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHistorialImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuIconaSysTray
            // 
            this.mnuIconaSysTray.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuIconaSysTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Canvi,
            this.Historial,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.sortirToolStripMenuItem});
            this.mnuIconaSysTray.Name = "mnuIconaSysTray";
            this.mnuIconaSysTray.Size = new System.Drawing.Size(159, 88);
            // 
            // Canvi
            // 
            this.Canvi.Name = "Canvi";
            this.Canvi.Size = new System.Drawing.Size(158, 24);
            this.Canvi.Text = "Canvi actual";
            this.Canvi.Click += new System.EventHandler(this.Canvi_Click);
            // 
            // Historial
            // 
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(158, 24);
            this.Historial.Text = "Historial";
            this.Historial.Click += new System.EventHandler(this.Historial_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // icoSysTray
            // 
            this.icoSysTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.icoSysTray.BalloonTipText = "Divises";
            this.icoSysTray.BalloonTipTitle = "M3UF5";
            this.icoSysTray.ContextMenuStrip = this.mnuIconaSysTray;
            this.icoSysTray.Icon = ((System.Drawing.Icon)(resources.GetObject("icoSysTray.Icon")));
            this.icoSysTray.Text = "DIVISES";
            this.icoSysTray.Visible = true;
            // 
            // cbDivises1
            // 
            this.cbDivises1.FormattingEnabled = true;
            this.cbDivises1.Location = new System.Drawing.Point(58, 105);
            this.cbDivises1.Name = "cbDivises1";
            this.cbDivises1.Size = new System.Drawing.Size(300, 24);
            this.cbDivises1.TabIndex = 1;
            // 
            // cbDivises2
            // 
            this.cbDivises2.FormattingEnabled = true;
            this.cbDivises2.Location = new System.Drawing.Point(555, 105);
            this.cbDivises2.Name = "cbDivises2";
            this.cbDivises2.Size = new System.Drawing.Size(303, 24);
            this.cbDivises2.TabIndex = 2;
            // 
            // lbTitol
            // 
            this.lbTitol.AutoSize = true;
            this.lbTitol.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitol.Location = new System.Drawing.Point(398, 28);
            this.lbTitol.Name = "lbTitol";
            this.lbTitol.Size = new System.Drawing.Size(97, 40);
            this.lbTitol.TabIndex = 3;
            this.lbTitol.Text = "TITOL";
            this.lbTitol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDivisa1
            // 
            this.lbDivisa1.AutoSize = true;
            this.lbDivisa1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDivisa1.Location = new System.Drawing.Point(259, 73);
            this.lbDivisa1.Name = "lbDivisa1";
            this.lbDivisa1.Size = new System.Drawing.Size(88, 27);
            this.lbDivisa1.TabIndex = 4;
            this.lbDivisa1.Text = "ORIGEN";
            this.lbDivisa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDivisa2
            // 
            this.lbDivisa2.AutoSize = true;
            this.lbDivisa2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDivisa2.Location = new System.Drawing.Point(579, 73);
            this.lbDivisa2.Name = "lbDivisa2";
            this.lbDivisa2.Size = new System.Drawing.Size(69, 27);
            this.lbDivisa2.TabIndex = 6;
            this.lbDivisa2.Text = "DESTÍ";
            this.lbDivisa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nupValor
            // 
            this.nupValor.DecimalPlaces = 2;
            this.nupValor.Location = new System.Drawing.Point(422, 107);
            this.nupValor.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nupValor.Name = "nupValor";
            this.nupValor.Size = new System.Drawing.Size(71, 22);
            this.nupValor.TabIndex = 9;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(400, 354);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(95, 41);
            this.btMostrar.TabIndex = 10;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // dtpDataInici
            // 
            this.dtpDataInici.Location = new System.Drawing.Point(58, 28);
            this.dtpDataInici.Name = "dtpDataInici";
            this.dtpDataInici.Size = new System.Drawing.Size(200, 22);
            this.dtpDataInici.TabIndex = 11;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Location = new System.Drawing.Point(658, 28);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(200, 22);
            this.dtpDataFinal.TabIndex = 12;
            // 
            // nupHistorialImport
            // 
            this.nupHistorialImport.DecimalPlaces = 2;
            this.nupHistorialImport.Location = new System.Drawing.Point(422, 107);
            this.nupHistorialImport.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupHistorialImport.Name = "nupHistorialImport";
            this.nupHistorialImport.Size = new System.Drawing.Size(71, 22);
            this.nupHistorialImport.TabIndex = 13;
            // 
            // cbHistorialOrigen
            // 
            this.cbHistorialOrigen.BackColor = System.Drawing.SystemColors.Window;
            this.cbHistorialOrigen.FormattingEnabled = true;
            this.cbHistorialOrigen.Location = new System.Drawing.Point(58, 105);
            this.cbHistorialOrigen.Name = "cbHistorialOrigen";
            this.cbHistorialOrigen.Size = new System.Drawing.Size(300, 24);
            this.cbHistorialOrigen.TabIndex = 14;
            // 
            // cbHistorialDesti
            // 
            this.cbHistorialDesti.FormattingEnabled = true;
            this.cbHistorialDesti.Location = new System.Drawing.Point(555, 105);
            this.cbHistorialDesti.Name = "cbHistorialDesti";
            this.cbHistorialDesti.Size = new System.Drawing.Size(303, 24);
            this.cbHistorialDesti.TabIndex = 15;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(58, 163);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.Size = new System.Drawing.Size(800, 168);
            this.dgvHistorial.TabIndex = 16;
            // 
            // lbValor1
            // 
            this.lbValor1.AutoSize = true;
            this.lbValor1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor1.Location = new System.Drawing.Point(233, 195);
            this.lbValor1.Name = "lbValor1";
            this.lbValor1.Size = new System.Drawing.Size(0, 27);
            this.lbValor1.TabIndex = 7;
            this.lbValor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValor2
            // 
            this.lbValor2.AutoSize = true;
            this.lbValor2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor2.Location = new System.Drawing.Point(553, 195);
            this.lbValor2.Name = "lbValor2";
            this.lbValor2.Size = new System.Drawing.Size(0, 27);
            this.lbValor2.TabIndex = 8;
            this.lbValor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResultatDestiActual
            // 
            this.lbResultatDestiActual.AutoSize = true;
            this.lbResultatDestiActual.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultatDestiActual.Location = new System.Drawing.Point(579, 205);
            this.lbResultatDestiActual.Name = "lbResultatDestiActual";
            this.lbResultatDestiActual.Size = new System.Drawing.Size(0, 27);
            this.lbResultatDestiActual.TabIndex = 18;
            this.lbResultatDestiActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResultatOrigenActual
            // 
            this.lbResultatOrigenActual.AutoSize = true;
            this.lbResultatOrigenActual.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultatOrigenActual.Location = new System.Drawing.Point(259, 205);
            this.lbResultatOrigenActual.Name = "lbResultatOrigenActual";
            this.lbResultatOrigenActual.Size = new System.Drawing.Size(0, 27);
            this.lbResultatOrigenActual.TabIndex = 17;
            this.lbResultatOrigenActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMostrarHistorial
            // 
            this.btMostrarHistorial.Location = new System.Drawing.Point(400, 354);
            this.btMostrarHistorial.Name = "btMostrarHistorial";
            this.btMostrarHistorial.Size = new System.Drawing.Size(95, 41);
            this.btMostrarHistorial.TabIndex = 19;
            this.btMostrarHistorial.Text = "Mostrar";
            this.btMostrarHistorial.UseVisualStyleBackColor = true;
            this.btMostrarHistorial.Click += new System.EventHandler(this.btMostrarHistorial_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 426);
            this.Controls.Add(this.btMostrarHistorial);
            this.Controls.Add(this.lbResultatDestiActual);
            this.Controls.Add(this.lbResultatOrigenActual);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.cbHistorialDesti);
            this.Controls.Add(this.cbHistorialOrigen);
            this.Controls.Add(this.nupHistorialImport);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInici);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.nupValor);
            this.Controls.Add(this.lbValor2);
            this.Controls.Add(this.lbValor1);
            this.Controls.Add(this.lbDivisa2);
            this.Controls.Add(this.lbDivisa1);
            this.Controls.Add(this.lbTitol);
            this.Controls.Add(this.cbDivises2);
            this.Controls.Add(this.cbDivises1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuIconaSysTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHistorialImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mnuIconaSysTray;
        private System.Windows.Forms.ToolStripMenuItem Canvi;
        private System.Windows.Forms.ToolStripMenuItem Historial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon icoSysTray;
        private System.Windows.Forms.ComboBox cbDivises1;
        private System.Windows.Forms.ComboBox cbDivises2;
        private System.Windows.Forms.Label lbTitol;
        private System.Windows.Forms.Label lbDivisa1;
        private System.Windows.Forms.Label lbDivisa2;
        private System.Windows.Forms.NumericUpDown nupValor;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.DateTimePicker dtpDataInici;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.NumericUpDown nupHistorialImport;
        private System.Windows.Forms.ComboBox cbHistorialOrigen;
        private System.Windows.Forms.ComboBox cbHistorialDesti;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lbValor1;
        private System.Windows.Forms.Label lbValor2;
        private System.Windows.Forms.Label lbResultatDestiActual;
        private System.Windows.Forms.Label lbResultatOrigenActual;
        private System.Windows.Forms.Button btMostrarHistorial;
    }
}

