using System;
using System.Globalization;

namespace Aula_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data atual do sistema
            DateTime d1 = DateTime.Now;

            //Passando um long - Ticks ( nano segundos)
            DateTime d2 = new DateTime(601545722534593989);

            //Data formatada AAAA/MM/DD
            DateTime d3 = new DateTime(1992, 05, 18);

            //Data formatada AAAA/MM/DD/ HH:MM:SS
            DateTime d4 = new DateTime(1990, 11, 24, 23, 56, 48);

            //Data atual com zero hora
            DateTime d5 = DateTime.Today;

            //Data de Greenwich - Fuso = 0
            DateTime d6 = DateTime.UtcNow;

            //Convertendo de String para data - Esse formato tmb é conhecido por alguns BD's
            DateTime d7 = DateTime.Parse("2000-09-12");
            DateTime d8 = DateTime.Parse("2000-09-12 15:05:48");
            DateTime d9 = DateTime.Parse("12/11/2011 15:05:48");

            //Definindo como deve ser o formato da data
            /*
             Console.WriteLine("Informe a data: ");
            string data = Console.ReadLine();

            DateTime d10 = DateTime.ParseExact(data, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine("Completo: " + d10);
            Console.WriteLine("DAta: " + d10.Date);
            Console.WriteLine("Dia: " + d10.Day);
            Console.WriteLine("Ano: " + d10.Year);
            Console.WriteLine("Minutos: " + d10.Minute);
            Console.WriteLine("Dia do ano: " + d10.DayOfYear);
            Console.WriteLine("Dia da semana: " + d10.DayOfWeek);
            */       

            //Convertendo para String
            //string s1 = d10.ToLongDateString();

            /*Console.WriteLine("********** Date Time Kind **********");

            DateTime d11 =  new DateTime(2000, 09, 15, 13, 43, 44, DateTimeKind.Local);
            Console.WriteLine("\r\nData Kind: " + d11.Kind + "\r\nLocal (-3): " + d11 );
            Console.WriteLine("\r\nHorário universal (GreenWich): " + d11.ToUniversalTime());


            DateTime d12 = new DateTime(2000, 09, 15, 13, 43, 44, DateTimeKind.Utc);
            Console.WriteLine("\r\nData Kind: " + d12.Kind + "\r\nUtc: " + d12 );
            Console.WriteLine("Data local: " + d12.ToLocalTime());
            */

            //Utilizando o padrão ISO 8601
            DateTime d = DateTime.Parse("1992-05-18 23:45:37");
            Console.WriteLine("D: " + d);
            Console.WriteLine("D kind: " + d.Kind);
            Console.WriteLine("D UTC: " + d.ToUniversalTime());
            Console.WriteLine("D local: " + d.ToLocalTime());

            DateTime data = DateTime.Parse("1992-05-18T23:45:37Z");
            Console.WriteLine("\r\nISO 8601: " + data);
            Console.WriteLine("Data kind: " + data.Kind);
            Console.WriteLine("Data UTC: " + data.ToUniversalTime());
            Console.WriteLine("Data local: " + data.ToLocalTime());

            //Nova data para teste
            DateTime git = new DateTime(2019-12-27);
            Console.WriteLine("Data de modificação do GIT: " + git);




        }
    }
}
