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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pnlMemoria = new Panel();
            label1 = new Label();
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
            dgvProcesos.Location = new Point(12, 12);
            dgvProcesos.MultiSelect = false;
            dgvProcesos.Name = "dgvProcesos";
            dgvProcesos.ReadOnly = true;
            dgvProcesos.RowHeadersWidth = 51;
            dgvProcesos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvProcesos.Size = new Size(1031, 710);
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
            buttonDetener.BackColor = Color.Red;
            buttonDetener.FlatStyle = FlatStyle.Flat;
            buttonDetener.Font = new Font("Heebo", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDetener.Location = new Point(882, 762);
            buttonDetener.Margin = new Padding(2);
            buttonDetener.Name = "buttonDetener";
            buttonDetener.Size = new Size(161, 90);
            buttonDetener.TabIndex = 1;
            buttonDetener.Text = "TERMINAR SIMULACION";
            buttonDetener.UseVisualStyleBackColor = false;
            buttonDetener.Click += buttonDetener_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Heebo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(22, 762);
            button1.Name = "button1";
            button1.Size = new Size(161, 90);
            button1.TabIndex = 2;
            button1.Text = "LENTO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Heebo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(237, 762);
            button2.Name = "button2";
            button2.Size = new Size(161, 90);
            button2.TabIndex = 3;
            button2.Text = "MEDIO RÁPIDO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Heebo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(452, 762);
            button3.Name = "button3";
            button3.Size = new Size(161, 90);
            button3.TabIndex = 4;
            button3.Text = "RÁPIDO";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkTurquoise;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Heebo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(663, 762);
            button4.Name = "button4";
            button4.Size = new Size(161, 90);
            button4.TabIndex = 5;
            button4.Text = "START";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pnlMemoria
            // 
            pnlMemoria.AutoScroll = true;
            pnlMemoria.Location = new Point(1057, 63);
            pnlMemoria.Name = "pnlMemoria";
            pnlMemoria.Size = new Size(225, 789);
            pnlMemoria.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1077, 25);
            label1.Name = "label1";
            label1.Size = new Size(205, 23);
            label1.TabIndex = 7;
            label1.Text = "ESTADO DE LA MEMORIA";
            // 
            // Simulador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1313, 883);
            Controls.Add(label1);
            Controls.Add(pnlMemoria);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonDetener);
            Controls.Add(dgvProcesos);
            Name = "Simulador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simulador";
            Load += Simulador_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProcesos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProcesos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TiempoLlegada;
        private DataGridViewTextBoxColumn TiempoEjecucion;
        private DataGridViewTextBoxColumn TiempoRestante;
        private DataGridViewTextBoxColumn Estado;
        private Button buttonDetener;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel pnlMemoria;
        private Label label1;
    }
}