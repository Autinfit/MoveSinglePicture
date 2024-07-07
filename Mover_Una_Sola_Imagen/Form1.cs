namespace Mover_Una_Sola_Imagen
{
    public partial class Form1 : Form
    {
        bool izquierda, derecha, arriba, abajo;
        public Form1()
        {
            InitializeComponent();
        }

        private void EventoPresionarTeclas(object sender, KeyEventArgs e)
        {
            // EVENTO PARA PRESIONAR UNA TECLA DEL TECLADO MEDIANTE LA INTERFAZ...

            // PROCEDIMIENTO SENCILLO POR TECLAS...

            if (e.KeyCode == Keys.Left) // SI SE PRESIONA LA TECLA DE IZQUIERDA...
            {
                izquierda = true; // LA IMAGEN SE MUEVE HACIA LA IZQUIERDA.
            }

            if (e.KeyCode == Keys.Right) // SI SE PRESIONA LA TECLA DE DERECHA...
            {
                derecha = true; // LA IMAGEN SE MUEVE HACIA LA DERECHA.
            }

            if (e.KeyCode == Keys.Up) // SI SE PRESIONA LA TECLA DE ARRIBA...
            {
                arriba = true; // LA IMAGEN SE MUEVE HACIA ARRIBA.
            }

            if (e.KeyCode == Keys.Down) // SI SE PRESIONA LA TECLA DE ABAJO...
            {
                abajo = true; // LA IMAGEN SE MUEVE HACIA ABAJO.
            }
        }

        private void EventoSoltarTeclas(object sender, KeyEventArgs e)
        {
            // EVENTO PARA SOLTAR UNA TECLA DEL TECLADO MEDIANTE LA INTERFAZ...

            // EN INSTANTES...
        }

        private void EventoDiseñoFormulario(object sender, PaintEventArgs e)
        {
            // EVENTO PARA DISEÑAR LA INTERFAZ DEL PROYECTO MEDIANTE RECURSOS IMPORTADOS...

            // EN INSTANTES...
        }

        private void EventoTemporizador(object sender, EventArgs e)
        {
            // EVENTO EJECUTABLE MEDIANTE UN TEMPORIZADOR...

            // EN INSTANTES...
        }
    }
}