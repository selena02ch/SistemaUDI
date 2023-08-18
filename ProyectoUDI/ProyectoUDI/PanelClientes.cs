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
    public partial class PanelClientes : Form
    {
        public PanelClientes()
        {
            InitializeComponent();
        }


        AccesoBD instanciaBD = new AccesoBD("provider = microsoft.ace.oledb.12.0;" + "data source=" + "Sistema_de_Udi_III.accdb");
        ClaseDatos[] vectorDatosC = new ClaseDatos[15];

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ClaseDatos datosC = new ClaseDatos();
            datosC.pNombre = textBoxNyA.Text;
            datosC.pDomicilio = textBoxDomicilio.Text;

            string consulta = string.Format("insert into Cliente(Nombre, Domicilio)values('{0}','{1}')", datosC.pNombre, datosC.pDomicilio);
            instanciaBD.Actualizar(consulta);
            CargarListaC("Cliente");
        }

        private void CargarListaC(string nombreTabla)
        {
            instanciaBD.leerTabla(nombreTabla);
            int contador = 0;

            while (instanciaBD.p_Lectura.Read())
            {
                ClaseDatos DatosC = new ClaseDatos();

                if (!instanciaBD.p_Lectura.IsDBNull(1))
                {
                    DatosC.pNombre = instanciaBD.p_Lectura.GetString(1);
                }

                if (!instanciaBD.p_Lectura.IsDBNull(2))
                {
                    DatosC.pDomicilio = instanciaBD.p_Lectura.GetString(2);
                }
                vectorDatosC[contador] = DatosC;
                contador++;
            }

            lista.Items.Clear();
            for (int i = 0; i < contador; i++)
            {
                lista.Items.Add(vectorDatosC[i].ToString());
                lista.SelectedIndex = lista.Items.Count - 1;
            }
            instanciaBD.p_Lectura.Close();
            instanciaBD.desconectar();
        }
    }
}
