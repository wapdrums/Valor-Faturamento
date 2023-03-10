using System;
using System.Text;
using System.Collections.Generic;
namespace Exercicio3.Models
{
    public class FaturamentoDistribuidora
    {
       

        public int Day { get; set; }
        public double Value { get; set; }

        static void Message<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);

            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Dia: ");
            sb.AppendLine(Day.ToString());
            sb.Append("Valor: ");
            sb.AppendLine(Value.ToString());
            return sb.ToString();
        }
    }
}