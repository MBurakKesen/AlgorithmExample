using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgorithmExample
{
    public class DataTypes
    {
       public static void Main()
        {
            string x = "a";
            bool isTrue = Regex.IsMatch(x, x.ToLower());
        }
        public static byte seven(int x)
        {
            byte numb = (byte)x.GetTypeCode();
            return numb;

        }
        public static int six(int y)
        {
            int x = (y * y) + (2 * y) + 1;
            return x;
        }
        public static void five(int sayı1, int sayı2,string symbol)
        {
            switch (symbol)
            {
                case "-":
                    Console.WriteLine(sayı1 - sayı2);
                    break;
                case "+":
                    Console.WriteLine(sayı1 + sayı2);
                    break;
                case "/":
                    Console.WriteLine(sayı1 / sayı2);
                    break;
                case "*":
                    Console.WriteLine(sayı1 * sayı2);
                    break;
                default:
                    break;
            }
        }
        public static void four()
        {
            Console.WriteLine("yarı çap giriniz!!");
            int radius = Convert.ToInt32(Console.ReadLine());
            double calculate = 2 * Math.PI * radius;
            Console.WriteLine(calculate.ToString());
        }
        public static void three2()
        {
            string password, userId;
            int count = 0;
            int result = 0;
            do
            {
                Console.WriteLine("password gir");
                 password = Console.ReadLine();
                Console.WriteLine("user gir");
                 userId = Console.ReadLine();

                if (password=="password" && userId=="abc")
                {
                    result = 1;
                    count = 3;
                }
                else
                {
                    count++;
                    result = 0;
                }

            } while ((password != "password" || userId != "abc") && count!=3);
            if (result==0)
            {
                Console.WriteLine("deenem hakkı dolduruldu ");

            }
            else if(result==1)
            {
                Console.WriteLine("giriş başarılı!!");
            }
        }
        public static void two(string smb,int count)
        {
            for (int i = count; i >= 0; i--)
            {
                Console.WriteLine(smb);
                for (int j = i; j >=0 ; j--)
                {
                    
                    Console.Write(smb);
                }
            }
        }
        public static List<string> one(string s1,string s2,string s3)
        {
            List<string> list = new List<string>();
            list.Add(s3);
            list.Add(s2);
            list.Add(s1);

            return list;
        }
    }
}
