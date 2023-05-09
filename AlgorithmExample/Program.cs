//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;


//namespace AlgorithmExample
//{
//    internal static class Program
//    {
//        public static void Main()
//        {

//        }
//        private static void neededNumber()
//        {
//            int[] dizi = { 1, 3, 4, 7, 9 };
//            int max = dizi.Max();
//            int ctr = 0;
//            for (int i = dizi.Min(); i <= max; i++)
//            {
//                if (dizi.Contains(i))
//                {
//                    ctr++;
//                    continue;
//                }
//                Console.WriteLine("needed: " + i);
//            }
//        }

//        private static void polindromDedector()
//        {
//            int ctr = 0;
//            string kelime1 = Console.ReadLine();
//            string kelime2 = Console.ReadLine();
//            for (int i = 0; i <= kelime1.Length - 1; i++)
//            {
//                if (kelime1[i] == kelime1[kelime1.Length - 1])
//                {
//                    ctr += 0;
//                }
//                else
//                {
//                    ctr++;
//                }
//            }
//            if (ctr == 0)
//            {
//                Console.WriteLine("polindrom sayı");
//            }
//            else
//            {
//                Console.WriteLine("polindirom değil");
//            }
//        }

//        private static void tousandYearFaunder()
//        {
//            int yıl = Convert.ToInt32(Console.ReadLine());
//            int yuzyıl = (yıl / 100) + 1;
//            Console.WriteLine(yuzyıl);
//        }

//        private static void oddNumberFounder()
//        {
//            int[] dizi = { 2, 4, 7, 8, 6 };
//            int ctr = 0;
//            for (int i = 0; i < dizi.Length; i++)
//            {
//                if (dizi[i] % 2 == 1)
//                {
//                    ctr++;
//                }
//            }
//            if (ctr > 0)
//            {
//                Console.WriteLine("true");
//            }
//        }

//        private static void NewMethod1()
//        {
//            int[] dizi = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
//            if (dizi.Length == 1 || dizi[0] == dizi[dizi.Length - 1])
//            {
//                Console.WriteLine("true");
//            }
//            else
//            {
//                Console.WriteLine("false");
//            }
//        }

//        private static void summer()
//        {
//            int[] dizi = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
//            Console.WriteLine(dizi.Sum());
//        }

//        private static void NewMethod()
//        {
//            int sayı = 0;
//            int[] dizi = { 0, 1, 2, 3, 4, 0 };
//            if (dizi[0] == sayı || dizi[dizi.Length - 1] == sayı)
//            {
//                Console.WriteLine("true");
//            }
//            else
//            {
//                Console.WriteLine("false");
//            }
//        }

//        private static void arrayCounter()
//        {
//            Console.WriteLine("öğrenmek istediğiniz sayı girin");
//            int sayı = Convert.ToInt32(Console.ReadLine());
//            int[] array = { 1, 2, 3, 4, 5, 1, 1, 1, 1 };
//            int ctr = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] == sayı)
//                {
//                    ctr++;
//                }
//            }
//            Console.WriteLine("bu elemandan dizide: " + ctr + " kadar var");
//        }

//        private static void caseUpper()
//        {
//            string cumle = Console.ReadLine();


//            if (cumle.Length <= 4)
//            {
//                string buyuk = cumle.ToUpper();
//                Console.WriteLine(buyuk);

//            }
//            else
//            {
//                string kelime = cumle.Substring(0, 4);
//                string buyuk = kelime.ToUpper();
//                Console.WriteLine(buyuk);
//            }
//        }

//        private static void wCounter()
//        {
//            Console.WriteLine("İng cümle girinzi");
//            string cumle = Console.ReadLine();
//            string[] array = cumle.Split(new[] { 'w' }, StringSplitOptions.None);
//            if (1 <= array.Length - 1 && array.Length - 1 < 4)
//            {
//                Console.WriteLine("true");
//            }
//            else
//            {

