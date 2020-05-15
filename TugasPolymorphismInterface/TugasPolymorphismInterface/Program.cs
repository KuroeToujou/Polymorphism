using System;

namespace TugasPolymorphism
{
    public interface PrinterWindows
    {
        public string Name = "Printer Windows";
        public string Dimension = "9x10";
        public virtual void show()
        {
            Console.WriteLine(Name + " Display Dimension : " + Dimension);

        }
        public virtual void print()
        {
            Console.WriteLine(Name + " Printer Printing....");
        }
    }

    public class Epson : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Epson Display Dimension : 10x11");
        }

        public override void print()
        {
            Console.WriteLine("Epson Printer Printing");
        }

    }

    public class Canon : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Canon Display Dimension : 11x12");
        }

        public override void print()
        {
            Console.WriteLine("Canon Printer Printing");
        }

    }

    public class LaserJet : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("LaserJet Display Dimension : 12x12");
        }

        public override void print()
        {
            Console.WriteLine("LaserJet Printer Printing");
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Pilihlah Printer :\n");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");
            Console.WriteLine("Pilih Nomor Printer = ");

            int Pilihan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            PrinterWindows tampil = null;

            if (Pilihan == 1)
            {
                printer = new Epson();
            }

            else if (Pilihan == 2)
            {
                printer = new Canon();
            }

            else if (Pilihan == 3)
            {
                printer = new LaserJet();
            }

            else
            {
                Console.WriteLine("Selain itu tidak bisa :(");
            }

            printer.show();
            printer.print();
            Console.ReadKey();



        }

    }
}