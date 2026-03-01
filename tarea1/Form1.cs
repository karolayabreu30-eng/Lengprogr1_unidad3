namespace TAREA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                listBox1.Items.Clear();

                int numero;

                if (int.TryParse(textBox1.Text, out numero))
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        listBox1.Items.Add(numero + " x " + i + " = " + (numero * i));
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
} 
