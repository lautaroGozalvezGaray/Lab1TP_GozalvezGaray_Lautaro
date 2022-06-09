using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1TP_GozalvezGaray_Lautaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declaracion de la estructura con los datos de ingreso
        public struct ESTACIONAMIENTO {
            public string dominio;
            public string tipo;
            public int cochera;
            public DateTime ingreso;
        }

        //constante para definir el nro de cocheras
        const int MAX = 50;

        //se declara el array de 50 elementos
        public ESTACIONAMIENTO[] estacionamiento;

        //se crea variable para controlar la cantidad de elementos cargados
        int cantidad;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creacion del arreglo
            estacionamiento = new ESTACIONAMIENTO[MAX];

            //se inicia vacio cada campo del arreglo
            for (int i = 0; i < MAX; i++)
            {
                estacionamiento[i].dominio = "";
                estacionamiento[i].tipo = "";
                estacionamiento[i].cochera = 0;
            }

            //se inicializa la variable cantidad
            cantidad = 0;

            //estado inicial de los btn

            btnBuscar.Enabled = false;
            btnIngresar.Enabled = false;
            btnEgresar.Enabled = false;

            //se agrega elementos a tipo de vehiculo

            cboVehiculo.Items.Add("Vehiculo");
            cboVehiculo.Items.Add("Utilitario");
            cboVehiculo.SelectedIndex = 0;

            //se agrega elementos a la lista de cochera

            for(int i=1; i<=MAX; i++)
            {
                lstCochera.Items.Add(i);
            }
        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar) == true) // revisa si es minuscula
            {
                e.KeyChar = Char.ToUpper(e.KeyChar); // si lo es, la convierte en la mayuscula
            }
            

        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
            
            string dominio = txtDominio.Text;
            char[] charDominio = dominio.ToCharArray();
            if (charDominio.Length == 6)
            {
                for (int i = 0; i <= 3; i++)
                {
                    
                }
            }
            else
            {
                btnIngresar.Enabled = false;
            }
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

    }
}
