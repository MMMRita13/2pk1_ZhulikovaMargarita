using System;

namespace pz10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string text = "_qwertyuiopasdfghjklzxcvbnm";
            string text2 = "йцукенгшщзхъфывапролджэячсмитьбю";
            char[] chars = text.ToCharArray();
            char[] newstr = str.ToCharArray();
            char[] ch = text2.ToCharArray();

            bool isFind = false;
            bool isFind2 = false;
            bool isFind3 = false;
            bool isFind4 = false;


            for (int i = 0; i < chars.Length; i++)
            {
                if (!isFind2)
                {
                    if (newstr[0] == chars[i])
                    {
                        isFind = true;
                    }
                    else
                    {
                        isFind = false;
                    }
                    if (isFind)
                    {
                        isFind2 = true;
                    }
                }

            }

            for (int i = 1; i < ch.Length; i++)
            {
                if (!isFind4)
                {
                    if (str.Contains(ch[i]))
                    {
                        isFind3 = false;
                        isFind4 = true;
                    }
                    else
                    {
                        isFind3 = true;
                    }
                }



            }


            if (isFind && isFind3)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
        }
    }
}
