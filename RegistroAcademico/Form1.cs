using System.Data;

namespace RegistroAcademico
{
    public partial class Form1 : Form
    {
        private DatabaseManager dbManager;

        Dictionary<string, int> gradosDictionary = new Dictionary<string, int>();

        private AlumnosGrado form_alumnos;

        private int? gradoSeleccionado = null;


        public Form1(int? gradoPorDefecto = null)
        {
            InitializeComponent();

            gradoSeleccionado = gradoPorDefecto;

            dbManager = new DatabaseManager("localhost", "registro_academico", "root", "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Hide();
            listBox1.Items.Clear();

            string sql = "SELECT * FROM grados";

            DataTable grados = dbManager.ExecuteQuery(sql);

            foreach (DataRow row in grados.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string grado = row["grado"].ToString();

                listBox1.Items.Add(grado);
                gradosDictionary.Add(grado, id);
            }

            if (gradoSeleccionado.HasValue)
            {
                string gradoNombre = gradosDictionary.FirstOrDefault(x => x.Value == gradoSeleccionado.Value).Key;
                if (!string.IsNullOrEmpty(gradoNombre))
                {
                    listBox1.SelectedItem = gradoNombre;
                }
            }

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                panel3.Show();

                // Boton de ver grado
                button2.Show();

                // Boton de ver materia de grado
                button1.Hide();

                // Limpiar items
                listBox2.Items.Clear();

                string selectedGrado = listBox1.SelectedItem.ToString();

                int selectedGradoId = gradosDictionary[selectedGrado];

                label4.Text = selectedGrado;

                string sqlMaterias = $"SELECT materia FROM materias WHERE fk_grado = '{selectedGradoId}'";

                DataTable materias = dbManager.ExecuteQuery(sqlMaterias);

                foreach (DataRow row in materias.Rows)
                {
                    string materia = row["materia"].ToString();
                    listBox2.Items.Add(materia);
                }
            }
        }

        // Mostrar materias
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostrar boton de acceder grado
            button1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            string selectedGrado = listBox1.SelectedItem.ToString();

            int selectedGradoId = gradosDictionary[selectedGrado];

            // pasa el id del grado y el nombre del grado
            form_alumnos = new AlumnosGrado(selectedGradoId, selectedGrado);
            form_alumnos.Show();
        }
    }
}
