using System;

namespace рz_20
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] massiv = s.ToCharArray();
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = char.IsLower(massiv[i]) ? char.ToUpper(massiv[i]) : char.ToLower(massiv[i]);

            }
            Console.WriteLine(massiv);
        }
     }
}
