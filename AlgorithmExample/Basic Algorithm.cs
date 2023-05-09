using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmExample
{
    public class Basic_Algorithm
    {
        //public static void Main()
        //{
        //    int[] ints = { 1, 2, 3, 4, 5, 6, 8 };
        //    int c = ints.Max() - ints.Min();
        //    Console.WriteLine(c);

        //}
        private static int[] onehounderedsix(int[] dizi)
        {
            int mid = dizi.Length / 2;
            return new int[] { dizi[mid - 1], dizi[mid], dizi[mid + 1] };
        }
        private static int[] onehounderedfive(int[] dizi)
        {
            int[] a=new int[dizi.Length];
            a[0] = dizi[dizi.Length - 1];
            for (int i = 1; i < dizi.Length; i++)
            {
                a[i] = dizi[i];

            }
            a[a.Length - 1] = dizi[0];
            return a;
             
        }
        private static int[] onehounderedone(int[] dizi)
        
        {
            if (dizi.Length == 3)
            {
                for (int i = 0; i < dizi.Length-1; i++)
                {
                    if (dizi[i] == 5)
                    {
                        dizi[i + 1] = 1;
                        return dizi;
                    }

                }

            }
            return dizi;
        }
        private static void onehondered()
        {
            int[] dizi = { 10, 20, 30, 10 };
            for (int i = dizi.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (dizi[i] == dizi[j])
                    {
                        Console.WriteLine("true");
                        break;
                    }
                }

            }
        }

        private static int[] nintynine(int[] dizi)
        {
            int[] a = new int[dizi.Length * 2];
            for (int i = 0; i < a.Length; i++)
            {
                if (i==0)
                {
                    a[i] = dizi[0];
                }
                else
                {
                    a[i] = 1;
                }
            }
            return a;
        }
        private static int[] nintyfour(int[] dizi)
        {
            int ctr = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > ctr)
                {
                    ctr = dizi[i];
                }
            }
            int[] temp = new int[dizi.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = ctr;
            }
            return temp;
        }
        private static int[] nintythree(int[] dizi)
        {
            int[] d = new int[dizi.Length];
            int count = dizi.Length - 1;
            for (int i = 0; i < dizi.Length; i++)
            {
                d[i] = dizi[count];
                count--;
            }
            return d;
        }
        private static int[] nintytwo(int[] dizi)
        {
            return new int[] { dizi[1], dizi[2], dizi[3], dizi[0]};
        }
        private static int nintyone(int[] dizi)
        {
            int n = 0;
            for (int i = 0; i <= dizi.Length-1; i++)
            {
                n += dizi[i];
            }
            return n;
        }
        private static bool ninty(int[] dizi1, int[] dizi2)
        {
            return dizi1[0] == dizi2[0] ? true : dizi1[dizi1.Length - 1] == dizi2[dizi2.Length] ? true : false;
        }
        private static string eightyseven(string x)
        {
            return (x[0].ToString() == "a" || x[0].ToString() == "A") && (x[1].ToString() == "a" || x[1].ToString() == "A") ? x.Substring(2):x[0].ToString() == "a" || x[0].ToString() == "A"?x.Substring(1): x[1].ToString() == "a" || x[1].ToString() == "A" ? x[0]+x.Substring(2):x;
        }
        private static string eighttysix(string x)
        {
            return x[0].ToString() == "a" || x[0].ToString() == "A"|| x[x.Length-1].ToString() == "a" || x[x.Length-1].ToString() == "A"?x=x.Substring(1,x.Length-2):x;
        }
        private static string eightfive(string x)
        {
            string y =string.Empty;
            if (x[0].ToString()=="x"|| x[0].ToString() == "X")
            {
                x= x.Substring(1);
                if (x[0].ToString() == "y" || x[0].ToString() == "Y")
                {
                   return x = x.Substring(1);
                }
            }
            if (x[1].ToString()=="y" || x[1].ToString() == "Y")
            {
                 return x[0]+x.Substring(2);
            }
            return x;
        }
        private static string eightyone(string x, string y)
        {
            return x.Length > y.Length ? y + x.Substring(x.Length - y.Length) :  x+ y.Substring(y.Length - x.Length);
            return x + y;
        }
        private static string seventyeigth(string x,string y)
        {
            string value=string.Empty;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == y[0])
                {
                    return value += x.Substring(0, i) + y + x.Substring(i);
                }
            }
            return "no match";
        }
        private static string seventysix(string x)
        {
            return x.Length > 2 ? x.Substring(0, 2) : x.Length == 1 ? x + "#" :"##" ;

        }
        private static string seventythree(string x,int y)
        {
            return x.Substring(0, y) + x.Substring(x.Length - y);
        }
        private static string seventyone(string x)
        {
            return x.Substring(x.Length/2, 2);
        }
        private static string sixtyseven(string x,string y)
        {
            string value = x + y;
            return value.Substring(1, value.Length - 2);
        }
        private static string sixtyone(string x,string y)
        {
            int uzunluk = x.Length / 2;
            string kelime = string.Empty;
            for (int i = 0; i < uzunluk; i++)
            {
                 kelime+= x[i];
            }
            kelime += y;
            for (int i = uzunluk; i <x.Length; i++)
            {
                kelime += x[i];
            }
            return kelime;
        }
        private static bool fiftynine(int x,int y, int z)
        {
            return (Math.Abs(x - y) == Math.Abs(z - y)) ? true : false;
        }
        private static int fiftyeight(int x,int y)
        {
            return (x - 13 >= 0) && (y - 13 >= 0) ? 0 : x - y > 0 ? x : y;
        }
        private static int fiftyseven(int x,int y,int z)
        {
                if ((x!=13 && x!=17) && (x >=10 && x<=20))
                {
                    x = 0;

                }
                if ((y!= 13 && y!= 17) && (y >=10 && y <= 20))
                {
                    y = 0;
                }
                if ((z!=13 && z!=17) && (z >=10 && z <= 20))

                {
                    z = 0;

                }
                return x + y + z;
         

        }
        private static int fiftyfive(int x,int y,int z)
        {
            return (x == y) || (y==z) ||(x==z)? z : x + y + z;
        }
        private static int fiftyfour(int x,int y)
        {
           
            if ((x + y) - 9 >= 1)
            {
                return x;
            }
            else
            {
                return x + y;

            }
        }
        private static void thirtyeight()
        {
            int[] dizi = { 1, 2, 3, 5, 6, 6, 4, 3, 5, 5, 5, 6 };
            int sayac = 0;
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                if (dizi[i].Equals(5))
                {
                    if (dizi[i + 1] == 5 || dizi[i + 1] == 6)
                    {
                        sayac++;
                    }
                }

            }
            Console.WriteLine(sayac);
        }
        public static bool thirtyfour(int[] dizi)
        {
          
            for (int i = 0; i < dizi.Length - 2; i++)
            {
                if (dizi[i] == 1 && dizi[i + 1] == 2 && dizi[i + 2] == 3)
                {
                    return true;
                }
            }
            return false;

        }
        public static string twentysix(string value, int value2)
        {
            string result = String.Empty;
            for (int i = 0; i < value2; i++)
            {
                result += value.Substring(0,3);
            }
            return result;
        }
        private static void twentyfive()
        {
            string kelime = "power is the weakness";
            string buyuk = kelime.Substring(kelime.Length - 3).ToUpper();

            Console.WriteLine(kelime.Remove(kelime.Length - 3) + buyuk);
        }
        public static int twentyfour(int value)
        {
            return value %= 10;
        
        }
        private static void twentytree()
        {
            string kelime = "merhazza";

            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime.Substring(i, 1).Equals("z"))
                {
                    if (kelime.Substring(i + 1, 1).Equals("z"))
                    {
                        Console.WriteLine("true");
                    }
                }

            }
        }
        private static void twentytwo()
        {
            int sayı1 = 22;
            int sayı2 = 27;

            if ((sayı1 > 20 && sayı1 < 30) && (sayı2 > 20 && sayı2 < 30))
            {
                if (sayı1 > sayı2)
                {
                    Console.WriteLine(sayı1);
                }
                else
                {
                    Console.WriteLine(sayı2);
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        private static void nine()
        {
            string kelime = "me";
            int uzunluk = kelime.Length;
            if (uzunluk <= 2)
            {
                Console.WriteLine(kelime);
                Console.WriteLine(kelime);
                Console.WriteLine(kelime);
                Console.WriteLine(kelime);
            }
            else
            {
                string uzun = kelime.Substring(kelime.Length - 2, 1) + kelime + kelime.Substring(kelime.Length - 2, 1);
                Console.WriteLine(uzun);
            }
        }
        private static void eigth()
        {
            string kelime = "ici babaici";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(kelime.Substring(0, 2));
            }
        }
        private static void seven()
        {
            int index = 0;
            string kelime = "kelime";
            string silinmis = kelime.Remove(index, 1);
            Console.WriteLine(silinmis);
        }
        private static void five()
        {
            string kelime = "ifselam";
            bool ctr = kelime.StartsWith("if");
            if (ctr)
            {
                string removed = kelime.Remove(0, 2);
                Console.WriteLine(removed);
            }
            else
            {
                Console.WriteLine("if" + kelime);
            }
        }
        private static void three()
        {
            int sayı = 10;
            int sayı2 = 50;

            if ((sayı + sayı2 == 30) || (sayı == 30 || sayı2 == 30))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
