using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_03_26
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            presenter_ = new SalesPresenter(new List<IDaysView> { cartesian });
            PieChart.SetPresenter(presenter_);
            PieChart.UpdateView();

            FillCartesianChart();

            FillAngular();

            FillSolid();

        }
        private SectionPresenter presenter_;
        void FillCartesianChart()
        {
            SectionList.DataSource = presenter_.GetAllSection();
            SectionList.DisplayMember = "Name";
            if (SectionList.Section.Count > 0)
            {
                presenter_.ShowDaysBySection(((Section)ISectionList.Section[0]).Name);
            }
        }
        private void ItemsList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Item selectedItem = ((Item)(ItemsList.SelectedItem));
            if (selectedItem == null)
            {
                return;
            }

            presenter_.ShowSalesByItem(selectedItem.Name);
            double percent = Math.Round(
                presenter_.GetProfitPercentByItem(selectedItem), 2);

            angular.Value = percent;
            solid.Value = percent;
        }

        void FillPieChart()
        {


            PieChart.LegendLocation = LegendLocation.Right;
        }


    }
}
