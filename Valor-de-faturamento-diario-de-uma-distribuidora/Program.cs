using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Exercicio3.Models;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var list = new List<FaturamentoDistribuidora>()
            {
                new FaturamentoDistribuidora(){Day = 1 , Value = 22174.1664},
                new FaturamentoDistribuidora(){Day = 2, Value = 24537.6698},
                new FaturamentoDistribuidora(){Day = 3, Value = 26139.6134},
                new FaturamentoDistribuidora(){Day = 4, Value = 0.0},
                new FaturamentoDistribuidora(){Day = 5, Value = 0.0},
                new FaturamentoDistribuidora(){Day = 6, Value = 26742.6612},
                new FaturamentoDistribuidora(){Day = 7, Value = 0.0},
                new FaturamentoDistribuidora(){Day = 8, Value = 42889.2258},
                new FaturamentoDistribuidora(){Day = 9, Value = 46251.174},
                new FaturamentoDistribuidora(){Day = 10, Value = 11191.4722},
                new FaturamentoDistribuidora(){Day = 11, Value = 0.0},
                new FaturamentoDistribuidora(){Day = 12, Value = 0.0},
                new FaturamentoDistribuidora(){Day = 13, Value = 3847.4823},
                new FaturamentoDistribuidora(){Day = 14, Value = 373.7838},
                new FaturamentoDistribuidora(){Day = 15, Value = 2659.7563},
                new FaturamentoDistribuidora(){Day = 16, Value = 48924.2448},
                new FaturamentoDistribuidora(){Day = 17, Value = 18419.2614},
                new FaturamentoDistribuidora(){Day = 18, Value = 0.0},
                new FaturamentoDistribuidora(){Day = 19, Value = 0.0},
                new FaturamentoDistribuidora(){Day = 20, Value = 35240.1826},
                new FaturamentoDistribuidora(){Day = 21, Value = 43829.1667},
                new FaturamentoDistribuidora(){Day = 22, Value = 18235.6852},
                new FaturamentoDistribuidora(){Day = 23, Value = 4355.0662},
                new FaturamentoDistribuidora(){Day = 24, Value = 13327.1025},
                new FaturamentoDistribuidora(){Day = 25, Value = 0.0},
                new FaturamentoDistribuidora(){Day = 26, Value = 0.0},
                new FaturamentoDistribuidora(){Day = 27, Value = 25681.8318},
                new FaturamentoDistribuidora(){Day = 28, Value = 1718.1221},
                new FaturamentoDistribuidora(){Day = 29, Value = 13220.495},
                new FaturamentoDistribuidora(){Day = 30, Value = 8414.61}
            };

            
            
             var l1 = list.Where(p=> p.Day >= 1 && p.Value > 0).OrderBy(p=> p.Day).Min(p=> p.Value);
            
             Console.WriteLine("O menor valor de faturamento ocorrido em um dia do mês R$: "  
             + l1.ToString("F4", CultureInfo.InvariantCulture ));    
             Console.WriteLine();

             var l2 = list.Max(p=> p.Value);       
             Console.WriteLine("O maior valor de faturamento ocorrido em um dia do mês R$: " 
             + l2.ToString("F4", CultureInfo.InvariantCulture));  
             Console.WriteLine();    

             var l3 = list.Select(p => new {p.Day, p.Value}).Average(p=> p.Value);

             Console.WriteLine("A média mensal do valor de faturamento ocorrido em um dia do mês R$: " 
             + l3.ToString("F4", CultureInfo.InvariantCulture));  
                        
            
            
        }
    }
}
