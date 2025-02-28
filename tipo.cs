using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_examen_nnny_2025
{
    internal class tipo
    {
        int auto;
        string placa;
        string color;
        string marca;
        string puertas;

        int moto;
        string Placa;
        string Color;
        string Potencia;

        public tipo()
        {

        }

        public tipo(int auto, string placa, string color, string marca, string puertas)
        {

            _auto = auto;
            _placa = placa;
            _color = color;
            _marca = marca;
            _puertas = puertas;
        }

        static void autoPlaca(string placa)
        {
            Console.WriteLine("La placa del auto es: " + placa);
        }
        static void autocolor(string color)
        {
            Console.WriteLine("El auto es de color: " + color);
        }
        static void automarca(string marca)
        {
                Console.WriteLine("El auto es de la marca: " + marca);
        }
        static void autopuertas(string puertas)
        {
            Console.WriteLine("El auto tiene: " + puertas);
        }


        static void motoPlaca(string Placa)
        {
            Console.WriteLine("La placa de la moto es: " + Placa);
        }
        static void motoColor(string Color)
        {
            Console.WriteLine("La moto es de color: " + Color);
        }

        static void motoPotencia(string Potencia)
        {
            Console.WriteLine("La moto tiene una Potencia de: " + Potencia);
        }
    }
}
