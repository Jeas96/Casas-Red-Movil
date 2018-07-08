using Casas_Red_Movil.Models;
using System.Collections.Generic;

namespace Casas_Red_Movil.ViewModels
{
    class MainHabilitacionVM
    {
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