//                Console.WriteLine("fasle");
//            }
//        }

//        private static void whoIsMoreCloser()
//        {
//            int sayı1 = Convert.ToInt32(Console.ReadLine());
//            int sayı2 = Convert.ToInt32(Console.ReadLine());

//            int mesafe1 = Math.Abs(sayı1 - 20);
//            int mesafe2 = Math.Abs(sayı2 - 20);
//            if (mesafe1 > mesafe2)
//            {
//                Console.WriteLine("daha yakın olan " + sayı2);
//            }
//            else if (sayı1 == sayı2 || mesafe1 == mesafe2)
//            {
//                Console.WriteLine("aynı uzaklık");
//            }
//            else
//            {
//                Console.WriteLine("daha yakın olan " + sayı1);
//            }
//        }

//        private static void whoBiggestAndSmallest()
//        {
//            Console.WriteLine("3 sayı giriniz");
//            int sayı1 = Convert.ToInt32(Console.ReadLine());
//            int sayı2 = Convert.ToInt32(Console.ReadLine());
//            int sayı3 = Convert.ToInt32(Console.ReadLine());
//            int kim = Math.Max(sayı3, sayı2);
//            int Max = Math.Max(sayı1, kim);

//            int mini = Math.Min(sayı3, sayı2);
//            int Min = Math.Min(sayı1, mini);


//            Console.WriteLine("the biggest one " + Max);
//            Console.WriteLine("the smallest one " + Min);
//        }

//        private static void hpDetecter()
//        {
//            string cumle = "PHP Tutorial";
//            string ctr = cumle.Substring(1, 2);

//            if (ctr == "HP")
//            {
//                string silik = cumle.Remove(1, 2);
//                Console.WriteLine(silik);
//            }
//            else { Console.WriteLine(cumle); }
//        }

//        private static void gratherThenIf()
//        {
//            Console.WriteLine("iki sayı girinzi");
//            int sayı1 = Convert.ToInt32(Console.ReadLine());
//            int sayı2 = Convert.ToInt32(Console.ReadLine());

//            if (sayı1 < 100 || sayı2 < 100)
//            {
//                if (sayı1 > 200 || sayı2 > 200)
//                {
//                    Console.WriteLine("true");
//                }
//                else
//                {
//                    Console.WriteLine("false");
//                }
//            }
//            else if (sayı1 > 200 || sayı2 > 200)
//            {
//                if (sayı1 < 100 || sayı2 < 100)
//                {
//                    Console.WriteLine("true");
//                }
//                else
//                {
//                    Console.WriteLine("false");
//                }
//            }
//        }

//        private static void startWithMethod()
//        {
//            Console.WriteLine("lüfen cümle giriniz");
//            string cumle = Console.ReadLine();
//            Console.WriteLine("kontrol ü yapılacak kelime girin");
//            string kelime = Console.ReadLine();
//            if (cumle.StartsWith(kelime) == true)
//            {
//                Console.WriteLine("true");
//            }
//            else
//            {
//                Console.WriteLine("false");
//            }
//        }

//        private static void find3or5Multiply()
//        {
//            Console.WriteLine("bir sayı giriniz");
//            int sayı = Console.Read();

//            if (sayı % 3 == 0 || sayı % 7 == 0)
//            {
//                Console.WriteLine("true");
//            }
//            else
//            {
//                Console.WriteLine("false");
//            }
//        }

//        private static void wordMaker()
//        {
//            Console.WriteLine("lütfen bir cümle giriniz");
//            string cumle1 = Console.ReadLine();

//            string newKelime = cumle1.Substring(cumle1.Length - 4);
//            for (int i = 0; i < 4; i++)
//            {
//                Console.WriteLine(newKelime);
//            }
//        }

//        private static void multiplyAganistArray()
//        {
//            int[] Array1 = { 1, 3, -5, 4 };
//            int[] Array2 = { 1, 4, -5, -2 };

