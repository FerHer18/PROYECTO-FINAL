namespace PROYECTO_FINAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Transparent;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Location = new Point(1033, 634);
            btnIniciar.Margin = new Padding(2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(241, 104);
            btnIniciar.TabIndex = 34;
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.fondo_portada2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1313, 774);
            Controls.Add(btnIniciar);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
    }
}
