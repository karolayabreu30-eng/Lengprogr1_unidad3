namespace tarea4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = textBox1.Text.ToLower();
            string invertida = "";

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                invertida += palabra[i];
            }

            if (palabra == invertida)
                MessageBox.Show("Es palíndromo");
            else
                MessageBox.Show("No es palíndromo");
        }
    }
}
