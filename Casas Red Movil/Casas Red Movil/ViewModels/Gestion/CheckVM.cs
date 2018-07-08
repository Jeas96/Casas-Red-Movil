using Casas_Red_Movil.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casas_Red_Movil.ViewModels.Gestion
{
    class CheckVM
    {
        public List<CasaEnVenta> ListaCasas
        {
            get
            {
                return new List<CasaEnVenta>()
                {
                    new CasaEnVenta()
                    {
                        Domicilio ="Casa 1",
                    },
                    new CasaEnVenta()
                    {
                        Domicilio ="Casa 2",
                    },new CasaEnVenta()
                    {
                        Domicilio ="Casa 3",
                    }
                };
            }
        }
        public List<Preguntas> Check
        {
            get
            {
                return new List<Preguntas>() {
                    new Preguntas()
                    {
                        Concepto = "Escrituras",
                    },
                    new Preguntas()
                    {
                        Concepto = "Planta Cartografica",
                    },
                    new Preguntas()
                    {
                        Concepto = "Predial",
                    },
                    new Preguntas()
                    {
                        Concepto = "Recibo de Luz",
                    },
                    new Preguntas()
                    {
                        Concepto = "Recibo de Agua",
                    },
                    new Preguntas()
                    {
                        Concepto = "Acta de Nacimiento",
                    },
                    new Preguntas()
                    {
                        Concepto = "Copia del IFE",
                    },
                    new Preguntas()
                    {
                        Concepto = "Solicitud de Retencion de Info",
                    },
                    new Preguntas()
                    {
                        Concepto = "Certificado de Hipoteca",
                    },
                    new Preguntas()
                    {
                        Concepto = "Certificado Fiscal",
                    },
                    new Preguntas()
                    {
                        Concepto = "Sol Estado",
                    },
                    new Preguntas()
                    {
                        Concepto = "Junta Urbi",
                    },
                    new Preguntas()
                    {
                        Concepto = "Agua Pago",
                    },
                    new Preguntas()
                    {
                        Concepto = "Certificado Cartografico",
                    },
                    new Preguntas()
                    {
                        Concepto = "No Oficial",
                    },
                    new Preguntas()
                    {
                        Concepto = "Avaluo",
                    },
                    new Preguntas()
                    {
                        Concepto = "CT Banco",
                    },
                    new Preguntas()
                    {
                        Concepto = "Aviso Suspension",
                    },
                    new Preguntas()
                    {
                        Concepto = "Formato INVONAVIT",
                    },
                    new Preguntas()
                    {
                        Concepto = "Fotos de la Propiedad",
                    },
                    new Preguntas()
                    {
                        Concepto = "Evaluo Contacto",
                    },
                    new Preguntas()
                    {
                        Concepto = "Planeacion Finanza",
                    },
                    new Preguntas()
                    {
                        Concepto = "Urbanizacion",
                    },
                    new Preguntas()
                    {
                        Concepto = "Credito INFONAVIT",
                    },
                    new Preguntas()
                    {
                        Concepto = "Notaria",
                    },
                    new Preguntas()
                    {
                        Concepto = "Firma Escrituras",
                    },
                };
            }
        }
    }
}
