using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    public class Portatil : Dispositivo
    {

        private RAM _Ram;


        private String _Procesador;
        private SO _SO;


        public Portatil(RAM ram, String procesador, SO so, String marca, String modelo, float pulgadas, bool estaReparado)
            : base(marca, modelo, pulgadas, estaReparado)
        {
            _Ram = ram;
            _Procesador = procesador;
            _SO = so;
        }


        public override string ToString()
        {
            return string.Format("Dispositivo Portatil: Marca={0}\n, Modelo={1}\n, Pulgadas={2}\n, Reparado={2}\n", GetSetMarca, GetSetModelo, GetSetPulgadas, GetSetEstaReparado);
        }


    }
}
