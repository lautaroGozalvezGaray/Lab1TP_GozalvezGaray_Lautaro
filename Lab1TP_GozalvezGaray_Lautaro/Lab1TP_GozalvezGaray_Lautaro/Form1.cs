﻿using System;
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
            cantidad = 1;

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

            if (checkLstBox() == true && (txtDominio.Text.Length == 7 || txtDominio.Text.Length == 6))
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }

            /*
            string dominio = txtDominio.Text;
            char[] charDominio = dominio.ToCharArray();
            if (charDominio.Length == 6)
            {
                for (int i = 0; i <= 3; i++)
                {
                    charDominio[i]= ????;
                }
            }
            else
            {
                btnIngresar.Enabled = false;
            }
            */


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //variable para contolar los ciclos
            int i;

            //procedimiento para agregar nuevos choches
            if (cantidad < MAX)//se corrobora si hay lugar
            {
                //ciclo for para agregar un vehiculo en el primer lugar vacio que se encuentre
                for (i = 0; i < MAX; i++)
                {
                    if (estacionamiento[i].dominio == "")
                    {
                        estacionamiento[i].dominio = txtDominio.Text;
                        estacionamiento[i].tipo = cboVehiculo.GetItemText(cboVehiculo.SelectedItem);
                        estacionamiento[i].cochera = lstCochera.SelectedIndex+1;
                        estacionamiento[i].ingreso = DateTime.Now;

                        cantidad++;

                        break;
                    }
                }
            }
            else{
                MessageBox.Show("Ya no quedan lugares disponibles", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //for para remover el elemento que se selecciono de la lista.
            for(i=0; i<MAX; i++)
            {
                if(estacionamiento[i].cochera != 0)
                {
                    lstCochera.Items.RemoveAt(lstCochera.SelectedIndex);
                    break;
                }
            }

            //dejamos en blanco el espacio de la patente
            txtDominio.Text = "";
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

            //ciclo for para buscar el vehiculo de acuerdo a la patente
            for (int i = 0; i < MAX; i++)
            {
                if (estacionamiento[i].dominio == txtBuscarDominio.Text)
                {

                    estacionamiento[i].tipo = lblTipoVehiculo.Text;

                    lblUbicacion.Text = estacionamiento[i].cochera.ToString();

                    lblIngreso.Text = estacionamiento[i].ingreso.ToShortDateString()+" "+ estacionamiento[i].ingreso.ToLongTimeString();
                    DateTime timeIngreso = estacionamiento[i].ingreso;

                    lblEgreso.Text = TimeEgreso.ToShortDateString()+" "+TimeEgreso.ToLongTimeString();

                    //se define una variable para almacenar el precio en fuincion del tiempo que estuvo el vehiculo
                    double costo;

                    if (cboVehiculo.SelectedIndex == 0)
                    {
                        costo = ((TimeEgreso - timeIngreso).TotalMinutes) * 2.5;
                        lblImporte.Text = costo.ToString("#.00");
                    }
                    else
                    {
                        costo = ((TimeEgreso - timeIngreso).TotalMinutes) * 3;
                        lblImporte.Text = costo.ToString("#.00");
                    }
                    break;

                }
                else
                {
                    MessageBox.Show("No se encontró la patente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }


        }

        private bool checkLstBox()//funcion para devolver true o false si esta seleccionado un elemento del listBox
        {
            bool resultado = false;
            if (lstCochera.SelectedIndex >= 0 && lstCochera.SelectedIndex <= 50)
            {
                resultado = true;
            }

            return resultado;
            
        }
       

        

        private void lstCochera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
