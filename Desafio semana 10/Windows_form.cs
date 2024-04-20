using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MiAplicacion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Add code that will execute when the form is loaded
            // For example, you can initialize some controls or load data
        }

        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            // Display an informational message when the user clicks the button
            MessageBox.Show("¡Hola! Has presionado el botón para mostrar un mensaje.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Confirm with the user before closing the application
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}