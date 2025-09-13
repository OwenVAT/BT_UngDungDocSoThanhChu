using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngSungDocSoThanhChu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool checkInput = false;
            int so = 0;
            while (checkInput == false)
            {
                Console.WriteLine("Nhap vao so nguyen duong toi da 3 chu so: ");
                checkInput = int.TryParse(Console.ReadLine(), out so);
                if ((so>999)||(so<0)) { checkInput = false; }
            }
            int tram = so / 100;
            int chuc = (so - tram * 100) / 10;
            int donVi = (so - tram * 100 - chuc * 10);
            string chuTram = "";
            string chuChuc = "";
            string chuDonVi = "";
            switch (tram)
            {
                case 1: chuTram = "mot"; break;
                case 2: chuTram = "hai"; break;
                case 3: chuTram = "ba"; break;
                case 4: chuTram = "bon"; break;
                case 5: chuTram = "nam"; break;
                case 6: chuTram = "sau"; break;
                case 7: chuTram = "bay"; break;
                case 8: chuTram = "tam"; break;
                case 9: chuTram = "chin"; break;
            }
            switch (chuc)
            {
                case 1: chuChuc = "mot"; break;
                case 2: chuChuc = "hai"; break;
                case 3: chuChuc = "ba"; break;
                case 4: chuChuc = "bon"; break;
                case 5: chuChuc = "nam"; break;
                case 6: chuChuc = "sau"; break;
                case 7: chuChuc = "bay"; break;
                case 8: chuChuc = "tam"; break;
                case 9: chuChuc = "chin"; break;
            }
            switch (donVi)
            {
                case 1: chuDonVi = "mot"; break;
                case 2: chuDonVi = "hai"; break;
                case 3: chuDonVi = "ba"; break;
                case 4: chuDonVi = "bon"; break;
                case 5: chuDonVi = "nam"; break;
                case 6: chuDonVi = "sau"; break;
                case 7: chuDonVi = "bay"; break;
                case 8: chuDonVi = "tam"; break;
                case 9: chuDonVi = "chin"; break;
            }
            Console.Write("Ket qua: ");
            if (tram > 0)
            {
                Console.Write(chuTram + " tram ");
            }
            if (chuc > 0)
            {
                Console.Write(chuChuc + " muoi ");
            }
            else
                if ((tram > 0) && (donVi > 0))
            {
                Console.Write("le ");
            }
            if (donVi > 0)
            {
                if ((donVi == 5) && (chuc > 0))
                {
                    Console.Write("lam");
                }
                else Console.Write(chuDonVi);
            }

        }
    }
}
