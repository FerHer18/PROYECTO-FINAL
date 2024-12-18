namespace PROYECTO_FINAL
{
    partial class Simulador
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
            dgvProcesos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TiempoLlegada = new DataGridViewTextBoxColumn();
            TiempoEjecucion = new DataGridViewTextBoxColumn();
            TiempoRestante = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProcesos).BeginInit();
            SuspendLayout();
            // 
            // dgvProcesos
            // 
            dgvProcesos.AllowUserToAddRows = false;
            dgvProcesos.AllowUserToDeleteRows = false;
            dgvProcesos.AllowUserToResizeColumns = false;
            dgvProcesos.AllowUserToResizeRows = false;
            dgvProcesos.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvProcesos.ColumnHeadersHeight = 29;
            dgvProcesos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProcesos.Columns.AddRange(new DataGridViewColumn[] { ID, TiempoLlegada, TiempoEjecucion, TiempoRestante, Estado });
            dgvProcesos.Enabled = false;
            dgvProcesos.GridColor = SystemColors.ActiveCaptionText;
            dgvProcesos.Location = new Point(13, 22);
            dgvProcesos.MultiSelect = false;
            dgvProcesos.Name = "dgvProcesos";
            dgvProcesos.ReadOnly = true;
            dgvProcesos.RowHeadersWidth = 51;
            dgvProcesos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvProcesos.Size = new Size(889, 710);
            dgvProcesos.TabIndex = 0;
            dgvProcesos.UseWaitCursor = true;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 53;
            // 
            // TiempoLlegada
            // 
            TiempoLlegada.HeaderText = "Tiempo Llegada";
            TiempoLlegada.MinimumWidth = 6;
            TiempoLlegada.Name = "TiempoLlegada";
            TiempoLlegada.ReadOnly = true;
            TiempoLlegada.Width = 200;
            // 
            // TiempoEjecucion
            // 
            TiempoEjecucion.HeaderText = "Tiempo Ejecución";
            TiempoEjecucion.MinimumWidth = 6;
            TiempoEjecucion.Name = "TiempoEjecucion";
            TiempoEjecucion.ReadOnly = true;
            TiempoEjecucion.Width = 200;
            // 
            // TiempoRestante
            // 
            TiempoRestante.HeaderText = "Tiempo Restante";
            TiempoRestante.MinimumWidth = 6;
            TiempoRestante.Name = "TiempoRestante";
            TiempoRestante.ReadOnly = true;
            TiempoRestante.Width = 200;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 83;
            // 
            // Simulador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1313, 774);
            Controls.Add(dgvProcesos);
            Name = "Simulador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simulador";
            Load += Simulador_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProcesos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProcesos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TiempoLlegada;
        private DataGridViewTextBoxColumn TiempoEjecucion;
        private DataGridViewTextBoxColumn TiempoRestante;
        private DataGridViewTextBoxColumn Estado;
    }
}