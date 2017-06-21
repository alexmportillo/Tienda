using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    public class PC : Dispositivo, Ireparable
    {


        private String _Fuente;
        private List<String> _Piezas;
        private String _Procesador;
        protected float _Precio;




        public PC(RAM ram, String fuente, List<String> piezas, String procesador, SO so, String modelo, String marca, float pulgadas, float precio)
            : base(marca, modelo, pulgadas, estaReparado)
        {
            _Fuente = fuente;
            _Piezas = piezas;
            _Procesador = procesador;
            _Precio = precio;



        }
        //Hereda de Ireparable
        public void Reparar(float precio)
        {
            _Precio = precio;
        }
        public static bool estaReparado { get; private set; }

        //Getters y Setters
        public string GetSetFuente
        {
            get
            {
                return _Fuente;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))

                {
                    throw new Exception("Campo Fuente vacia");
                }
                else { _Fuente = value; }
            }
        }

        public string GetSetProcesador
        {
            get
            {
                return _Procesador;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))

                {
                    throw new Exception("Campo Procesador vacio");
                }
                else { _Procesador = value; }
            }
        }

        public override string ToString()
        {
            return string.Format("Dispositivo PC: Marca={0}, Modelo={1}, Fuente={2}", GetSetMarca, GetSetModelo, GetSetProcesador, GetSetFuente, GetSetEstaReparado);
        }

    }
}