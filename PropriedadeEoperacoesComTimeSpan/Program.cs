using System;

namespace PropriedadeEoperacoesComTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine("Valor Máximo do TimeSpan: "+t1);
            Console.WriteLine("Valor Mínimo do TimeSapn: "+t2);
            Console.WriteLine("Valor zero do TimeSpan: " + t3);

            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

            /*PROPIEDADES DO TimeSpan*/
            Console.WriteLine();
            Console.WriteLine("Valor Inicial do TimeSpan intânciado: " + t4);
            Console.WriteLine();
            Console.WriteLine("Quantidade de Dias que tem o TimeSpan usando o .Days: " + t4.Days); /*A função .Days mostra a quantidade de dias que possui o TimeSpan Instânciado*/
            Console.WriteLine();
            Console.WriteLine("Quantidade de Horas que tem o TimeSpan usando o .Hours: " + t4.Hours); /*a função .Hours mostra a quantidade de horas que tem o TimeSpan Instânciado*/
            Console.WriteLine();
            Console.WriteLine("Quantidade de Minutos que tem o TimeSpan usando o .Minutes: " + t4.Minutes); /*Mostra a quantidade de Minutos*/
            Console.WriteLine();
            Console.WriteLine("Quantidade de Milisegundos que tem o TimeSpan usando o .MilliSeconds: " + t4.Milliseconds); /*Mostra a quantidade de Milisegundos*/
            Console.WriteLine();
            Console.WriteLine("Quantidade de Segundos que tem o TimeSpan usando o .Seconds: " + t4.Seconds); /*Mostra a quantidade de Segundos*/
            Console.WriteLine();
            Console.WriteLine("Quantidade de Ticks que tem o TimeSpan usando o .Ticks: " + t4.Ticks); /*Mostra a quantidade de Ticks*/
            Console.WriteLine();
            Console.WriteLine("Quantidade Total de Dias que tem o TimeSpan usando o .TotalDays: " + t4.TotalDays); /*Mostra a quantidade total de dias que tem o TimeSpan somando o total de tudo e devolvendo no formato especificado*/
            Console.WriteLine();
            Console.WriteLine("Quantidade Total de Horas que tem o TimeSpan usando o .TotalHours: " + t4.TotalHours); /*Mostra a quantidade total de horas*/
            Console.WriteLine();
            Console.WriteLine("Quantidade Total de Minutos que tem o TimeSpan usando o .TotalMinutes: " + t4.TotalMinutes); /*Mostra a quantidade total de minutos*/
            Console.WriteLine();
            Console.WriteLine("Quantidade Total de Segundos que tem o TimeSpan usando o .TotalSeconds: " + t4.TotalSeconds); /*Mostra a quantidade total de Segundos*/
            Console.WriteLine();
            Console.WriteLine("Quantidade Total de Millisegundos que tem o TimeSpan usando o .TotalMilliseconds: " + t4.TotalMilliseconds); /*Mostra a quantidade total de Milisegundos*/

            /*OPERAÇÕES COM O TimeSpan*/

            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);

            Console.WriteLine();
            Console.WriteLine("TimeSpan t5: "+ t5);
            Console.WriteLine();
            Console.WriteLine("TimeSpan T6: " + t6);

            TimeSpan soma = t5.Add(t6); /*Operação que soma Dois TimeSpan*/
            Console.WriteLine();
            Console.WriteLine("Soma dos TimeSpan com o .Add: " + soma);

            TimeSpan sub = t5.Subtract(t6); /*Operação que Subtrai o TimeSpan por um numero Double*/
            Console.WriteLine();
            Console.WriteLine("Difereça entre os TimeSpan com o .Subtract: " + sub);

            TimeSpan mult = t6.Multiply(2); /*Operação que Multiplica o TimeSpan por um numero*/
            Console.WriteLine();
            Console.WriteLine("Multiplicação por 2 com o .Multiply: " + mult);

            TimeSpan div = t6.Divide(2); /*Operaçaõ que Divide o TimeSpan por um numero*/
            Console.WriteLine();
            Console.WriteLine("Divisão por 2 com o .Divide: " + div);
            
        }
    }
}
