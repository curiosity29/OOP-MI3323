using System;
using System.Collections;
using System.Collections.Generic;
namespace QuanLyHocSinh
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        Program()
        {
            //input
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Nhập số học sinh = ");
            int soHocSinh = int.Parse(Console.ReadLine());

            // nhập danh sách học sinh:
            var dsHocSinh = new List<HocSinh>();
            for (int i = 1; i <= soHocSinh; i++)
            {
                Console.WriteLine("Nhập thông tin cho học sinh thứ {0}", i);
                dsHocSinh.Add(new HocSinh());
            }
            
            //danh sách thi lại:
            var dsThiLai = new DSThiLai();
            Console.WriteLine("Danh sách các học sinh thi lại:");
            int count = 0;
            foreach(HocSinh hocSinh in dsHocSinh)
            {
                if (hocSinh.thiLai)
                {
                    dsThiLai[count] = hocSinh;
                    count++;
                }
            }

            //in danh sách thi lại:
            for(int i =0; i< count; i++)
            {
                dsThiLai[i].GetStatus();
            }
        }
    }
    class HocSinh
    {
        private int _diemToan, _diemHoa, _diemLy;
        private string _hoten;
        string HoTen { get => _hoten; }
        int DiemToan
        {
            get
            {
                return _diemToan;
            }
            set
            {
                _diemToan = value;
            }
        }
        int DiemHoa
        {
            get => _diemHoa;
            set => _diemHoa = value;
        }
        int DiemLy
        {
            get => _diemLy;
            set => _diemLy = value;
        }
        public HocSinh()
        {
            Console.WriteLine("Nhập họ tên: ");
            _hoten = Console.ReadLine();
            Console.WriteLine("Điểm Toán: ");
            _diemToan = int.Parse(Console.ReadLine());
            Console.WriteLine("Điểm Hóa: ");
            _diemHoa = int.Parse(Console.ReadLine());
            Console.WriteLine("Điểm Lý: ");
            _diemLy = int.Parse(Console.ReadLine());
        }
        public bool thiLai
        {
            get
            {
                return (DiemToan < 4 || DiemHoa < 4 || DiemLy < 4);
            }
        }
        public void GetStatus()
        {
            Console.WriteLine("Họ tên: {0}", HoTen);
            Console.WriteLine("Điểm Toán: {0}", DiemToan);
            Console.WriteLine("Điểm Hóa: {0}", DiemHoa);
            Console.WriteLine("Điểm Lý: {0}", DiemLy);
        }
    }
    class DSThiLai
    {
        HocSinh[] dsThiLai = new HocSinh[100];
        public HocSinh this[int number]
        {
            get
            {
                if (number >= 0 && number < dsThiLai.Length)
                    return dsThiLai[number];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (number >= 0 && number < dsThiLai.Length)
                    dsThiLai[number] = value;
            }
        }
    }
}
