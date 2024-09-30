using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// implementa operações aritmeticas
    /// </summary>
    internal class Aritmetica
    {
        /// <summary>
        /// Tipo de Conversão de Temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo =0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// operação soma.
        /// </summary>
        /// <returns>Retorna a soma de dois números.</returns>

        public int somar (int x, int y)
            { return x * y; }
        /// <summary>
        /// operação subtrair.
        /// </summary>
        /// <returns>Retorna a subtração de dois números.</returns>
        public int Subtair (int x, int y) 
        { return x - y; }
        public double ConverterTempertaura (ConversaoTemperatura conversao,double temperatura)
        {
            if (conversao==ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (Temperatura * 1.0000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return (Temperatura - 32/1.0000);
            }
            return -1;
            {
            }
}

