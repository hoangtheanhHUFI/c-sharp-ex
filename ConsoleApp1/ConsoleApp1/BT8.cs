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
            get { return unit; }
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
                    Console.WriteLine("Du lieu nhap vao sai !");
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
            Name= Unit = "";
            Amount = 0;
            Prices = 0;
        }
        public NuocGiaiKhat(string name, string unit, int amount, double prices)
        {
            this.Name = name;
            this.Unit = unit;
            this.Amount = amount;
            this.Prices = prices;
            
        }
        public NuocGiaiKhat(NuocGiaiKhat a)
        {
            Name = a.Name;
            Unit = a.Unit;
            Amount = a.Amount;
            Prices = a.Prices;
        }
        //-----------------------------Ham Xu Li-------------------------

    }
    class program { }

}
