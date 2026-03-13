using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class DaysModel
    //daysBySection_
    {
        private Dictionary<Section, List<Days>> daysBySection_ =
            new Dictionary<Section, List<Days>>();

        public void AddDays(Section section, List<Days> days)
        {
            if (daysBySection_.ContainsKey(section))
            {
                daysBySection_[section].AddRange(days);
            }
            else
            {
                daysBySection_.Add(section, days);
            }
        }

        /// <summary>
        /// метод используется для получения информации обо всех секциях
        /// элемента item
        /// </summary>
        /// <param name="section">Секция</param>
        /// <returns>Список всех занятий</returns>
        public List<Days> LoadSalesForItem(string sectionName)
        {
            List<Section> allSection = daysBySection_.Keys.ToList();
            Section targetSection = allSection.Find(section => section.Name == sectionName);
            if (targetSection != null)
            {
                return daysBySection_[targetSection];
            }

            return new List<Days>();
        }

        public bool Load()
        {
            AddDays(new Section { Name = "Конфетки Заоблачные", Price = 100 },
                new List<Days>() {
                    new Days {Day = new System.DateTime(2026, 2, 1), Count = 10 } ,
                });

            AddDays(new Section { Name = "Конфетки Заоблачные", Price = 100 },
                new List<Days>() {
                    new Days {Day = new System.DateTime(2026, 2, 1), Count = 10 } ,
                });

            return true;
        }

        public List<Section> GetAllSection()
        {
            return daysBySection_.Keys.ToList();
        }

        public double GetTotalProfit()
        {
            double result = 0.0;
            foreach (KeyValuePair<Section, List<Days>> keyValue in daysBySection_)
            {
                Section section = keyValue.Key;
                result += keyValue.Value.Sum(days => days.Count * section.Price);
            }

            return result;
        }

        public Section GetSection(string sectionName)
        {
            foreach (KeyValuePair<Section, List<Days>> keyValue in daysBySection_)
            {
                Section section = keyValue.Key;
                if (section.Name == sectionName)
                {
                    return section;
                }
            }

            return null;
        }
    }
}
