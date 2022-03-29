using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_2_WORK
{
    public class StringHandler

    {

        public static string ChangeLastInclude(string str, char changing, char symbol)//символьнная проверкf

        {

            if (str == "") //1

                return "";

            var arr = str.ToArray(); //3

            for (int i = str.Length - 1; //4

            i >= 0; //5

            i--) //6

            {

                if (arr[i] == changing) //7

                {

                    arr[i] = symbol; break; //8

                }

            }

            return new string(arr); //9

        }

    }

    public class Program

    {

        static void Main(string[] args)

        {

        }

    }

}
