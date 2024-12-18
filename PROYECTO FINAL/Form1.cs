namespace PROYECTO_FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Simulador obj = new Simulador();
            this.Hide();
            obj.ShowDialog();
            this.Close();
        }
    }
}
