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
    public partial class PanelProductos : Form
    {
        AccesoBD instanciaBD = new AccesoBD("provider = microsoft.ace.oledb.12.0;" + "data source=" + "Sistema_de_Udi_III.accdb");
        ClaseDatos[] vectorDatosP = new ClaseDatos[15];

        public PanelProductos()
        {
            InitializeComponent();
            CargarListaP("Producto");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClaseDatos datosP = new ClaseDatos();

            datosP.pNombre = txtNombre.Text;
            datosP.pCosto = txtCosto.Text;
            datosP.pPrecioV = txtPrecioVenta.Text;

            string consulta = string.Format("insert into Producto (Nombre, Costo, Precio_Venta) values ('{0}', {1}, {2})", datosP.pNombre, datosP.pCosto, datosP.pPrecioV);
            instanciaBD.Actualizar(consulta);
            CargarListaP("Producto");
        }

        private void CargarListaP(string nombreTabla)
        {
            instanciaBD.leerTabla(nombreTabla);
            int contador = 0;

            while (instanciaBD.p_Lectura.Read())
            {
                ClaseDatos iDatosP = new ClaseDatos();
                if (!instanciaBD.p_Lectura.IsDBNull(1))
                {
                    iDatosP.pNombre = instanciaBD.p_Lectura.GetString(1);
                }

                if (!instanciaBD.p_Lectura.IsDBNull(2))
                {
                    iDatosP.pCosto = instanciaBD.p_Lectura.GetString(2);
                }

                if (!instanciaBD.p_Lectura.IsDBNull(3))
                {
                    iDatosP.pPrecioV = instanciaBD.p_Lectura.GetString(3);
                }

                vectorDatosP[contador] = iDatosP;
                contador++;
            }

            listBoxProd.Items.Clear();

            for (int i = 0; i < contador; i++)
            {
                listBoxProd.Items.Add(vectorDatosP[i].ToString());
                listBoxProd.SelectedIndex = listBoxProd.Items.Count - 1;
            }

            instanciaBD.p_Lectura.Close();
            instanciaBD.desconectar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelMenu menu = new PanelMenu();
            menu.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea borrar los datos " + txtNombre.Text + "?", "", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                string consulta = "delete * from Producto where Nombre = '" + vectorDatosP[listBoxProd.SelectedIndex].pNombre + "'";

                instanciaBD.Actualizar(consulta);

                CargarListaP("Producto");
            }
            else
            {
                MessageBox.Show("Operación cancelada");
            }
        }
    }
}
