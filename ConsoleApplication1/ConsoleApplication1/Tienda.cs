using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores;

namespace TiendaOrdenadores
{
    class Tienda
    {
        private String _Nombre;
        public List<Dispositivo> listaPC;
        

        public Tienda(string Nombre)
        {

            _Nombre = Nombre;
            listaPC = new List<Dispositivo>();
        }

        //Metodos de Validacion
        //LEER Numero para Validar las Opciones de los Menus
        public static int ValidarNumero()
        {
            string entrada = "";
            int entero = 0;
            bool error = false;

            do
            {
                Console.WriteLine("Introduzca numero:");

                entrada = Console.ReadLine();
                error = Int32.TryParse(entrada, out entero);
                if (!error)
                    Console.WriteLine("Error no has introducido un numero");

            } while (!error);
            return entero;
        }

        //Leer Double para Validar los Valores que sean Double(por ejemplo,Peso)

        public static double ValidarDouble()
        {

            string entrada = "";
            double num = 0;
            bool error = false;

            do
            {
                Console.WriteLine("Introduzca numero:");

                entrada = Console.ReadLine();
                error = double.TryParse(entrada, out num);
                if (!error)
                    Console.WriteLine("Error no has introducido un numero");

            } while (!error);
            return num;
        }


        //Menus
        //Menu Principal
        public void MenuPrincipal()
        {

            int OpcionesMenuPrincipal;
            do
            {
                Console.WriteLine("Bienvenido a su Tienda [" + _Nombre + "]");

                Console.WriteLine();
                Console.WriteLine("***********MENU PRINCIPAL*************");
                Console.WriteLine("*******1.Insertar Dispositivo*********");
                Console.WriteLine("*******2.Mostrar ficha****************");
                Console.WriteLine("*******3.Añadir a Reparacion**********");
                Console.WriteLine("*******4.Salir************************");
                Console.WriteLine("***********MENU PRINCIPAL*************");
                OpcionesMenuPrincipal = ValidarNumero();
                Console.Clear();
                switch (OpcionesMenuPrincipal)
                {

                    case 1:
                        aniadirPC();
                        break;

                    case 2:

                        break;

                    case 3:



                        break;

                    case 4:
                        Console.WriteLine(" Gracias por su visita\n" + " Esperos que vuelva a su " + _Nombre + "\n Estamos para lo que usted quiera");
                        break;

                    default:
                        Console.WriteLine("[ERROR] Nada que decir");
                        break;
                }
            } while (OpcionesMenuPrincipal != 4);
        }
        //Menu 2(Menu Dispositivo)
        private int MenuElegirDispositivo()
        {

            int OpcionesPC;
            do
            {
                Console.WriteLine();
                Console.WriteLine("*******SELECCION DISPOSITIVO*******");
                Console.WriteLine("*******1.PC************************");
                Console.WriteLine("*******2.Movil*********************");
                Console.WriteLine("*******3.Portatil******************");
                Console.WriteLine("*******4.Tablet********************");
                Console.WriteLine("*******SELECCION DISPOSITIVO*******");

                OpcionesPC = ValidarNumero();
            } while (OpcionesPC < 1 || OpcionesPC > 4);
            return OpcionesPC;
        }

