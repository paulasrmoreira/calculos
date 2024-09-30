using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão.
    /// </summary>
    internal static class Conversoes
        
    {   /// <summary>
        /// Tipo de Conversão de Temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// Conversão de temperaturas.
        /// </summary>
        /// <param name="conversao"> A conversão a efetuar </param>
        /// <param name="temperatura"> A temperatura a converter</param>
        /// <returns>
        /// Retorna o resultado da conversão.</returns>
        public static double ConverterTempertaura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.0000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return (temperatura - 32 / 1.0000);
            }
            return -1;
        
        }
    }
}
