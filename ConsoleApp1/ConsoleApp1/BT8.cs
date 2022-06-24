using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{

    class NuocGiaiKhat 
    {
        //Khai bao 
        string name, unit;
        int amount;
        double prices;
        public static double vat_tax= 0.1; //Tax nay dung static vi no khong thay doi 
        //set property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Unit //Set property cho Unit, chi nhan 4 gia tri
        {
            get { return unit.ToLower(); }
            set
            {
                if(value=="ket")
                {
                    unit = value;
                }
                else if(value=="thung")
                {
                    unit=value;
                }
                else if(value=="chai")
                {
                    unit = value;
                }
                else if(value=="lon")
                {
                    unit = value;
                }
                else
                {
                    Console.WriteLine("Du lieu nhap vao sai !(Unit)");
                    unit = "Invalid";
                }
            }
        }
        public int Amount //Set property cho Amount khong duoc be hon 0
        {
            get { return amount; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Du lieu bi sai !");
                    amount = 0;
                }
                else
                    amount = value;

                 }
        }
        public double Prices //Set property cho price khong <0
        {
            get { return prices; }
            set { if (value < 0)
                {
                    Console.WriteLine("Du lieu bi loi !");
                    prices = 0;
                }
                else
                    prices = value;
            }
        }
         //-------------------------Ham khoi tao-------------------
        public NuocGiaiKhat()
        {
            Name=  "";
            Amount = 0;
            Prices = 0;
        }
        public NuocGiaiKhat(string name, string unit, int amount, double prices)
        {
            this.name = name;
            this.unit = unit;
            this.amount = amount;
            this.prices = prices;
            
        }
        public NuocGiaiKhat(NuocGiaiKhat a)
        {
            Name = a.name;
            Unit = a.unit;
            Amount = a.amount;
            Prices = a.prices;
        }
        public void input()
        {
            Console.WriteLine("Nhap vao ten nuoc giai khat");
            name = Console.ReadLine();
            Console.WriteLine("Nhap vao don vi tinh");
            unit = Console.ReadLine();
            Console.WriteLine("Nhap vao don so luong");
            amount = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Don gia ");
            prices = double.Parse(Console.ReadLine());
        }

        //-----------------------Ham Huy------------------------------
        ~NuocGiaiKhat()
        {

        }
        //-----------------------------Ham Xu Li-------------------------
        public double total()
        {
            if (unit == "ket" || unit == "thung")
                return (amount * prices) + (amount * prices * vat_tax);
            else if (unit == "chai")
                return (amount * (prices / 20)) + (amount * (prices / 20) * vat_tax);
            else if (unit == "lon")
                return (amount*(prices/24))+(amount*(prices/24*vat_tax));
            else
                return 0;
        }
    }
    class program 
    {
        static void Main(string[] agrs)
        {
            NuocGiaiKhat a = new NuocGiaiKhat();
            a.input();
            Console.WriteLine("{0} {1} {2} tri gia {3}",a.Amount,a.Unit,a.Name,a.total());
            
    
        }
    }

}
