namespace tarea5
{
    public partial class Form1 : Form
    {
        bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(maskedTextBox1.Text);

            if (EsPrimo(numero))
                MessageBox.Show("Es primo");
            else
                MessageBox.Show("No es primo");
        }
    }
}
