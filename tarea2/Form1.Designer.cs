namespace tarea2
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            lblTiempo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Minutos = new Label();
            Segundos = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(168, 223);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiempo.ForeColor = SystemColors.Highlight;
            lblTiempo.Location = new Point(197, 53);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(0, 31);
            lblTiempo.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Minutos
            // 
            Minutos.AutoSize = true;
            Minutos.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            Minutos.Location = new Point(104, 108);
            Minutos.Name = "Minutos";
            Minutos.Size = new Size(82, 25);
            Minutos.TabIndex = 4;
            Minutos.Text = "Minutos";
            // 
            // Segundos
            // 
            Segundos.AutoSize = true;
            Segundos.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            Segundos.Location = new Point(246, 108);
            Segundos.Name = "Segundos";
            Segundos.Size = new Size(95, 25);
            Segundos.TabIndex = 5;
            Segundos.Text = "Segundos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 332);
            Controls.Add(Segundos);
            Controls.Add(Minutos);
            Controls.Add(lblTiempo);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Temporizador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label lblTiempo;
        private System.Windows.Forms.Timer timer1;
        private Label Minutos;
        private Label Segundos;
    }
}
