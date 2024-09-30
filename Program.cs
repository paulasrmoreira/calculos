using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");
       
            Console.WriteLine($"4+2=  {Aritmetica.somar (4,2)}");
            Console.WriteLine($"4-2=  {Aritmetica.subtrair (4,2)}");
                
            double t1 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t2 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 100);

            Console.WriteLine($"36 Celsious ={t1}"Fahrenheit");
            Console.WriteLine($"100 Fahrenheit={t2}"Celsious");

            Console.ReadKey();
         }
    }
}
