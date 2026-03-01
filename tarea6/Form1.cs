namespace tarea6
{
    public partial class Form1 : Form
    {
        bool EsPerfecto(int numero)
        {
            int suma = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }

            return suma == numero;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(maskedTextBox1.Text);

            if (EsPerfecto(numero))
                MessageBox.Show("Es un número perfecto");
            else
                MessageBox.Show("No es un número perfecto");
        }
    }
}
