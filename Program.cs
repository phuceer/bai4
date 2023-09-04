using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intA, intB;
            double dbekq;
            Console.WriteLine("***GIAI VA BIEN LUAN PHUONG TRINH BAC 1***");
            Console.WriteLine("**************aX + b = 0 *****************");
            Console.Write("{0}", "nhap a");
            intA =Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap b");
            intB = Convert.ToInt32(Console.ReadLine());
            if (intA == 0 && intB == 0)
            {
                Console.WriteLine("phuong trinh co vo so nghiem");
            }else if(intA == 0 && intB != 0)
           {
                Console.WriteLine("phuong trinh vo nghiem");
           }else
            {
                dbekq = (double)-intB / intA;
                Console.WriteLine(" Phuong trinh co 1 nghiem duy nhat x = {0}", dbekq);
            }
            Console.ReadKey();

        }
    }
}
