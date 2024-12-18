namespace PROYECTO_FINAL
{
    partial class Form2
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
            textBoxTotPro = new TextBox();
            textBoxProFin = new TextBox();
            textBoxProPendientes = new TextBox();
            textBoxPromMemoria = new TextBox();
            textBoxMaxMemoria = new TextBox();
            textBoxTurnaround = new TextBox();
            SuspendLayout();
            // 
            // textBoxTotPro
            // 
            textBoxTotPro.Enabled = false;
            textBoxTotPro.Location = new Point(129, 106);
            textBoxTotPro.Name = "textBoxTotPro";
            textBoxTotPro.Size = new Size(180, 27);
            textBoxTotPro.TabIndex = 6;
            textBoxTotPro.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxProFin
            // 
            textBoxProFin.Enabled = false;
            textBoxProFin.Location = new Point(310, 106);
            textBoxProFin.Name = "textBoxProFin";
            textBoxProFin.Size = new Size(180, 27);
            textBoxProFin.TabIndex = 7;
            textBoxProFin.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxProPendientes
            // 
            textBoxProPendientes.Enabled = false;
            textBoxProPendientes.Location = new Point(491, 106);
            textBoxProPendientes.Name = "textBoxProPendientes";
            textBoxProPendientes.Size = new Size(180, 27);
            textBoxProPendientes.TabIndex = 8;
            textBoxProPendientes.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPromMemoria
            // 
            textBoxPromMemoria.Enabled = false;
            textBoxPromMemoria.Location = new Point(129, 324);
            textBoxPromMemoria.Name = "textBoxPromMemoria";
            textBoxPromMemoria.Size = new Size(180, 27);
            textBoxPromMemoria.TabIndex = 9;
            textBoxPromMemoria.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxMaxMemoria
            // 
            textBoxMaxMemoria.Enabled = false;
            textBoxMaxMemoria.Location = new Point(310, 324);
            textBoxMaxMemoria.Name = "textBoxMaxMemoria";
            textBoxMaxMemoria.Size = new Size(180, 27);
            textBoxMaxMemoria.TabIndex = 10;
            textBoxMaxMemoria.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTurnaround
            // 
            textBoxTurnaround.Enabled = false;
            textBoxTurnaround.Location = new Point(491, 324);
            textBoxTurnaround.Name = "textBoxTurnaround";
            textBoxTurnaround.Size = new Size(180, 27);
            textBoxTurnaround.TabIndex = 11;
            textBoxTurnaround.TextAlign = HorizontalAlignment.Center;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.fondo_estadisticas;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 552);
            Controls.Add(textBoxTurnaround);
            Controls.Add(textBoxMaxMemoria);
            Controls.Add(textBoxPromMemoria);
            Controls.Add(textBoxProPendientes);
            Controls.Add(textBoxProFin);
            Controls.Add(textBoxTotPro);
            DoubleBuffered = true;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxTotPro;
        private TextBox textBoxProFin;
        private TextBox textBoxProPendientes;
        private TextBox textBoxPromMemoria;
        private TextBox textBoxMaxMemoria;
        private TextBox textBoxTurnaround;
    }
}