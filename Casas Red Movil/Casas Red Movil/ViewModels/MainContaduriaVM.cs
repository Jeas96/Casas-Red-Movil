using System;
using System.Collections.Generic;
using System.Text;

namespace Casas_Red_Movil.ViewModels
{
    class MainContaduriaVM
    {
        public List<Area> ListaPorcentajes
        {
            get
            {
                return new List<Area>()
                {
                    new Area()
                    {
                        Area_= "Corretaje",
                        Porcentaje = "40%"
                    },new Area()
                    {
                        Area_= "Habilitacion",
                        Porcentaje = "10%",
                        Gastos = "$1000",
                    },new Area()
                    {
                        Area_= "Gestion",
                        Porcentaje = "20%",
                        Gastos = "$5000",
                    },new Area()
                    {
                        Area_= "Verificacion",
                        Porcentaje = "30%",
                        Gastos = "$1300",
                    },new Area()
                    {
                        Area_= "Contaduria",
                        Porcentaje = "40%",
                        Gastos = "$2000",
                    },
                };
            }
        }
    }

    internal class Area
    {
        public string Area_ { get; set; }
        public string Porcentaje { get; set; }
        public string Gastos { get; set; }
    }
}
