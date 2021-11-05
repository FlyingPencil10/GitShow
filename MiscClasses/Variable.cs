using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiscClasses
{
    public class Variable
    {
        public static string Words
        {
            get
            {
                string words;
                words = "Hello";
                return words;
            }
        }

        public static int Numbers
        {
            get
            {
                int numbers=1;
                numbers++;
                return numbers;
            }
        }
    }
}
