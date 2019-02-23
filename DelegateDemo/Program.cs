using System;


    class Program
    {
        delegate void mathfunc(); //creating a template for a method call, type for a method, treat methods more like data

        static void Main(string[] args)
        {
            mathfunc method;


            mathfunc[] mets = { Print, Write, Calc };
            foreach (var i in mets)
            {
                i();
            }
        }

        static void Print()
        {
            Console.WriteLine("Print");
        }

        static void Write()
        {
            Console.WriteLine("Write");
        }

        static void Calc()
        {
            Console.WriteLine("Calc");
        }
    }


