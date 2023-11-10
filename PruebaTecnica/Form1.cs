namespace PruebaTecnica
{
    public partial class Form1 : Form
    {

        String[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        int[] diasDelMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Form1()
        {
            InitializeComponent();
        }

        private void fechaCargar()
        {            
            panel.Controls.Clear();

            int diasEnElMes = diasDelMes[this.fechaInicio.Value.Month - 1];

            int cuadroWidth = 60;
            int cuadroHeight = 60;
            int espaciadoHorizontal = 5;
            int maxColumnas = panel.Width / (cuadroWidth + espaciadoHorizontal);
            
            List<DateTime> diasFestivos = new List<DateTime>
    {
        new DateTime(this.fechaInicio.Value.Year, 1, 1),   // 1 de enero
        new DateTime(this.fechaInicio.Value.Year, 2, 5),   // 5 de febrero
        new DateTime(this.fechaInicio.Value.Year, 3, 18),  // 18 de marzo
        new DateTime(this.fechaInicio.Value.Year, 5, 1),   // 1 de mayo
        new DateTime(this.fechaInicio.Value.Year, 9, 16),  // 16 de septiembre
        new DateTime(this.fechaInicio.Value.Year, 11, 20), // 20 de noviembre
        new DateTime(this.fechaInicio.Value.Year, 12, 25)  // 25 de diciembre
    };

            for (int i = 1; i <= diasEnElMes; i++)
            {
                Label label = new Label();
                label.Width = cuadroWidth;
                label.Height = cuadroHeight;

                DateTime fechaActual = new DateTime(this.fechaInicio.Value.Year, this.fechaInicio.Value.Month, i);
                
                if (diasFestivos.Contains(fechaActual.Date))
                {
                    label.BackColor = Color.Orange;
                }
                else if (fechaActual.DayOfWeek == DayOfWeek.Saturday || fechaActual.DayOfWeek == DayOfWeek.Sunday)
                {
                    label.BackColor = Color.Yellow;
                }
                else
                {
                    label.BackColor = Color.Green;
                }

                label.Text = i.ToString();

                int fila = (i - 1) / maxColumnas;
                int columna = (i - 1) % maxColumnas;

                int xPos = columna * (cuadroWidth + espaciadoHorizontal);
                int yPos = fila * (cuadroHeight + espaciadoHorizontal);

                label.Location = new Point(xPos, yPos);
                panel.Controls.Add(label);
            }

            this.encabezado.Text = $"{meses[this.fechaInicio.Value.Month - 1]} {diasEnElMes}";
        }

        private void fechaInicio_ValueChanged(object sender, EventArgs e)
        {
            fechaCargar();
        }


        private void dias_TextChanged(object sender, EventArgs e)
        {
            try
            {                
                panel.Controls.Clear();

                int diasEnElMes = diasDelMes[this.fechaInicio.Value.Month - 1];
                
                if (int.TryParse(dias.Text, out int diasPedidos) && diasPedidos > 0)
                {
                    int cuadroWidth = 60;
                    int cuadroHeight = 60;
                    int espaciadoHorizontal = 5;
                    int maxColumnas = panel.Width / (cuadroWidth + espaciadoHorizontal);
                    
                    List<DateTime> diasFestivos = new List<DateTime>
            {
                new DateTime(this.fechaInicio.Value.Year, 1, 1),   // 1 de enero
                new DateTime(this.fechaInicio.Value.Year, 2, 5),   // 5 de febrero
                new DateTime(this.fechaInicio.Value.Year, 3, 18),  // 18 de marzo
                new DateTime(this.fechaInicio.Value.Year, 5, 1),   // 1 de mayo
                new DateTime(this.fechaInicio.Value.Year, 9, 16),  // 16 de septiembre
                new DateTime(this.fechaInicio.Value.Year, 11, 20), // 20 de noviembre
                new DateTime(this.fechaInicio.Value.Year, 12, 25)  // 25 de diciembre
            };

                    DateTime fechaFinRango = this.fechaInicio.Value.AddDays(diasPedidos - 1);

                    for (int i = 1; i <= diasEnElMes; i++)
                    {
                        Label label = new Label();
                        label.Width = cuadroWidth;
                        label.Height = cuadroHeight;

                        DateTime fechaActual = new DateTime(this.fechaInicio.Value.Year, this.fechaInicio.Value.Month, i);
                        
                        if (diasPedidos > 0 && fechaActual >= this.fechaInicio.Value)
                        {
                            label.BackColor = Color.Blue;
                            diasPedidos--;
                        }
                        else if (fechaActual < this.fechaInicio.Value || fechaActual > fechaFinRango)
                        {                            
                            label.BackColor = Color.Gray;
                        }
                        else
                        {                            
                            if (diasFestivos.Contains(fechaActual.Date))
                            {
                                label.BackColor = Color.Orange;
                            }
                            else if (fechaActual.DayOfWeek == DayOfWeek.Saturday || fechaActual.DayOfWeek == DayOfWeek.Sunday)
                            {
                                label.BackColor = Color.Yellow;
                            }
                            else
                            {
                                label.BackColor = Color.Green;
                            }
                        }

                        label.Text = i.ToString();

                        int fila = (i - 1) / maxColumnas;
                        int columna = (i - 1) % maxColumnas;

                        int xPos = columna * (cuadroWidth + espaciadoHorizontal);
                        int yPos = fila * (cuadroHeight + espaciadoHorizontal);

                        label.Location = new Point(xPos, yPos);
                        panel.Controls.Add(label);
                    }

                    this.encabezado.Text = $"{meses[this.fechaInicio.Value.Month - 1]} {diasEnElMes}";
                } else
                {
                    fechaCargar();
                }
            }
            catch (Exception)
            {                
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            fechaCargar();
        }
    }
}