//            for (int i = 0; i <= Array1.Length - 1; i++)
//            {
//                int sayı = Array2[i] * Array1[i];
//                Console.WriteLine(sayı);
//            }
//        }

//        private static void hexadToDecimal()
//        {
//            Console.WriteLine("hexadecimal sayı giriniz");
//            string sayı = Console.ReadLine();

//            int decimalSayı = Convert.ToInt32(sayı, 16);
//            Console.WriteLine(decimalSayı + " :sayınız");
//        }

//        private static void getFileSize()
//        {
//            Console.WriteLine("lütfen bir dosya yolu girnizi");
//            string yol = Console.ReadLine();
//            string path = yol;
//            long length = new FileInfo(path).Length;
//            Console.WriteLine(length);
//        }

//        private static void reverseSentec()
//        {
//            Console.WriteLine("lütfen bir cümle girinzi");
//            string cumle = Console.ReadLine();

//            string[] array = cumle.Split(' ');
//            for (int i = array.Length - 1; i >= 0; i--)
//            {
//                Console.Write(array[i] + " ");
//            }
//        }

//        private static void sumOfDigits()
//        {
//            Console.WriteLine("lütfen bir sayı giriniz");
//            string sayı = Console.ReadLine();
//            int sayı1 = int.Parse(sayı);
//            int sum = 0;
//            while (sayı1 != 0)
//            {
//                sum += sayı1 % 10;
//                sayı1 /= 10;
//            }
//            Console.WriteLine(sum);
//        }

//        private static void primeCounter()
//        {
//            int sayac = 0;
//            int ctr = 0;
//            int toplam = 0;
//            while (sayac <= 501)
//            {
//                if (ısItPrime(ctr) == true)
//                {
//                    toplam += ctr;
//                    ctr++;
//                    sayac++;
//                }
//                else
//                {
//                    ctr++;
//                }

//            }
//            Console.WriteLine(toplam);
//        }

//        private static bool ısItPrime(int sayi)
//        {
//            int kontrol = 0;
            
//            for (int i = 2; i < sayi; i++)
//            {
//                if (sayi % i == 0)
//                    kontrol++;
//            }

//            if (kontrol != 0)
//               return false;
//            else
//                return true;
          
//        }

//        private static void singleNum()
//        {
//            for (int i = 1; i < 99; i++)
//            {
//                if (i % 2 != 0)
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }

//        private static void whoIsBiggest()
//        {
//            Console.WriteLine("lütfen bir cümle yazınız");
//            string cumle = Console.ReadLine();
//            string[] array = cumle.Split(new[] { " " }, StringSplitOptions.None);

//            string biggest = "";
//            int count = 0;

//            foreach (var item in array)
//            {
//                if (item.Length > count)
//                {
//                    biggest = item;
//                    count = item.Length;
//                }
//            }
//            Console.WriteLine(biggest);
//        }

//        private static Boolean find20(int num1,int num2)
//        {
//            if ((num1 == 20 ||  num2==20) || num1+num2==20)
//            {
//                return true;
//            }
//            return false;
//        }

//        public static Boolean FindNegative(int number1, int number2)
//        {
//            if (number1>0 || number2>0)
//            {
//                return true;
//            }
//            return false;
//        }

//        private static void addFirstChar()
//        {
//            Console.WriteLine("cümleyi giriniz");

//            string cumle = Console.ReadLine();

//            char ilk = cumle[0];

//            Console.WriteLine(ilk + cumle + ilk);
//        }

//        private static void replaceFaLIndex()
//        {
//            Console.WriteLine("kelimenizi giriniz");
//            string kelime = Console.ReadLine();
//            char harf1 = kelime[0];
//            kelime.Remove(0, 1);
//            char harf2 = kelime[kelime.Length - 1];
//            string silik = kelime.Remove(kelime.Length - 1, 1);
//            string bas = harf2 + silik.Remove(0, 1) + harf1;
//            Console.WriteLine(bas);
//        }

