namespace tarea7
{
    public partial class Form1 : Form
    {
        bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int inicio = int.Parse(textBox1.Text);
            int fin = int.Parse(textBox2.Text);

            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
