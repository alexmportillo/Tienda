using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    public abstract class Dispositivo : Ireparable
    {
        private String _Marca;
        private String _Modelo;
        private float _Pulgadas;
        private bool _estaReparado;

        public Dispositivo(String marca, String modelo, float pulgadas, bool estaReparado)
        {
            _Marca = marca;
            _Modelo = modelo;
            _Pulgadas = pulgadas;
            _estaReparado = estaReparado;
        }

        public string GetSetMarca
        {
            get
            {
                return _Marca;
            }

            set
            {
                _Marca = value;
            }
        }

        public string GetSetModelo
        {
            get
            {
                return _Modelo;
            }

            set
            {
                _Modelo = value;
            }
        }

        public float GetSetPulgadas
        {
            get
            {
                return _Pulgadas;
            }

            set
            {
                _Pulgadas = value;
            }
        }



        public bool GetSetEstaReparado
        {
            get
            {
                if (_estaReparado)
                    return true;
                else
                    return false;
            }


        }

        public float Precio
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return string.Format("Dispositivo: Marca={0}\n, Modelo={1}\n, Pulgadas={2}\n, Reparado={2}\n", GetSetMarca, GetSetModelo, GetSetPulgadas, GetSetEstaReparado);
        }

        virtual public string GetRandomMacAddress()
        {
            var random = new Random();
            var buffer = new byte[6];
            random.NextBytes(buffer);
            //Expresion lamda 
            var result = String.Concat(buffer.Select(x => string.Format("{0}:", x.ToString("X2"))).ToArray());
            return result.TrimEnd(':');
        }

        public void Reparar(float precio)
        {
            throw new NotImplementedException();

        }


    }
}
