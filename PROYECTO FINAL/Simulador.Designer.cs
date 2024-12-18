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
            buttonDetener = new Button();
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
            dgvProcesos.Location = new Point(16, 28);
            dgvProcesos.Margin = new Padding(4);
            dgvProcesos.MultiSelect = false;
            dgvProcesos.Name = "dgvProcesos";
            dgvProcesos.ReadOnly = true;
            dgvProcesos.RowHeadersWidth = 51;
            dgvProcesos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvProcesos.Size = new Size(1289, 888);
            dgvProcesos.TabIndex = 0;
            dgvProcesos.UseWaitCursor = true;
            dgvProcesos.RowPrePaint += dgvProcesos_RowPrePaint;
            // 
            // ID
            // 
            ID.HeaderText = "Numero de Proceso";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 250;
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
            // buttonDetener
            // 
            buttonDetener.BackColor = SystemColors.ActiveCaption;
            buttonDetener.Font = new Font("Heebo", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDetener.Location = new Point(1362, 307);
            buttonDetener.Name = "buttonDetener";
            buttonDetener.Size = new Size(230, 34);
            buttonDetener.TabIndex = 1;
            buttonDetener.Text = "Terminar simulación";
            buttonDetener.UseVisualStyleBackColor = false;
            buttonDetener.Click += buttonDetener_Click;
            // 
            // Simulador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1641, 968);
            Controls.Add(buttonDetener);
            Controls.Add(dgvProcesos);
            Margin = new Padding(4);
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
        private Button buttonDetener;
    }
}