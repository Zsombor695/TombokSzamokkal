namespace TombokSzamokkal
{
    internal class Program
    {
        static int[] tomb = new int[15];
        static Random r = new Random();
        static void Feltolt()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 21);
            }

            foreach (int item in tomb)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
        static void Osszegzes()
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine($"A tömb elemeinek összege: {osszeg}");
        }
        static void Megszamolas()
        {
            int db = 0;
            foreach (int item in tomb)
            {
                if (item < 0)
                {
                    db++;
                }
            }
            Console.WriteLine($"Negatív számok: {db}");
        }
        static void eldontes()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 0 a tömbben.");
            }
            else
            {
                Console.WriteLine("Nincs 0 a tömbben.");
            }

        }
        static void Main(string[] args)
        {
            Feltolt();
            Osszegzes();
            Megszamolas();
            eldontes();
        }
    }
}