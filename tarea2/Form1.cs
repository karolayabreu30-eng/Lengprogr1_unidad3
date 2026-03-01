namespace tarea2
{
    public partial class Form1 : Form
    {
        int tiempoTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (tiempoTotal > 0)
            {
                tiempoTotal--;

                int min = tiempoTotal / 60;
                int seg = tiempoTotal % 60;

                lblTiempo.Text = min.ToString("00") + ":" + seg.ToString("00");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡Tiempo agotado!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minutos;
            int segundos;

            if (!int.TryParse(textBox1.Text, out minutos) ||
                !int.TryParse(textBox2.Text, out segundos))
            {
                MessageBox.Show("Ingrese solo números válidos");
                return;
            }

            tiempoTotal = (minutos * 60) + segundos;

            timer1.Start();
        }
    }
}
