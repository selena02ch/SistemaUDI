using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoUDI
{
    class ClaseDatos
    {
        string nombre, domicilio, usuario, contra, costo, precioV;

        public string pCosto
        {
            set
            {
                costo = value;
            }
            get
            {
                return costo;
            }
        }

        public string pPrecioV
        {
            set
            {
                precioV = value;
            }
            get
            {
                return precioV;
            }
        }

        public string pUsuario
        {
            set
            {
                usuario = value;
            }
            get
            {
                return usuario;
            }
        }

        public string pContra
        {
            set
            {
                contra = value;
            }
            get
            {
                return contra;
            }
        }

        public string pNombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public string pDomicilio
        {
            set
            {
                domicilio = value;
            }
            get
            {
                return domicilio;
            }
        }

        public override string ToString()
        {
            return (nombre + " " + costo + " " + precioV);
        }
    }
    }
