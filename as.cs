using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           Console.WriteLine("buenos dias, bienvenido a nuestro zoologi ");
           Console.WriteLine("ingrese cuantos años tiene");
           String secuencia ="";
           secuencia = Console.ReadLine();
           int a = 0;
           a = Convert.ToInt32(secuencia);
            if(a > 35)
            {
                Console.WriteLine("Disculpe ha superado el limite de edad para el parque.");
            }
            else
            {
                
                
                Console.WriteLine("Bienvenido");
                Console.WriteLine("ingrese su estatura para  calificar a cuales animales puede visitar");
                secuencia = Console.ReadLine();
                Double tamaño = 0.0;
                tamaño = Convert.ToDouble (secuencia);
                if (tamaño < 1.6)
                {
                Console.WriteLine("Puedes ir a ver a  los elefantes y las jirafas");    
                }
                else
                {
                    Console.WriteLine("puedes visitar al leon, cocodrilo y los gorilas");
                
                }
            }
        }
    }
}