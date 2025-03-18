namespace _3_OOP_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance Alma Işlemi: 
            Car araba1 = new Car();
            araba1.Brand = "BMW";
            araba1.Model = "I3";
            araba1.Engine = 1600;

            // Constructor çalışır
            Car araba2 = new Car("BMW","araba");
            araba2.Model = "I5";
            araba2.Engine = 2000;

            Car araba3 = new Car("Audi", "Q3", 2400);
            Car araba4 = new Car();
            araba2.Color = 5;
        }
    }
}
