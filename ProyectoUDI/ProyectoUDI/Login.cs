﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoUDI
{
    public partial class Login : Form
    {
        AccesoBD iAccesoBD = new AccesoBD("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + "Sistema_de_Udi_III.accdb");

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

<<<<<<< HEAD
            if (usuario == "" & contraseña == "")
            {
                MessageBox.Show("Ingrese Usuario y Contraseña");
            }
            else
            {
                iAccesoBD.conectar();
                iAccesoBD.comando.CommandText = "select Usuario from Configuracion where Usuario = '" + textBox1.Text + "'";
                iAccesoBD.consultaDatoCadena();
                string usuCompr = iAccesoBD.texto;
                iAccesoBD.comando.CommandText = "select Contraseña from Configuracion where Contraseña = '" + textBox2.Text + "'";
                iAccesoBD.consultaDatoCadena();
                string contraCompr = iAccesoBD.texto;
                iAccesoBD.desconectar();

                if ((usuCompr == usuario) && (contraCompr == contraseña))
                {
                    PanelMenu panelmenu = new PanelMenu();
                    panelmenu.Show();
                    this.Hide();

                }
                else
                {
                    ClaseDatos nuevoUsuario = new ClaseDatos();
                    nuevoUsuario.pUsuario = textBox1.Text;
                    nuevoUsuario.pContra = textBox2.Text;

                    string consulta = string.Format("insert into Configuracion (Usuario,Contraseña) values ('{0}','{1}')", nuevoUsuario.pUsuario, nuevoUsuario.pContra);
                    iAccesoBD.Actualizar(consulta);

                    MessageBox.Show("Datos guardados");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }

=======
            //for (int x = 0; x < 5; x++)
            //{

                //if ((usuario == usucontraseña[x, 0]) && (contraseña == usucontraseña[x, 1]))
                //{
                //    PanelMenu panelmenu = new PanelMenu();
                //    panelmenu.Show();
                //    panelmenu.Hide();
                //    break;
                //}

              //  {
                //    MessageBox.Show("intente denuevo");
                  //  usuario = "";
                   // contraseña = "";
                    //this.textBox1.Focus();
                   // break;
               // }

               // if (usuario == "" & contraseña == "")
                //{
                //    MessageBox.Show("Ingrese Usuario y Contraseña");
                //}
                //else
                //{
                 //   MessageBox.Show("Datos guardados");
                  //  textBox1.Clear();
                   // textBox2.Clear();
                   // textBox1.Focus();
                //}
           // }
>>>>>>> 9296230a9ce1b1a4d87355ad285b3197db42562f
        }
    }
}
