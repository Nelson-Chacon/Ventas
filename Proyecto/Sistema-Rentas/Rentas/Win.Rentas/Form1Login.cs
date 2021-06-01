using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class Form1Login : Form
    {

        SeguridadBL _seguridad;// creamos una variable globar


        public Form1Login()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();//instanciamos la solucion
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//boton aceptar
        {

         
            string usuario;// Variable creada para evaluar el campo usuario
            string contrasena;//Variable creada para evaluar el campo contraseña

            usuario = textBox1.Text; //evaluamos las propiedades texto de la caja de texto 1(usuario) con la nueva variable creada
            contrasena = textBox2.Text;//evaluamos las propiedades texto de la caja de texto 2(contraseña) con la nueva variable creada

            var resultado = _seguridad.Autorizar(usuario, contrasena);//llamamos la funcion para evaluar si el usuario tiene acceso

            if (resultado == true)
            {
                this.Close();//de tener acceso el usuario esta instruccion nos permite ingresar el sistema

            }
            else
            {
                MessageBox.Show("¡Usuario o contraseña incorrecta!");// de no tener acceso mostraremos el siguiente mensaje
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)//Boton cancelar
        {
            Application.Exit();//intruccion para cerrar todo el sistema
        }
    }
}
