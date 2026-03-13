using _13_03_26.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presenters
{
    public class SectionPresenter
    {
        private SectionPresenter model_ = new DaysPresenter();
        private List<ISectionView> views_;
        public SectionPresenter (List<ISectionView> views)
        {
            views_ = views;
            model_.Load();
        }
        public void ShowSectionsByDays(string dayName)
        {
            List<Section>sections = model_.LoadSectionsForDay(dayName);
            foreach (ISectionView view in views_)
            {
                view.Show(sections);
            }
        }
        public List<Days> GetAllDays()
        {
            return model_.GetAllDays();
        }
        public double GetProfitPresentByDay(Days selectedDay)
        {
            // доделать, когда создам анализ и подсчет прибыли
            return;
        }
    }
}
