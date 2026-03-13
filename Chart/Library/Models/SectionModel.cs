using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class SectionModel
    {
        private Dictionary<Section, List<Days>  daysBySection_ =  new Dictionary<Section, List<Days>>();
        public void AddSection(Section section, List<Days> days)
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
        public List<Days> LoadDaysForSection (string sectionName)
        {
            List<Section> allSection = daysBySection_.Keys.ToList();
            Section targetSections = allSection.Find(section => section.Name == sectionName);
            if (targetSections != null)
            {
                return daysBySection_[targetSections];
            }
            return new List<Days>();
        }
        public bool Load()
        {
            AddDays(new Section { Name = "волейбол", Price = 2000 },
                new List<Days>() { Days = new System.DateTime(2026, 5, 8), Count = 2 },
                new List<Days>() { Days = new System.DateTime(2026, 5, 8), Count = 2 });
            AddDays(new Section { Name = "волейбол", Price = 2000 },
                new List<Days>() { Days = new System.DateTime(2026, 5, 8), Count = 2 },
                new List<Days>() { Days = new System.DateTime(2026, 5, 8), Count = 2 });
            return true;
        }
        public List<Days> GetAllSection()
        {
            return daysBySection_.Keys.ToList();
        }
        public double GetTotalProfit()
        {
            double result = 0.0;
            foreach(KeyValuePair<Section, List<Days>> keyValue in daysBySection_)
            {
                Section section = keyValue.Key;
                result += keyValue.Value.Sum(section => section.Price * days.Count);
            }
            return result;
        }
        public Section GetDays(string sectionName)
        {
            foreach (KeyValuePair<Days, List<Days>> keyValue in daysBySection_)
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
