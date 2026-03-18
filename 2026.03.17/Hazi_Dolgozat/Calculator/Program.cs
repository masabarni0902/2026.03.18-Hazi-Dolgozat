namespace SimpleMathGame
{

    public class MiniCalculator
    {
        public int Dupla(int x)
        {
            return x * 2;
        }

        public int Negyzet(int x)
        {
            return x * x;
        }

        public int Fele(int x)
        {
            return x / 2;
        }

        public int Harmad(int x)
        {
            return x / 3;
        }

        public int SzorozdTizzel(int x)
        {
            return x * 10;
        }

        public int SzazadraOszdHaNemNulla(int x)
        {
            if (x == 0) return 0;
            return x / 100;
        }

        public int UtolsoSzamjegyNegyzet(int x)
        {
            int utolso = x % 10;
            return utolso * utolso;
        }

        public int ElsoKetSzamjegySzorzata(int x)
        {
            int elso = x / 10;           // 23 → 2
            int masodik = x % 10;           // 23 → 3
            return elso * masodik;
        }

        // több soros + if-else
        public int NagyobbikKetSzamjegySzorzata(int a, int b)
        {
            int nagyobb;

            if (a * a > b * b)
            {
                nagyobb = a;
            }
            else
            {
                nagyobb = b;
            }

            return nagyobb * nagyobb;
        }

        // több soros, kicsit bonyolultabb logika
        public int SzorozdBeHaParosEgyebkentFele(int x)
        {
            int eredmeny;

            if (x % 2 == 0)
            {
                eredmeny = x * 3;
            }
            else
            {
                eredmeny = x / 2;
            }

            return eredmeny;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
