namespace PruebaTecnica
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
            fechaInicio = new DateTimePicker();
            dias = new TextBox();
            label1 = new Label();
            encabezado = new Label();
            panel = new Panel();
            SuspendLayout();
            // 
            // fechaInicio
            // 
            fechaInicio.Location = new Point(232, 83);
            fechaInicio.Name = "fechaInicio";
            fechaInicio.Size = new Size(250, 27);
            fechaInicio.TabIndex = 0;
            fechaInicio.ValueChanged += fechaInicio_ValueChanged;
            // 
            // dias
            // 
            dias.Location = new Point(583, 81);
            dias.Name = "dias";
            dias.Size = new Size(123, 27);
            dias.TabIndex = 1;
            dias.TextChanged += dias_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(525, 88);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 3;
            label1.Text = "Dias:";
            // 
            // encabezado
            // 
            encabezado.AutoSize = true;
            encabezado.Location = new Point(444, 8);
            encabezado.Name = "encabezado";
            encabezado.Size = new Size(38, 20);
            encabezado.TabIndex = 4;
            encabezado.Text = "Dias";
            // 
            // panel
            // 
            panel.Location = new Point(119, 180);
            panel.Name = "panel";
            panel.Size = new Size(797, 412);
            panel.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 673);
            Controls.Add(panel);
            Controls.Add(encabezado);
            Controls.Add(label1);
            Controls.Add(dias);
            Controls.Add(fechaInicio);
            Name = "Form1";
            Text = "Form1";
            Shown += Form1_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker fechaInicio;
        private TextBox dias;
        private Label label1;
        private Label encabezado;
        private Panel panel;
    }
}