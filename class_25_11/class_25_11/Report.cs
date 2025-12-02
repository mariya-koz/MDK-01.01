using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_25_11
{
    class Report
    {
        private List<Info> rows_ = new List<Info>();

        public void AddRecord(Info row)
        {
            rows_.Add(row);
        }

        public string ConvertReportToString(Info row)
        {
            return row.Product + ";" + row.Count + ";" + row.Price;
        }

        public void PrintReport()
        {
            foreach (Info row in rows_)
            {
                Console.WriteLine(ConvertReportToString(row) + "\n");
            }
        }

        public void CalculateSum()
        {
            double sum = 0;
            foreach (Info row in rows_)
            {
                sum += row.Count * row.Price;
            }
            Console.WriteLine("" + sum);
        }
    }
}
