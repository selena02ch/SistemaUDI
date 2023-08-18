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
    public partial class PanelProveedores : Form
    {
        AccesoBD instanciaBD = new AccesoBD("provider = microsoft.ace.oledb.12.0;" + "data source=" + "Sistema_de_Udi_III.accdb");
        ClaseDatos[] vectorDatosProv = new ClaseDatos[15];

        public PanelProveedores()
        {
            InitializeComponent();
        }

        private void btnGProv_Click(object sender, EventArgs e)
        {

        }

        private void CargarListaProv(string nombreTabla)
        {
            instanciaBD.leerTabla(nombreTabla);
            int contador = 0;

            while (instanciaBD.p_Lectura.Read())
            {
                ClaseDatos iDatosProv = new ClaseDatos();
                if (!instanciaBD.p_Lectura.IsDBNull(1))
                {
                    iDatosProv.pNombre = instanciaBD.p_Lectura.GetString(1);
                }

                if (!instanciaBD.p_Lectura.IsDBNull(2))
                {
                    iDatosProv.pDomicilio = instanciaBD.p_Lectura.GetString(2);
                }

                vectorDatosProv[contador] = iDatosProv;
                contador++;
            }

            listBoxProveedor.Items.Clear();

            for (int i = 0; i < contador; i++)
            {
                listBoxProveedor.Items.Add(vectorDatosProv[i].ToString());
                listBoxProveedor.SelectedIndex = listBoxProveedor.Items.Count - 1;
            }

            instanciaBD.p_Lectura.Close();
            instanciaBD.desconectar();
        }
    }
}
