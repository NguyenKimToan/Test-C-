
namespace Cuoiky
{
    class Dichvu
    {
        public virtual void Phidichvu()
        {
        }
    }
    class Xemay: Dichvu
    {
        private string[,] XM = new string[100,10];
        public Xemay(string Xm)
        {
            int i=0,j;
            foreach (var s in Xm.Split("\n"))
            {
                j=0;
                foreach(var g in s.Split(","))
                {
                    XM[i,j]=g.Trim();
                    j++;
                }
                i++;
            }
        }
        public void Giamgia()
        {
            for (int i=0;i<XM.GetLength(0);i++)
            {
                if (XM[i,5]!=null)
                {
                    Console.Write("Khach hang: {0}, Diem nhan: {1}, Diem den: {2}, Don gia: {3}, Quang duong: {4}km, Giam gia: {5}",XM[i,0],XM[i,1], XM[i,2],XM[i,4],XM[i,3],XM[i,5]);
                    Console.WriteLine();
                }
            }
        }
        public override void Phidichvu()
        {
            for (int i=0;i<XM.GetLength(0);i++)
            {
                if (XM[i,0]!=null & XM[i,5]!=null)
                {
                    double phidv=Convert.ToDouble(XM[i,3])*Convert.ToDouble(XM[i,4])-Convert.ToDouble(XM[i,5]);
                    Console.Write("Khach hang: {0}, Diem nhan: {1}, Diem den: {2}, Don gia: {3}, Quang duong: {4}, Giam gia: {5}km, Tong phi: {6}",XM[i,0],XM[i,1], XM[i,2],XM[i,4],XM[i,3],XM[i,5],phidv);
                    Console.WriteLine();
                }
                if (XM[i,0]!=null & XM[i,5]==null)
                {
                    double phidv=Convert.ToDouble(XM[i,3])*Convert.ToDouble(XM[i,4])-Convert.ToDouble(XM[i,5]);
                    Console.Write("Khach hang: {0}, Diem nhan: {1}, Diem den: {2}, Don gia: {3}, Quang duong: {4}, Giam gia: {5}km, Tong phi: {6}",XM[i,0],XM[i,1], XM[i,2],XM[i,4],XM[i,3],0,phidv);
                    Console.WriteLine();
                }
            }
        }
    }
    class Oto: Dichvu
    {
        private string[,] O = new string[100,10];
        public double hslx;
        public int loaixe;
        public Oto(string Ot)
        {
            int i=0,j;
            foreach (var s in Ot.Split("\n"))
            {
                j=0;
                foreach(var g in s.Split(","))
                {
                    O[i,j]=g.Trim();
                    j++;
                }
                i++;
            }
        }
        public void Nhap()
        {   
            for (int i=0;i<O.GetLength(0);i++)
            {
                if (O[i,0]!=null)
                {
                    Console.Write("Nhap loai xe cua xe {0} :",i+1);
                    loaixe = Convert.ToInt32(Console.ReadLine());
                    O[i,6]=Convert.ToString(loaixe);
                    if (loaixe==4)
                    {
                        // hslx=1;
                        O[i,7]="1";
                    }
                    if (loaixe==7)
                    {
                        // hslx=1.5;
                        O[i,7]="1.5";
                    }
                }
            }
        }
        public void Giamgia()
        {
            for (int i=0;i<O.GetLength(0);i++)
            {
                if (O[i,5]!=null)
                {
                    Console.Write("Khach hang: {0}, Diem nhan: {1}, Loai xe: {2} cho, Diem den: {3}, Don gia: {4}, Quang duong: {5}km, Giam gia: {6}",O[i,0],O[i,1],O[i,6],O[i,2],O[i,4],O[i,3],O[i,5]);
                    Console.WriteLine();
                }
            }
        }
        public override void Phidichvu()
        {
            for (int i=0;i<O.GetLength(0);i++)
            {
                if (O[i,0]!=null & O[i,5]!=null)
                {
                    double phidv=Convert.ToDouble(O[i,3])*Convert.ToDouble(O[i,4])*Convert.ToDouble(O[i,7])-Convert.ToDouble(O[i,5]);
                    Console.Write("Khach hang: {0}, Diem nhan: {1}, Diem den: {2}, Loai xe: {3} cho, Don gia: {4}, Quang duong: {5}km, Giam gia: {6}, Tong phi: {7}",O[i,0],O[i,1],O[i,2],O[i,6],O[i,4],O[i,3],O[i,5],phidv);
                    Console.WriteLine();
                }
                if (O[i,0]!=null & O[i,5]==null)
                {
                    double phidv=Convert.ToDouble(O[i,3])*Convert.ToDouble(O[i,4])*Convert.ToDouble(O[i,7])-Convert.ToDouble(O[i,5]);
                    Console.Write("Khach hang: {0}, Diem nhan: {1}, Diem den: {2}, Loai xe: {3} cho, Don gia: {4}, Quang duong: {5}km, Giam gia: {6}, Tong phi: {7}",O[i,0],O[i,1],O[i,2],O[i,6],O[i,4],O[i,3],0,phidv);
                    Console.WriteLine();
                }
            }
        }
    }
    class Giaohang: Dichvu
    {
        private string[,] GH = new string[100,10];
        public double giasp;
        public Giaohang(string Gh)
        {
            int i=0,j;
            foreach(var s in Gh.Split("\n"))
            {
                j=0;
                foreach (var g in s.Split(","))
                {
                    GH[i,j]=g.Trim();
                    j++;
                }
                i++;
            }
        }
        public void Sanpham()
        {
            for (int i=0;i<GH.GetLength(0);i++)
            {
                if (GH[i,0]!=null)
                {
                    Console.Write("Nhap gia san pham {0}:",i+1);
                    giasp=Convert.ToDouble(Console.ReadLine());
                    GH[i,6]=Convert.ToString(giasp);
                }
            }
        }
        public void Giamgia()
        {
            for (int i=0;i<GH.GetLength(0);i++)
            {
                if (GH[i,5]!=null)
                {
                    Console.Write("Khach hang: {0}, Diem nhan: {1}, Diem den: {2}, Gia san pham: {3}, Don gia: {4}, Quang duong: {5}km, Giam gia: {6}",GH[i,0],GH[i,1],GH[i,2],GH[i,6],GH[i,4],GH[i,3],GH[i,5]);
                    Console.WriteLine();
                }
            }
        }
        public override void Phidichvu()
        {
            for (int i=0;i<GH.GetLength(0);i++)
            {
                if (GH[i,0]!=null & GH[i,5]!=null)
                {
                    double Phidv= Convert.ToDouble(GH[i,6])+Convert.ToDouble(GH[i,3])*Convert.ToDouble(GH[i,4])-Convert.ToDouble(GH[i,5]);
                    Console.Write("Khach hang: {0}, Diem nhan: {1}, Diem den: {2}, Gia san pham: {3}, Don gia: {4}, Quang duong: {5}km, Giam gia: {6}, Tong phi: {7}",GH[i,0],GH[i,1],GH[i,2],GH[i,6],GH[i,4],GH[i,3],GH[i,5],Phidv);
                    Console.WriteLine();
                }
                if (GH[i,0]!=null & GH[i,5]==null)
                {
                    double Phidv= Convert.ToDouble(GH[i,6])+Convert.ToDouble(GH[i,3])*Convert.ToDouble(GH[i,4])-Convert.ToDouble(GH[i,5]);
                    Console.Write("Khach hang: {0}, Diem nhan: {1}, Diem den: {2}, Gia san pham: {3}, Don gia: {4}, Quang duong: {5}km, Giam gia: {6}, Tong phi: {7}",GH[i,0],GH[i,1],GH[i,2],GH[i,6],GH[i,4],GH[i,3],0,Phidv);
                    Console.WriteLine();
                }
            }
        }
    }
    class Quanlydichvu
    {
        static void Main(string[] args)
        {
            string Ot=@"Toan, Ga Da Nang, San bay Da Nang, 50, 7000
                        An, San bay, Cang, 100, 6000, 1200
                        Thong, Khach san A, Khach san B, 25, 5000, 1000";
            string Xm=@"An, A, B, 50, 3000, 1000
                        Thong, C, D, 40, 2500, 700";
            string Gh=@"Giao, E, F, 46, 4000, 1000
                        Hang, G, H, 20, 5000, 1200"; 
            Dichvu D = new Dichvu();
            Xemay X = new Xemay(Xm);
            Oto o = new Oto(Ot);
            Giaohang G = new Giaohang(Gh);
            while (true)
            {
                Console.Write("Nhap menu: ");
                int n= Convert.ToInt32(Console.ReadLine());
                if (n==1)
                {
                    X.Phidichvu();
                }
                if (n==2)
                {
                    o.Nhap();
                    o.Phidichvu();
                }
                else if (n==3)
                {
                    G.Sanpham();
                    G.Phidichvu();
                }
                else if (n==4)
                {
                    Console.WriteLine("-----Nhung dich vu co giam gia-----");
                    X.Giamgia();
                    o.Giamgia();
                    G.Giamgia();
                }
                else if (n==0)
                {
                    Console.WriteLine("--Exit--");
                    break;
                }
            }
        }
    }
}
