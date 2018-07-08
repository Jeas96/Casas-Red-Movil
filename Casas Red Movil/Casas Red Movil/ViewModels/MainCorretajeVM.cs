using Casas_Red_Movil.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Casas_Red_Movil.ViewModels
{
    class MainCorretajeVM
    {
        public MainCorretajeVM() { }

        public string nombreUsuario
        {
            get
            {
                return App.usuarioActivo.Nombre;
            }
        }

        public List<CasaEnVenta> ListaCasas
        {
            get
            {
                return new List<CasaEnVenta>
                {
                    new CasaEnVenta()
                    {
                        Domicilio = "Buenos Aires, 20038, Tj",
                        Titular = "Pepe Garza",
                        Cliente = "Lionel Messi",
                        Estado = "Venta"
                    },
                    new CasaEnVenta()
                    {
                        Domicilio = "Los Lobos, 20346, Tj",
                        Titular = "Pepe Sanchez",
                        Cliente = "Jose Reyes",
                        Estado = "Venta"
                    }
                };
            }
        }
    }
}
