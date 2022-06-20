using System;

namespace ConsoleApp2
{
    internal class Program
    {
     static void Main(string[] args)
      {
         Console.WriteLine("Hello world!");
      }
    }
    public class Auto
    {
        public string Name ;
        public string Color { get; }
        int NRuote = 4 ;

        public int NumeroRuote()
        {
            return NRuote;   
        }

        public Auto(string colore)
        {
            Color = colore;
        }
    }
}   
