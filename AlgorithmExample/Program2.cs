using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmExample
{
    internal class Program2
    {
        
     
        public static int asalBulucu(int n)
        {
            int ctr = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    ctr++;
                }
            }
            
            if (ctr>0)
            {
                n += 1;
                return asalBulucu(n);
            }
            else
            {
                return n;
            }
        }

        private static void ex90()
        {
            int[] array = { 1, 2, 3, -5, -29, 98 };
            int pozitifSayi = 0;
            int pozitifSayac = 0;

            int negatifSayi = 0;
            int negatifSayac = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                {
                    negatifSayac++;
                    negatifSayi += array[i];
                }
                else
                {
                    pozitifSayac++;
                    pozitifSayi += array[i];
                }
            }
            Console.WriteLine(pozitifSayac + " pozitif sayının toplamı: " + pozitifSayi);
            Console.WriteLine(negatifSayac + " negatif sayının toplamı: " + negatifSayi);
        }

        private static void ex89()
        {
            int cokKenarSayisi = 5;
            int icAcılarToplamı = (cokKenarSayisi - 2) * 180;
            Console.WriteLine(icAcılarToplamı);
        }

        private static void comparativeLetter()
        {
            string kelime = "keliMe";
            int ctr = 0;

            foreach (char item in kelime)
            {
                if (item.ToString() == item.ToString().ToUpper())
                {
                    ctr++;
                    continue;

                }
                else
                {
                    Console.WriteLine(ctr);
                    ctr++;
                }

            }
        }

        private static void inculuding()
        {
            string kelime = "merhaba dünya";
            char arastır = 'a';
            int sayac = 0;

            foreach (var item in kelime)
            {
                if (item == arastır)
                {
                    sayac++;
                }
            }
            Console.WriteLine(sayac);
        }

        private static void harfReplace()
        {
            string kelime = "patika";
            string[] dizi = { "P", "T", "S", "H", "A" };

            foreach (var item in dizi)
            {
                if (kelime.ToUpper().Contains(item))
                {
                    int sıra = kelime.ToUpper().LastIndexOf(item);
                    string harf = kelime.Substring(sıra, 1);
                    switch (harf.ToUpper())
                    {
                        case "P":

                            Console.WriteLine(kelime.Replace(harf, "1"));
                            break;
                        case "T":
                            Console.WriteLine(kelime.Replace(harf, "2"));
                            break;
                        case "S":
                            Console.WriteLine(kelime.Replace(harf, "3"));
                            break;
                        case "H":
                            Console.WriteLine(kelime.Replace(harf, "4"));
                            break;
                        case "A":
                            Console.WriteLine(kelime.Replace(harf, "5"));
                            break;
                        default:

                            break;
                    }
                }


            }
        }

        private static void getFileName()
        {
            string path = "C\\Users\\Burak's Pc\\Desktop\\File\\ToDo List.txt";
            int yol = path.LastIndexOf('\\');

            string kelime = path.Substring(yol + 1);

            Console.WriteLine(kelime);
        }

        public static int[] sırala(int[] dizi)
        {
            int[] s = dizi.Where(x => x != -5).OrderBy(x => x).ToArray();

            int ctr = 0;
            return dizi.Select(x => x >= 0 ? s[ctr++] : -5).ToArray();
        }

    }
}
