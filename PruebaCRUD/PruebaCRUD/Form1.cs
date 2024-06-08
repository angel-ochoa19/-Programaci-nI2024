using System.ComponentModel.Design;
using System.Data.SqlClient;

namespace PruebaCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_acep_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.nombre = textBox_nom.Text;
            persona.edad = Convert.ToInt32(textBox_edad.Text);
            persona.numero = textBox_Num.Text;

            if (dataGridView1.SelectedRows.Count == 1)
            {

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                if (id != null)
                {

                    persona.id = id;
                    int result = PersonaDal.Modificar(persona);
                    if (result > 0)
                    {
                        MessageBox.Show("Exito al Modificar");
                    }
                    else
                    {
                        MessageBox.Show("No se modifico");
                    }
                    
                }
            } else
            {
                int result = PersonaDal.AgregarPersona(persona);
                if (result > 0)
                {
                    MessageBox.Show("Exito al guardar");
                }
                else
                {
                    MessageBox.Show("No se guardo");
                }
                
            }
            Refresh();  
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            Refresh();
            Focus();
        }
        private void Refresh()
        {
            dataGridView1.DataSource = PersonaDal.PresentarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
               
                
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
               
                int resultado = PersonaDal.EliminarPersona(id);
                if (resultado > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                } else
                {
                    MessageBox.Show("No se ha podido eliminar");
                }
                Refresh();
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox_nom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            textBox_edad.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["edad"].Value);
            textBox_Num.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["numero"].Value);
            textBox_id.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);



        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            textBox_nom.Clear();
            textBox_id.Clear();
            textBox_Num.Clear();
            textBox_edad.Clear();
            dataGridView1.CurrentCell = null;
        }
    }


}
