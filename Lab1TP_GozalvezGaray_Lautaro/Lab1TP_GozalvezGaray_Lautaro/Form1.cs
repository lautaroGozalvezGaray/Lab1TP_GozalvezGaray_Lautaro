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
                estacionamiento[i].ingreso = DateTime.MinValue;
            }

            //se inicializa la variable cantidad
            cantidad = 1;

            //estado inicial de los btn

            btnBuscar.Enabled = false;
            btnIngresar.Enabled = false;
            btnEgresar.Enabled = false;

            //se agrega elementos a tipo de vehiculo

            cboVehiculo.Items.Add("Automóvil");
            cboVehiculo.Items.Add("Utilitario");
            cboVehiculo.SelectedIndex = 0;

            //se agrega elementos a la lista de cochera

            for(int i=1; i<=MAX; i++)
            {
                lstCochera.Items.Add(i);
            }
        }

        //se hace mayuscula el txt de dominio
        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar) == true) // revisa si es minuscula
            {
                e.KeyChar = Char.ToUpper(e.KeyChar); // si lo es, la convierte en la mayuscula
            }
            

        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
            //se verifica si la patente cuenta con 6 o 7 digitos

            if (lstCochera.Text != "" && (txtDominio.Text.Length == 7 || txtDominio.Text.Length == 6))
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //se comprueba que la patente sea de un formato u otro.
            string dominio = txtDominio.Text;
            char[] charDominio = dominio.ToCharArray();//se almacena la patente y luego se crea un array a partir del string

            bool resultado = true;

            if (charDominio.Length == 6)
            {

                for (int i = 0; i < 3; i++)
                {
                    if (!Char.IsLetter(charDominio[i]))
                    {
                        mensajeError();
                        resultado = false;
                        break;
                    }
                    resultado = true;
                }
                for (int i = 3; i < charDominio.Length; i++)
                {
                    if (!Char.IsDigit(charDominio[i]))
                    {
                        mensajeError();
                        resultado = false;
                        break;
                    }
                }
            }else if (charDominio.Length == 7)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (!Char.IsLetter(charDominio[i]))
                    {
                        mensajeError();
                        resultado = false;
                        break;
                    }
                }
                for (int i = 2; i <5; i++)
                {
                    if (!Char.IsDigit(charDominio[i]))
                    {
                        mensajeError();
                        resultado = false;
                        break;
                    }
                }
                for (int i = 5; i < charDominio.Length; i++)
                {
                    if (!Char.IsLetter(charDominio[i]))
                    {
                        mensajeError();
                        resultado = false;
                        break;
                    }
                }
            }

            //si la patente es correcta se agrega al vehiculo
            if (resultado == true)
            {
                AgregarVehiculo();
            }


        }

        private void txtBuscarDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar) == true) // revisa si es minuscula
            {
                e.KeyChar = Char.ToUpper(e.KeyChar); // si lo es, la convierte en la mayuscula
            }
        }

        // se valida si la patente cuenta con 6 o 7 digitos
        private void txtBuscarDominio_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarDominio.Text.Length == 7 || txtBuscarDominio.Text.Length == 6)
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //variable para definir la hora de egreso

            DateTime TimeEgreso = DateTime.Now;
            int i;
            //ciclo for para buscar el vehiculo de acuerdo a la patente
            for (i = 0; i < MAX; i++)
            {
                if (estacionamiento[i].dominio == txtBuscarDominio.Text)
                {

                    lblTipoVehiculo.Text = estacionamiento[i].tipo;

                    lblUbicacion.Text = (estacionamiento[i].cochera).ToString();

                    lblIngreso.Text = estacionamiento[i].ingreso.ToShortDateString() + " " + estacionamiento[i].ingreso.ToLongTimeString();
                    DateTime timeIngreso = estacionamiento[i].ingreso;

                    lblEgreso.Text = TimeEgreso.ToShortDateString() + " " + TimeEgreso.ToLongTimeString();

                    //se define una variable para almacenar el precio en fuincion del tiempo que estuvo el vehiculo
                    double costo;

                    if (estacionamiento[i].tipo == "Automóvil")
                    {
                        costo = ((TimeEgreso - timeIngreso).TotalMinutes) * 2.5;
                        lblImporte.Text = costo.ToString("#.00");
                    }
                    else
                    {
                        costo = ((TimeEgreso - timeIngreso).TotalMinutes) * 3;
                        lblImporte.Text = costo.ToString("#.00");
                    }

                    btnEgresar.Enabled = true;

                    break;

                }

            }
            if (i == MAX)
            {
                MessageBox.Show("No se encontró la patente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscarDominio.Text = "";

            }



        }

        private void btnEgresar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < cantidad; i++)
            {
                if (estacionamiento[i].dominio == txtBuscarDominio.Text)
                {
                    estacionamiento[i].dominio = "";
                    estacionamiento[i].tipo = "";
                    estacionamiento[i].cochera = 0;
                    estacionamiento[i].ingreso = DateTime.MinValue;
                }
            }


            lstCochera.Items.Clear();

            //ciclos for anidados para agregar la ubicacion que se libera unicamente
            for (int i = 1; i<=50; i++)
            {
                bool disponible = false;
                for(int j = 0; j<50; j++)
                {
                    if (i == estacionamiento[j].cochera)
                    {
                        disponible = true;
                    }
                }
                if (disponible == false)
                {
                    lstCochera.Items.Add(i);
                }
            }

            //se reestablecen los label

            txtBuscarDominio.Text = "";
            lblIngreso.Text = "";
            lblUbicacion.Text = "";
            lblTipoVehiculo.Text = "";
            lblEgreso.Text = "";
            lblImporte.Text = "";

            
        }

        private void AgregarVehiculo()
        {
            //procedimiento para agregar nuevos choches
            if (cantidad < MAX)//se corrobora si hay lugar
            {
                //ciclo for para agregar un vehiculo en el primer lugar vacio que se encuentre
                for (int i = 0; i < MAX; i++)
                {
                    if (estacionamiento[i].dominio == "")
                    {
                        estacionamiento[i].dominio = txtDominio.Text;
                        estacionamiento[i].tipo = cboVehiculo.Text;
                        estacionamiento[i].cochera = int.Parse(lstCochera.Text);
                        estacionamiento[i].ingreso = DateTime.Now;

                        cantidad++;

                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ya no quedan lugares disponibles", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //remover el elemento que se selecciono de la lista.

            lstCochera.Items.Remove(lstCochera.SelectedItem);

            //dejamos en blanco el espacio de la patente
            txtDominio.Text = "";
            cboVehiculo.SelectedIndex = 0;
        }


        private void mensajeError()
        {
            MessageBox.Show("Debe ingresar un formato de patente XX999XX o XXX999", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void lstCochera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
