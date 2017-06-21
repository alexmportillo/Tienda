using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    public class Movil : Dispositivo
    {
        private RAM _Ram;

        public Movil(String marca, String modelo, float pulgadas, RAM ram, bool estaReparado)
            : base(marca, modelo, pulgadas, estaReparado)
        {
            _Ram = ram;
        }



        public override string ToString()
        {
            return string.Format("Dispositivo Movil: Marca={0}\n, Modelo={1}\n, Pulgadas={2}\n, Reparado={3}\n", GetSetMarca, GetSetModelo, GetSetPulgadas, GetSetEstaReparado);
        }

    }
}