//        private static void allIndexRemove()
//        {
//            Console.WriteLine("lütfen kelimeyi giriniz");
//            string kelime = Console.ReadLine();

//            Console.WriteLine("silinecek harf giriniz");
//            string index = Console.ReadLine();

//            int indexi = kelime.IndexOf(index, 0, 1);

//            //int indexi =int.Parse(index);

//            //string harf=kelime.Substring(indexi, indexi+2);

//            for (int i = 0; i < kelime.Length; i++)
//            {
//                if (kelime[i] == kelime[indexi])
//                {
//                    continue;
//                }
//                Console.Write(kelime[i]);
//            }
//        }
//        static void calculater()
//        {
//            while (true) { 
//            Console.WriteLine("işlemtürünü seçiniz");
//            Console.WriteLine("çarpma:1");
//            Console.WriteLine("toplama:2");
//            Console.WriteLine("çıkarma:3");
//            Console.WriteLine("bölme:4");
//            string giris = Console.ReadLine();
//            int islem = int.Parse(giris);

//            switch (islem)
//            {
//                case 1:
//                    Multiply();
//                    break;
//                case 2:
//                    Console.WriteLine("lütfen sayı giriniz");

//                    string sayı1=Console.ReadLine();
//                    string sayı2 = Console.ReadLine();

//                    int toplam = sum(int.Parse(sayı1), int.Parse(sayı2));

//                    Console.WriteLine(toplam);
//                    break;
//                case 3:
//                    Console.WriteLine("lütfen sayı giriniz");

//                    string sayı3 = Console.ReadLine();
//                    string sayı4 = Console.ReadLine();

//                    int cıkarma = cık(int.Parse(sayı3), int.Parse(sayı4));

//                    Console.WriteLine(cıkarma); 
//                    break;
//                case 4:
//                    Console.WriteLine("lütfen sayı giriniz");

//                    string sayı5 = Console.ReadLine();
//                    string sayı6 = Console.ReadLine();

//                    int div = dividing(int.Parse(sayı5), int.Parse(sayı6));

//                    Console.WriteLine(div);

//                    break;
//                default: 
//                    Console.WriteLine("yanlış işlem");
//                    break;
//            }
//        }
//        }
//        private static void Multiply()
//        {
//            Console.WriteLine("çarpılacak ilk sayıyı giriniz");
//            string sayı1 = Console.ReadLine();
//            int Ysayı1 = Int32.Parse(sayı1);
//            Console.WriteLine("ikinci sayıyı girin");
//            string sayı2 = Console.ReadLine();
//            int Ysayı2 = Int32.Parse(sayı2);
//            Console.WriteLine("sonuncu sayıyı girin");
//            string sayı3 = Console.ReadLine();
//            int Ysayı3 = Int32.Parse(sayı3);

//            Console.WriteLine(Ysayı1 * Ysayı2 * Ysayı3);
//        }
//        private static void swapToNumbers()
//        {
//            int sayı1 = 0;
//            int sayı2 = 10;

//            int[] temp = new int[1];
//            temp[0] = sayı1;
//            sayı2 = sayı1;
//            Console.WriteLine("yeni 2.sayı " + sayı2);
//            sayı1 = temp[0];
//            Console.WriteLine("yeni 1.sayı" + sayı1);
//        }
//        private static int dividing(int sayı1, int sayı2)
//        {
//            return sayı1 / sayı2;
//        }
//        private static int sum(int sayı1,int sayı2)
//        {
//            return sayı1 + sayı2;
//        }
//        private static int cık(int sayı3, int sayı4)
//        {
//            return sayı3 - sayı4;
//        }
//        private static void Basic1()
//        {
//            Console.WriteLine("lütfen adınızı giriniz");
//            string name = Console.ReadLine();
//            Console.WriteLine("hello: " + name);
//            Console.ReadLine();
//        }
//    }
//}
