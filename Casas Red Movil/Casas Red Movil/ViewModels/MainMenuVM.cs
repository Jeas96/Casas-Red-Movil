using System;
using System.Collections.Generic;
using System.Text;

namespace Casas_Red_Movil.ViewModels
{
    class MainMenuVM
    {
        public MainMenuVM() { }
        public List<String> ListaOpciones
        {
            get
            {
                return new List<string>()
                {
                    "Corretaje",
                    "Habilitacion",
                    "Gestion",
                    "Verificacion",
                    "Contaduria"

                };
            }
        }
    }
}
