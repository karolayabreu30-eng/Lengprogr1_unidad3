namespace tarea3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Metros");
            comboBox1.Items.Add("Centímetros");
            comboBox1.Items.Add("Pulgadas");

            comboBox2.Items.Add("Metros");
            comboBox2.Items.Add("Centímetros");
            comboBox2.Items.Add("Pulgadas");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox1.Text);
            double resultado = 0;

            if (comboBox1.Text == "Metros" && comboBox2.Text == "Centímetros")
                resultado = valor * 100;

            else if (comboBox1.Text == "Centímetros" && comboBox2.Text == "Metros")
                resultado = valor / 100;

            else if (comboBox1.Text == "Metros" && comboBox2.Text == "Pulgadas")
                resultado = valor * 39.37;

            else if (comboBox1.Text == "Pulgadas" && comboBox2.Text == "Metros")
                resultado = valor / 39.37;

            else
                resultado = valor;

            label1.Text = "Resultado:     " + resultado;
        }
    }
}
