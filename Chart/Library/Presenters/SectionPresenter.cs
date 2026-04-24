using _13_03_26.View;
using Library.Analisys;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presenters
{
    public class SectionPresenter
    {
        public class DaysPresenter
        {
            private DaysModel model_ = new DaysModel();
            private List<IDaysView> views_;
            public DaysPresenter(List<IDaysView> views)
            {
                views_ = views;

                model_.Load();
            }

            public void ShowSalesByItem(string itemName)
            {
                List<Days> sales = model_.LoadSalesForItem(itemName);
                foreach (IDaysView view in views_)
                {
                    view.Show(sales);
                }
            }

            /// <summary>
            /// с помощью этого метода можно получить список всех продаваемых
            /// элементов в системе (товаров, услуг, .....)
            /// </summary>
            /// <returns>Список элементов</returns>
            public List<Section> GetAllItems()
            {
                return model_.GetAllSection();
            }

            public double GetProfitPercentByItem(Section selectedItem)
            {
                return Math.Round(ProfitAnalizer.CalculateProfitPercentBySection(selectedItem.Name,
                                                                   model_), 2);
            }
        }
    }
}