using System;

namespace punyagweh
{
    class Processor
    {
        public string Merk { get; set; }
        public string Tipe { get; set; }

        public Processor(string merk, string tipe)
        {
            Merk = merk;
            Tipe = tipe;
        }
    }

    class INTEL : Processor
    {
        public INTEL(string tipe) : base("INTEL", tipe) 
        {
        
        }
    }

    class Corei3 : INTEL
    {
        public Corei3() : base("Core i3")
        {

        }
    }

    class Corei5 : INTEL
    {
        public Corei5() : base("Core i5")
        {

        }
    }

    class Corei7 : INTEL
    {
        public Corei7() : base("Core i7")
        {

        }
    }

    class AMD : Processor
    {
        public AMD(string tipe) : base("AMD", tipe)
        {

        }
    }

    class Ryzen : AMD
    {
        public Ryzen() : base("RYZEN")
        {

        }
    }

    class Athlon : AMD
    {
        public Athlon() : base("ATHLON")
        {

        }
    }

    class Vga
    {
        public string Merk { get; set; }

        public Vga(string merk)
        {
            Merk = merk;
        }
    }

    class Nvidia : Vga
    {
        public Nvidia() : base("Nvidia")
        {

        }
    }

    class amd2 : Vga
    {
        public amd2() : base("AMD")
        {

        }
    }


    class Laptop
    {
        public string Merk { get; set; }
        public string Tipe { get; set; }
        public Vga Vga { get; set; }
        public Processor Processor { get; set; }

        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            Merk = merk;
            Tipe = tipe;
            Vga = vga;
            Processor = processor;
        }

        public void Displayspesifik()
        {
            Console.WriteLine("SPESIFIKASI LAPTOP:");
            Console.WriteLine($"Merk: {Merk}");
            Console.WriteLine($"Tipe: {Tipe}");
            Console.WriteLine($"VGA: {Vga.Merk}");
            Console.WriteLine($"Merk Processor: {Processor.Merk}");
            Console.WriteLine($"Tipe Processor: {Processor.Tipe}");
        }
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} mati");
        }


    }

    class ASUS : Laptop
    {
        public ASUS(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
        {

        }
    }

    class ROG : ASUS
    {
        public ROG(Vga vga, Processor processor) : base("ROG", vga, processor)
        {

        }
    }

    class Vivobook : ASUS
    {
        public Vivobook(Vga vga, Processor processor) : base("Vivobook", vga, processor)
        {

        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ACER : Laptop
    {
        public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
        {

        }
    }

    class Swift : ACER
    {
        public Swift(Vga vga, Processor processor) : base("Swift", vga, processor)
        {

        }
    }

    class Predator : ACER
    {
        public Predator(Vga vga, Processor processor) : base("Predator", vga, processor)
        {

        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
        }
    }

    class LENOVO : Laptop
    {
        public LENOVO(string tipe, Vga vga, Processor processor) : base("LENOVO", tipe, vga, processor)
        {

        }
    }

    class IdeaPad : LENOVO
    {
        public IdeaPad(Vga vga, Processor processor) : base("IdeaPad", vga, processor)
        {

        }
    }

    class Legion : LENOVO
    {
        public Legion(Vga vga, Processor processor) : base("Legion", vga, processor)
        {

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1, laptop2;
            Predator predator;
            ACER acer;

            laptop1 = new Vivobook(new Nvidia(), new Corei5());
            laptop2 = new IdeaPad(new amd2(), new Ryzen());
            predator = new Predator(new amd2(), new Corei7());

            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            laptop1.Ngoding();
            laptop1.Displayspesifik();
            predator.BermainGame();

            acer = new Predator(new amd2(), new Corei7());
            acer.BermainGame(); 
        }
    }
}

