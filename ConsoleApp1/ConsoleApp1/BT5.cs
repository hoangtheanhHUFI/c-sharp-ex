//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BaiTap
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double a, b, c, x,delta;
//            Console.WriteLine("Phuong trinh bac 2 co dang : ax^2 + bx + c = 0 ");
//            Console.WriteLine("Nhap vao a : ");
//            do
//            {
//                a = int.Parse(Console.ReadLine());
//            }
//            while (a<=0);
//            Console.WriteLine("Nhap vao b : ");
//            b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Nhap vao c : ");
//            c = int.Parse(Console.ReadLine());

//            delta = Math.Pow(b, 2) - (4 * a * c);
//            if (delta < 0)
//                Console.WriteLine("Phuong trinh vo nghiem");
//            else if (delta == 0)
//            {
//                Console.WriteLine("Phuong Trinh co nghiem kep : x1=x2 = {0}",-b/(2*a));
//            }
//            else
//            {
//                Console.WriteLine("Phuong trinh co 2 nghiem phan biet : x1 = {0}  x2= {1} ", (-b + Math.Sqrt(delta)) / (2 * a) , (-b - Math.Sqrt(delta)) / (2 * a));
//            }
//            Console.ReadLine();
//        }
//    }
//}