        //Metodo que pide los datos del animal seleccionado en el switch y los insertará en la Lista.
        private void aniadirPC()
        {

            int opcion = MenuElegirDispositivo();
            List<string> piezas = null;
            switch (opcion)
            {
                case 1:
                    String estaReparado;
                    String Fuente;
                    String Modelo;
                    String Marca;
                    String Pulgadas;
                    String Procesador;
                    Console.WriteLine("Ram:");
                    estaReparado = Console.ReadLine();
                    Console.WriteLine("Fuente:");
                    Fuente = Console.ReadLine();
                    Console.WriteLine("Modelo:");
                    Modelo = Console.ReadLine();
                    Console.WriteLine("Marca:");
                    Marca = Console.ReadLine();
                    Console.WriteLine("Pulgadas:");
                    Pulgadas = Console.ReadLine();
                    Console.WriteLine("Modelo:");
                    Modelo = Console.ReadLine();
                    Console.WriteLine("Procesador:");
                    Procesador = Console.ReadLine();

                    //Debe ir los valores siempre ordenados de la misma forma que en la clase Correspondiente(si no Peta)
                    PC Pc = new PC(estaReparado, Fuente, piezas, Procesador, SO, Modelo, Marca, Pulgadas);
                    //Añadimos ListaPc Pc a la lista "ListaPC"
                    listaPC.Add(Pc);

                    break;

                case 2:

                    String ModeloMV;
                    String MarcaMV;
                    float PulgadasMV;
                    float ramMV;
                    Console.WriteLine("Modelo:");
                    ModeloMV = Console.ReadLine();
                    Console.WriteLine("Marca:");
                    MarcaMV = Console.ReadLine();
                    Console.WriteLine("Pulgadas:");
                    PulgadasMV = Console.Read();
                    Console.WriteLine("Modelo:");
                    ModeloMV = Console.ReadLine();
                    Console.WriteLine("Reparado:");
                    estaReparado = Console.ReadLine();
                    ramMV= Console.Read();
                    //Debe ir los valores siempre ordenados de la misma forma que en la clase Correspondiente(si no Peta)
                    Movil MV = new Movil(MarcaMV,ModeloMV, PulgadasMV, ramMV, estaReparado);
                    //Añadimos ListaPc Pc a la lista "ListaPC"
                    listaPC.Add(MV);
                    break;

                case 3:

                    String ModeloPORT;
                    String MarcaPORT;
                    float PulgadasPORT;
                    String ProcesadorPORT;
                    float ramPORT;
                    Console.WriteLine("Modelo:");
                    ModeloPORT = Console.ReadLine();
                    Console.WriteLine("Procesador:");
                    ProcesadorPORT = Console.ReadLine();
                    Console.WriteLine("Marca:");
                    MarcaPORT = Console.ReadLine();
                    Console.WriteLine("Pulgadas:");
                    PulgadasPORT = Console.Read();
                    Console.WriteLine("Modelo:");
                    ModeloPORT = Console.ReadLine();
                    Console.WriteLine("Reparado:");
                    estaReparado = Console.ReadLine();
                    ramPORT = Console.Read();
                    //Debe ir los valores siempre ordenados de la misma forma que en la clase Correspondiente(si no Peta)
                    Portatil PORT = new Portatil(ramPORT, ProcesadorPORT,SO,MarcaPORT, ModeloPORT, PulgadasPORT, estaReparado);
                    //Añadimos ListaPc Pc a la lista "ListaPC"
                    listaPC.Add(PORT);
                    break;

                case 4:

                    String ModeloTB;
                    String MarcaTB;
                    float PulgadasTB;
                    Console.WriteLine("Modelo:");
                    ModeloTB = Console.ReadLine();
                    Console.WriteLine("Marca:");
                    MarcaTB = Console.ReadLine();
                    Console.WriteLine("Pulgadas:");
                    PulgadasTB = Console.Read();
                    Console.WriteLine("Modelo:");
                    ModeloTB = Console.ReadLine();
                    Console.WriteLine("Reparado:");
                    estaReparado = Console.ReadLine();

                    //Debe ir los valores siempre ordenados de la misma forma que en la clase Correspondiente(si no Peta)
                    Tablet TB = new Tablet(MarcaTB, ModeloTB, PulgadasTB, estaReparado);
                    //Añadimos ListaPc Pc a la lista "ListaPC"
                    listaPC.Add(TB);
                    break;
            }
        }
    }
}


/* public void aniadir(Dispositivo d)
 {
     this.lista.Add(d);
 }

 public void quitar(Dispositivo d)
 {
     if (!d.EstaReparado)
     {
         Console.WriteLine("El dispositivo no esta reparado");
     }
     else
     {
         this.lista.Remove(d);
     }

 }*/
