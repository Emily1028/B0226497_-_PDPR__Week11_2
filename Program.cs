using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week11_2");
            Console.Write("請輸入年收入:");
            double taxRate = 0, netIncome = 0, tax = 0, total = 0;
            int stage = 0;
            netIncome = double.Parse(Console.ReadLine());
            if (netIncome > 0)
                stage = (netIncome < 100 ? 1 : (netIncome < 200 ? 2 : (netIncome < 300 ? 3 : (netIncome < 400 ? 4 : 5))));
            switch (stage)
            {
                case 1:
                    taxRate = 0.15;
                    tax = netIncome * 0.15;
                    total = netIncome * 0.15;
                    break;
                case 2:
                    taxRate = 0.25;
                    tax = netIncome * 0.25;
                    total = 100 * 0.15 + (netIncome - 100) * 0.25;
                    break;
                case 3:
                    taxRate = 0.35;
                    tax = netIncome * 0.35;
                    total = 100 * 0.15 + 100 * 0.25 + (netIncome - 200) * 0.35;
                    break;
                case 4:
                    taxRate = 0.45;
                    tax = netIncome * 0.45;
                    total = 100 * 0.15 + 100 * 0.25 + 100 * 0.35 + (netIncome - 300) * 0.45;
                    break;
                case 5:
                    taxRate = 0.55;
                    tax = netIncome * 0.55;
                    total = 100 * 0.15 + 100 * 0.25 + 100 * 0.35 + 100 * 0.45 + (netIncome - 400) * 0.55;
                    break;
            }

            Console.WriteLine("單一稅率應繳稅額");
            Console.WriteLine("年收入:{0}元,稅率:{1}%,應繳:{2}元", netIncome, taxRate, tax);
            Console.WriteLine("累加稅率應繳稅額");
            Console.WriteLine("年收入:{0}元,應繳:{1}元", netIncome, total);
            Console.ReadLine();
        }
    }
}
