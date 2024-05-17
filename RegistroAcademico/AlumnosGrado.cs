using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace RegistroAcademico
{
    public partial class AlumnosGrado : Form
    {
        private Form1 formulario_principal;

        private DatabaseManager dbManager;

        private Dictionary<string, int> materiasDiccionario = new Dictionary<string, int>();

        private Dictionary<string, double> cambiosNotas = new Dictionary<string, double>();

        private bool esCambioInterno = false;

        private int gradoSelected = 0;

        public AlumnosGrado(int grado, string nombreGrado)
        {
            InitializeComponent();

            gradoSelected = grado;

            // Mostrar que grado es
            label2.Text = nombreGrado;

            dbManager = new DatabaseManager("localhost", "registro_academico", "root", "");

            string sqlMaterias = $"SELECT materias.* FROM materias WHERE fk_grado = '{grado}'";
            DataTable materias = dbManager.ExecuteQuery(sqlMaterias);

            string sqlAlumnos = @"
                SELECT alumnos.id as AlumnoID,
                        CONCAT_WS(' ', alumnos.nombre1, alumnos.nombre2) AS nombres,
                        CONCAT_WS(' ', alumnos.apellido1, alumnos.apellido2) AS apellidos
                FROM alumnos
                WHERE alumnos.fk_grado = @grado; 
            ";
            
            var parameters = new Dictionary<string, object>
            {
                { "@grado", grado }
            };

            DataTable listaAlumnos = dbManager.ExecuteQuery(sqlAlumnos, parameters);

            // Crear tabla
            DataTable dt = new DataTable();

            dt.Columns.Add("Id alumno");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");

            foreach (DataRow row in materias.Rows)
            {
                int materiaId = Convert.ToInt32(row["id"]);
                string materiaNombre = row["materia"].ToString();

                dt.Columns.Add(materiaNombre);
                materiasDiccionario.Add(materiaNombre, materiaId);
            }

            dt.Columns.Add("Promedio");
            foreach (DataRow alumno in listaAlumnos.Rows)
            {
                string AlumnoId = alumno["AlumnoID"].ToString();

                DataRow row = dt.NewRow();
                row["Id alumno"] = alumno["AlumnoID"];
                row["Nombres"] = alumno["nombres"];
                row["Apellidos"] = alumno["apellidos"];

                List<double> notas = new List<double>();

                foreach (DataRow rowMateria in materias.Rows)
                {
                    int materiaId = Convert.ToInt32(rowMateria["id"]);
                    string materiaNombre = rowMateria["materia"].ToString();

                    string notaSql = $"SELECT notas.* FROM notas WHERE notas.fk_materia = {materiaId} and notas.fk_alumno = '{AlumnoId}'";
                    DataTable notaObtenida = dbManager.ExecuteQuery(notaSql);

                    double NotaObtenida = 0;

                    if (notaObtenida.Rows.Count > 0)
                    {
                        NotaObtenida = Math.Round(Convert.ToDouble(notaObtenida.Rows[0]["nota"]), 2);
                    }

                    row[materiaNombre] = NotaObtenida;

                    notas.Add(NotaObtenida);
                }

                double promedio = Math.Round(notas.Average(), 2);
                row["Promedio"] = promedio;

                dt.Rows.Add(row);

                // Actualizar el DataGridView después de agregar una fila
                dataGridView1.Refresh();

                // Calcular el promedio de la fila agregada
                if (dataGridView1.Rows.Count > 0)
                {
                    RecalcularPromedio(dataGridView1.Rows[dataGridView1.Rows.Count - 1]);
                }
            }

            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView1.DataSource = dt;
        }

        private void RecalcularPromedio(DataGridViewRow row)
        {
            double sumaNotas = 0;
            int contadorNotas = 0;

            // Recorre todas las celdas que contienen notas (a partir de la tercera columna)
            for (int i = 3; i < row.Cells.Count - 1; i++) // Asegúrate de no incluir la columna "Promedio"
            {
                // Intenta convertir el valor de la celda en un número
                if (double.TryParse(row.Cells[i].Value?.ToString(), out double nota))
                {
                    sumaNotas += nota;
                    contadorNotas++;
                }
            }

            // Calcula el promedio solo si se encontraron notas válidas
            if (contadorNotas > 0)
            {
                double promedio = sumaNotas / contadorNotas;
                row.Cells["Promedio"].Value = promedio.ToString("0.00");
            }
            else
            {
                // Si no se encontraron notas válidas, muestra un valor por defecto
                row.Cells["Promedio"].Value = "0.00";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formulario_principal = new Form1(gradoSelected);

            formulario_principal.Show();
            this.Hide();
        }

        private void AlumnosGrado_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Si es un cambio interno, no hagas nada
            if (esCambioInterno)
                return;

            // Verifica que no sea el encabezado y no sea una columna de ID, Nombres o Apellidos
            // ni prpomedio
            if (e.RowIndex >= 0 && e.ColumnIndex > 2 && e.ColumnIndex < dataGridView1.Columns.Count - 1)
            {
                DataGridView dataGridView = sender as DataGridView;
                string alumnoId = dataGridView.Rows[e.RowIndex].Cells["Id alumno"].Value.ToString();
                string materiaNombre = dataGridView.Columns[e.ColumnIndex].HeaderText;
                double nuevaNota;

                if (double.TryParse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out nuevaNota))
                {
                    if (nuevaNota >= 0 && nuevaNota <= 10)
                    {
                        string key = $"{alumnoId}-{materiaNombre}";

                        if (cambiosNotas.ContainsKey(key))
                        {
                            cambiosNotas[key] = nuevaNota;
                        }
                        else
                        {
                            cambiosNotas.Add(key, nuevaNota);
                        }

                        // Recalcula el promedio para el alumno
                        RecalcularPromedio(dataGridView.Rows[e.RowIndex]);

                        // Actualiza la base de datos para reflejar el cambio de nota
                        int materiaId = materiasDiccionario[materiaNombre];
                        string updateNotaSql = $"UPDATE notas SET nota = {nuevaNota} WHERE fk_alumno = {alumnoId} AND fk_materia = {materiaId}";
                        dbManager.ExecuteNonQuery(updateNotaSql, []);

                        MessageBox.Show($"La nota de la materia {materiaNombre} para el alumno con ID {alumnoId} cambió a: {nuevaNota}");
                    }
                    else
                    {
                        MessageBox.Show("La nota debe estar en el rango de 0 a 10.");

                        // Recupera la nota anterior desde la base de datos
                        int materiaId = materiasDiccionario[materiaNombre];
                        string selectNotaSql = $"SELECT nota FROM notas WHERE fk_alumno = {alumnoId} AND fk_materia = {materiaId}";
                        DataTable notaObtenida = dbManager.ExecuteQuery(selectNotaSql);

                        if (notaObtenida.Rows.Count > 0)
                        {
                            double notaAnterior = Math.Round(Convert.ToDouble(notaObtenida.Rows[0]["nota"]), 2);

                            esCambioInterno = true;

                            dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = notaAnterior;

                            esCambioInterno = false;
                        }
                    }
                }
            }
        }
    }
}
