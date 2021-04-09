// Nama : Hapsari Prabandhari
// NIU  : 20/456366/TK/50496
// UTS Pemrograman Berorientasi Objek 2020/2021

using System;

namespace OrderApp
{
    public abstract class total
    {
        int[] a;
        int[] b;
    }
    public class item : total
    {
        public static int countItem (ref int[] a)
        {
            int totalItem = 0;
            for(int i=0; i < a.Length; i++)
            {
                totalItem = totalItem + a[i];
            }
            return totalItem;
        }
    }
    public class price : total
    {
        public static int countPrice (ref int[] a, ref int[] b)
        {
            int totalPrice = 0;
            for(int i=0; i < a.Length; i++)
            {
                totalPrice = totalPrice + a[i] * b[i];
            }
            return totalPrice;
        }
    }
    public class Order
    {
        public static int[] finalItem = {0,0,0,0,0,0};
        public static int[] foodPrice = {8000,10000,10000,12000,12000,14000};
        static void Main(string[] args)
        {
            Console.WriteLine("\nAplikasi Untuk Memesan Makanan");
            Console.WriteLine("\n==================================================");
            Console.WriteLine("               RUMAH MAKAN NASI GUDEG             ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Nasi Gudeg                            Rp  8.000");
            Console.WriteLine("2. Nasi Gudeg + Sambal Goreng            Rp 10.000");
            Console.WriteLine("3. Nasi Gudeg + Telur                    Rp 10.000");
            Console.WriteLine("4. Nasi Gudeg + Telur + Sambal Goreng    Rp 12.000");
            Console.WriteLine("5. Nasi Liwet + Ayam                     Rp 12.000");
            Console.WriteLine("6. Nasi Liwet + Ayam + Sambal Goreng     Rp 14.000");
            Console.WriteLine("==================================================\n");
            
            int m1 = 0;
            int m2 = 0;
            int m3 = 0;
            int m4 = 0;
            int m5 = 0;
            int m6 = 0;
            int choose;
            char decision;

            var customer = new Customer();
            Console.Write("Masukkan nama Anda : ");
            customer.name = Console.ReadLine();
            do
            {
                Console.Write("Masukkan pesanan Anda (nomor menu) : ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                    Console.Write("Masukkan jumlah pesanan : ");
                    m1 = Convert.ToInt32(Console.ReadLine());
                    finalItem[0] = finalItem[0] + m1;
                    break;
                    
                    case 2:
                    Console.Write("Masukkan jumlah pesanan : ");
                    m2 = Convert.ToInt32(Console.ReadLine());
                    finalItem[1] = finalItem[1] + m2;
                    break;

                    case 3:
                    Console.Write("Masukkan jumlah pesanan : ");
                    m3 = Convert.ToInt32(Console.ReadLine());
                    finalItem[2] = finalItem[2] + m3;
                    break;

                    case 4:
                    Console.Write("Masukkan jumlah pesanan : ");
                    m4 = Convert.ToInt32(Console.ReadLine());
                    finalItem[3] = finalItem[3] + m4;
                    break;

                    case 5:
                    Console.Write("Masukkan jumlah pesanan : ");
                    m5 = Convert.ToInt32(Console.ReadLine());
                    finalItem[4] = finalItem[4] + m5;
                    break;

                    case 6:
                    Console.Write("Masukkan jumlah pesanan : ");
                    m6 = Convert.ToInt32(Console.ReadLine());
                    finalItem[5] = finalItem[5] + m6;
                    break;
                }
                Console.Write("Ingin menambah pesanan? (Y/N) ");
                decision = Convert.ToChar(Console.ReadLine());
            }
            while (decision != 'n' && decision != 'N');

            customer.totalOrder = item.countItem (ref finalItem);
            customer.bill = price.countPrice (ref finalItem, ref foodPrice);

            Console.WriteLine("\n==================================================");
            Console.WriteLine("                    NOTA PESANAN                  ");
            Console.WriteLine("==================================================");
            Console.WriteLine("Pesanan atas nama : " + customer.name);
            Console.WriteLine("Jumlah pesanan    : " + customer.totalOrder);
            Console.WriteLine("Harga total       : " + customer.bill);
            Console.WriteLine("==================================================");
            Console.WriteLine("                 SELAMAT MENIKMATI                ");
            Console.WriteLine("==================================================\n");
        }
    }
}
