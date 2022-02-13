using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kevin_caceres_20191000816_evalucion_2
{
    public partial class Form1 : Form
    {

        


        public Form1()
        {
            InitializeComponent();

        }

        private void NombretextBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Procesarbutton1_Click(object sender, EventArgs e)
        {
            Boolean edadvalidacion;
            Boolean Antiguedadvalidacion;
            Boolean ventasvalidacion;
            DateTime fechanacimien = NacimientodateTimePicker1.Value;
            DateTime Antiguedad = TrabajodateTimePicker2.Value;
            //Validacion de edad
            String nombre = NombretextBox1.Text;
            int edad = Edad(fechanacimien);
            if(edad >= 30)
            {
                edadvalidacion = true;
                MessageBox.Show("Usted tiene "+edad+" Años");

            } else
            {
                edadvalidacion = false;
                MessageBox.Show("Usted no cumple con los requisitos por que tiene " + edad + " Años");
            }
            //validacion de antiguedad
            int Antiguo = AntiguedadCalculo(Antiguedad);

            if (Antiguo >= 10)
            {
                Antiguedadvalidacion = true;
                MessageBox.Show("Usted tiene " + Antiguo + " Años de laborar en la empresa\nSi aplica");

            }
            else
            {
                Antiguedadvalidacion = false;
                MessageBox.Show("Usted no cumple con los requisitos por que tiene " + edad + " Años de laborar");
            }
            //validacion de ventas  
            int sueldo = Convert.ToInt32(SueldotextBox1.Text);
            int ventas = Convert.ToInt32(PromedioVentastextBox1.Text);

            if (ventas >= 10000)
            {
                MessageBox.Show("Usted tiene " + ventas + " lempiras en ventas \nSi cumple este requisito");
                ventasvalidacion = true;
            }
            else
            {
                MessageBox.Show("Usted tiene " + ventas + " lempiras en ventas \nNo cumple este requisito");
                ventasvalidacion = false;
            }

            if (Antiguedadvalidacion == true && ventasvalidacion == true && edadvalidacion == true)
            {
                int aumento = 0;
                aumento = Convert.ToInt32((sueldo + (sueldo * 0.05)));
                
                MessageBox.Show("Felicidades "+nombre+" su nuevo sueldo es de " + aumento + " lempiras \nSIGUE ASI!!!");
            }
            else
            {
                MessageBox.Show("Lo sentimos no aplicas para el aumento " + "\nNO TE DESANIMES!!! :D");
            }


        }
        // funcion para calcular la edad del empleado 
        private int Edad(DateTime fechanacimiento)
        {
            DateTime fechaactual = DateTime.Now;
            int edad = 0;

            if (fechanacimiento >= fechaactual)
            {
                MessageBox.Show("La edad ingresada no es valida \nPor favor intentelo de nuevo.");
                return 0; 
            }

            edad = fechaactual.Year - fechanacimiento.Year;
            if(fechanacimiento.Month > fechaactual.Month)
            {
                --edad;
            }

            return edad;
        }
        //funcion para obtener la cantidad de tiempo que el empleado a laborado en la empresa 
        private int AntiguedadCalculo(DateTime fechAntiguedad)
        {
            DateTime fechaactual = DateTime.Now;
            int antiguedad = 0;

            if (fechAntiguedad >= fechaactual)
            {
                MessageBox.Show("¡¡ERROR!! \nLa fecha ingresada no es valida \nPor favor intentelo de nuevo.");
                return 0;
            }

            antiguedad = fechaactual.Year - fechAntiguedad.Year;
            if (fechAntiguedad.Month > fechaactual.Month)
            {
                --antiguedad;
            }

            return antiguedad;
        }

    }
}
