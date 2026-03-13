using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Analisys
{
    public class ProfitAnalizer
    {
        public static double CalculateProfitPercentBySection(string sectionName, DaysModel model)
        {
            /// 1. Получить выручку товара (услуги, ....) itemName
            List<Days> sectionSales = model.LoadDaysForSection(sectionName);
            Section targetSection = model.GetSection(sectionName);
            if (targetSection == null)
            {
                return 0.0;
            }
            double sectionTotal = sectionSales.Sum(days => days.Count * targetSection.Price);

            /// 2. Получить общую выручку
            double total = model.GetTotalProfit();
            if (total == 0.0)
            {
                return 0.0;
            }

            return sectionTotal / total * 100.0;
        }
    }
}
