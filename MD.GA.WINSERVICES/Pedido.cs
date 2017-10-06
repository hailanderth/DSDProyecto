using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.GA.WINSERVICES
{
    public class Pedido
    {
        public string RazonSocial { get; set; }
        public string RUC { get; set; }
        public string DescripcionArticulo { get; set; }
        public string UnidadMedida { get; set; }
        public double Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; set; }
        public string EmailProveedor { get; set; }
    }
}
