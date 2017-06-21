using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    public class Movil : Dispositivo
    {
        private String so;
        private RAM _Ram;

        public Movil(String marca, String modelo, float pulgadas, RAM ram, bool estaReparado)
            : base(marca, modelo, pulgadas, estaReparado)
        {
            _Ram = ram;
        }


        public RAM ram { get; private set; }
        public string So
        {
            get
            {
                return so;
            }

            set
            {
                so = value;
            }
        }

        public RAM Ram
        {
            get
            {
                return ram;
            }

            set
            {
                ram = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Dispositivo Movil: Marca={0}\n, Modelo={1}\n, Pulgadas={2}\n, Reparado={2}\n", GetSetMarca, GetSetModelo, GetSetPulgadas, GetSetEstaReparado);
        }

    }
}