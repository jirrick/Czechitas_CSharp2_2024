namespace Lekce1_Opakovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vitejte na kurzu C# 2!");
            Console.WriteLine("Bude to jizda!");
            
            Kalkulacka kalkulacka1 = new Kalkulacka();
            kalkulacka1.Cislo1 = 1;
            kalkulacka1.Cislo2 = 2;
            Console.WriteLine(kalkulacka1.Secti());

            Kalkulacka kalkulacka2 = new Kalkulacka(3, 7);
            Console.WriteLine(kalkulacka2.Secti());

            Console.WriteLine(Kalkulacka.SectiStaticky(2, 4));
        }

        
    }
    public class Kalkulacka
    {
        public int Cislo1;
        public int Cislo2;

        public Kalkulacka()
        {

        }

        public Kalkulacka(int cislo1, int cislo2)
        {
            Cislo1 = cislo1;
            Cislo2 = cislo2;
        }

        public int Secti()
        {
            return Cislo1 + Cislo2;
        }

        public static int SectiStaticky(int cislo1, int cislo2)
        {
            return cislo1 + cislo2;
        }
    }
}
