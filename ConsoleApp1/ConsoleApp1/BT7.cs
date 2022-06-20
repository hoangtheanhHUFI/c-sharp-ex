//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BaiTap
//{
//   class NhanVien
//    {
//        string id,name; //Khai bao ma nhan vien : ID , ten nhan vien : Name, Xep loai : rank 
//        char rank;
//        public string Id //Thiet lap rang buoc property cho ID nhan vien 
//        {
//            get { return id; }
//            set { id = value; }
//        }
//        public string Name //Thiet lap property cho Ten nhan vien 
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        int daywork;
//        public int Daywork //Thiet lap rang buoc dau vao cho So ngay cong phai lon hon 0 
//        {
//            get { return daywork; }
//            set
//            {
//                if (value < 0)
//                {
//                    Console.WriteLine("Du lieu sai");
//                    daywork = 0;
//                }
//                else
//                {
//                    daywork = value;
//                }
//            }
//        }  
        
//        public static int salary = 200000;
            
//        public char Rank // Rank khong co du nhiep nhap vao nen khong dung property Set*
//        {
//            get { if (daywork >= 26)
//                    return 'A';
//                else if (daywork >= 22)
//                    return 'B';
//                 else
//                    return 'C';
//                        }

//        }
//        //-------------------Ham khoi tao------------------------
//        public NhanVien() //Khoi tao khong tham so 
//        {
//            Id = Name = "";
//            Daywork = 0;
//        }
//        public NhanVien(string id, string name, int daywork) //Khoi tao co tham so 
//        {
//            this.Id = id;
//            this.Name = name;   
//            this.Daywork = daywork; 
//        }
//        public NhanVien(NhanVien a) //Khoi tao sao chep !
//        {
//            Id = a.Id;
//            Name = a.Name;
//            Daywork = a.Daywork;

//        }
//        //-------------------Ham huy------------------------
//        ~NhanVien()
//        {

//        }
//        //-------------------Ham Xu li------------------------
//        public void NhapTTNV()
//        {
//            Console.WriteLine("Nhap ma so NV : ");
//            Id = Console.ReadLine();
//            Console.WriteLine("Nhap vap ho ten nhan vien : ");
//            Name = Console.ReadLine();
//            Console.WriteLine("Nhap vao so ngay cong :");
//            Daywork = int.Parse(Console.ReadLine());
//        }
//        public int TinhLuong()
//        {
//            return Daywork * salary;
//        }
//        public double TinhThuong()
//        {
//            if (Rank == 'A')
//                return TinhLuong() * 5 / 100;
//            else if (Rank == 'B')
//                return TinhLuong() * 2 / 100;
//            else
//                return 0;
//        }
//        public void XuatTTNV()
//        {
//            Console.WriteLine("{0} {1} {2} {3} {4}",id,name,daywork,TinhLuong(),TinhThuong());
//        }

//    }
//    class program
//    {
//        static void Main(string[] agrs)
//        {
//            NhanVien a = new NhanVien();
//            a.NhapTTNV();
//            a.XuatTTNV();
//            Console.ReadLine();
//        }
//    }

//}
