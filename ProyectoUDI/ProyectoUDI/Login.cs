using System;
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
        public Login()
        {
          
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = textBox1.Text;
            String contraseña = textBox2.Text;

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
        }

       

        
    }
}
