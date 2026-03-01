namespace tarea5
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
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(136, 54);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // button1
            // 
            button1.Location = new Point(167, 173);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Verificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 309);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Button button1;
    }
}
