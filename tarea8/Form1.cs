namespace tarea8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oracion = textBox1.Text.Trim();

            if (oracion == "")
            {
                MessageBox.Show("Escriba una oración");
                return;
            }

            string[] palabras = oracion.Split(' ');

            int cantidad = palabras.Length;

            label1.Text = "Cantidad de palabras: " + cantidad;
        }
    }
}
