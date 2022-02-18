using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_KevinCaceres_20191000816
{
    public partial class Ingresar_Nombres : Form
    {
        int contador = 0;
        public Ingresar_Nombres()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            
            string[] nombres = new string[10];
            int[] edad = new int[10];
            int maximo = edad.Length;
            if (contador < maximo)
            {
                nombres[contador] = NombreTextBox.Text;
                edad[contador] = Convert.ToInt32(EdadTextBox.Text);
                ListadoComboBox.Items.Add(nombres[contador] + " " + edad[contador]);
                contador++;
            }
            else
            {
                MessageBox.Show("Lo sentimos haz Agregado el numero maximo de nombres","Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            contador = 0;
            ListadoComboBox.Items.Clear();

        }
    }
}
