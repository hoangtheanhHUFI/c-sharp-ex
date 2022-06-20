using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    class circle
    {
        private double r;
        public double R //Cai nay la de bat buoc r>0
        {
            get { return r; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Du lieu bi loi");
                    r = 0;
                }
                else
                {
                    r = value;
                }

            }
        }
        public circle() // Khoi tao khong tham so 
        {
            this.r = 0;
        }
        public circle(double r) // Khoi tao co tham so 
        {
            this.r = r;
        }
        public circle(circle circle) //Khoi tao theo phuong thuc sao chep 
        {
            this.r = circle.r;
        }



        public void input() // input method 
        {
            Console.Write("Nhap vao ban kinh hinh tron :");
            this.r = double.Parse(Console.ReadLine());
        }



        public double tinhChuvi() // Tinh chu vi hinh tron r*2*PI
        {
            return this.r * 2 * Math.PI;
        }
        public double tinhDientich() //Tinh dien tich;
        {
            return Math.Pow(this.r, 2) * Math.PI;
        }



        public void Output()
        {
            Console.WriteLine("Hinh tron co dien tich {0:0.00} Chu vi {1:0.00}", tinhDientich(), tinhChuvi());
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            //Phuong thuc khoi tao khong khai bao
            circle a = new circle();
            a.input();
            a.Output();
            //Phuong thuc khoi tao co khai bao
            circle b = new circle(5.0f);
            Console.WriteLine("Chu vi hinh tron b la : {0} dien tich la : {1}", b.tinhChuvi(), b.tinhDientich());
            Console.ReadLine();
        }
    }

}
