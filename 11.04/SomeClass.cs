using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._04
{
    internal class SomeClass
    {
        public int code;

        public SomeClass(int n)
            { code = n; }
            // нестатический метод с двумя переменными
            public char GetChar(int k, string txt)
            {
                return (char)(txt[k] + code);
            }
            //статический метод с двумя аргументами
            public static char GetFirst(int k, string txt)
            {
                return txt[k];
            }
        }
    }
