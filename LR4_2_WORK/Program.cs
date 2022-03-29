using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_2_WORK
{
    public class StringHandler

    {

        public static string ChangeLastInclude(string str, char changing, char symbol)//посимвольная проверка

        {

            if (str == "") 

                return "";

            var arr = str.ToArray(); 

            for (int i = str.Length - 1; 

            i >= 0; 

            i--) 

            {

                if (arr[i] == changing) 

                {

                    arr[i] = symbol; break; 

                }

            }

            return new string(arr); 

        }

    }

    public class Program

    {

        static void Main(string[] args)

        {

        }

    }

}
