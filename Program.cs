using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nhap vao mang so nguyen gom n phan tu.
            //xuat mang vua nhap.
            Console.Write("Nhap so luong phan tu n = ");
            int n = int.Parse(Console.ReadLine());

            int[] mangSoNguen = new int[n]; //tao ra mang gom n phan tu

            //khai bao gia tri cho phan tu
            for (int i = 0; i < mangSoNguen.Length; i++)
            {
                Console.Write("Nhap phan tu thu {0} = ", i);
                mangSoNguen[i] = int.Parse(Console.ReadLine());
            }

            //xuat mang
            Console.WriteLine("Chay voi foreach");
            foreach (var item in mangSoNguen)
            {
                Console.Write("{0}\t", item);
            }

            //tinh tong mang
            Console.WriteLine();
            //int tongMang = 0;
            //foreach (var item in mangSoNguen)
            //{
            //    tongMang += item;
            //}
            //Console.WriteLine("Tong mang vua nhap = {0}", tongMang);
            Console.WriteLine("Tong mang vua nhap = {0}", mangSoNguen.Sum());

            //kiem tra so 5 co trong mang hay khong?
            string ketqua = "So 5 khong co trong mang";
            int diemLap = 0;
            for (int i = 0; i < mangSoNguen.Length; i++)
            {
                if (mangSoNguen[i] == 5)
                {
                    diemLap++;
                    ketqua = "So 5 co trong mang";
                }
            }
            Console.WriteLine("{0}", ketqua);



            Predicate<int> predicate = (int number) =>
            {
                //viet code xu ly
                //return number % 2 == 0; //return true or false
                return number == 5; //return number
            };

            int[] result = Array.FindAll(mangSoNguen, predicate);

            if (result.Length > 0)
            {
                Console.WriteLine("Co so 5 va lap lai {0}", result.Length);
            }
            else
            {
                Console.WriteLine("Khong co so 5");
            }

            //tim ra phan tu nho nhat trong mang
            Console.WriteLine("Gia tri nho nhat la {0}", mangSoNguen.Min());
            int min = mangSoNguen[0];
            //phan tu 0 = 3
            //phan tu 1 = 5

            for (int i = 1; i < mangSoNguen.Length; i++)
            {
                if(min > mangSoNguen[i]) min = mangSoNguen[i];
            }

            Console.WriteLine("Gia tri nho nhat la {0}", min);

            //sap xep mang theo thu tu tang dan
            Array.Sort(mangSoNguen); //sap tu be den lon
            //xuat mang
            Console.WriteLine("Mang tang dan voi foreach");
            foreach (var item in mangSoNguen)
            {
                Console.Write("{0}\t", item);
            }

            Array.Reverse(mangSoNguen); //dao mang, tu lon den be
            Console.WriteLine();
            Console.WriteLine("Dao mang voi Reverse");
            foreach (var item in mangSoNguen)
            {
                Console.Write("{0}\t", item);
            }
            Console.Write("{0}", mangSoNguen[0]);

            //Console.WriteLine("Mang giam dan voi foreach");
            //for (int i = mangSoNguen.Length - 1; i >= 0; i--)
            //{
            //    Console.Write("{0}\t", mangSoNguen[i]);
            //}

            //khai bao mang 2 chieu
            Console.Write("Nhap so hang = ");
            int hang = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot = ");
            int cot = int.Parse(Console.ReadLine());

            int[,] maTran = new int[hang,cot]; //tao ra mang gom n phan tu


            Console.ReadKey();
        }
    }
}
