using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    public class Tablet : Dispositivo
    {
        private String so;

        public Tablet(String marca, String modelo, float pulgadas, bool estaReparado)
            : base(marca, modelo, pulgadas, estaReparado)
        {
        }


        public override string ToString()
        {
            return string.Format("Dispositivo: Marca={0}\n, Modelo={1}\n, Pulgadas={2}\n, Reparado={2}\n", GetSetMarca, GetSetModelo, GetSetPulgadas, GetSetEstaReparado);
        }

    }
}
