using System.Collections.Generic;
using System.Windows;

namespace SalesApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Пример данных
            var salesData = new List<MonthSale>
            {
                new MonthSale { Month = "January", Description = "Winter Sales", UnitsSold = 120, Revenue = "$2400" },
                new MonthSale { Month = "February", Description = "Valentine's Day", UnitsSold = 200, Revenue = "$5000" },
                new MonthSale { Month = "March", Description = "Spring Launch", UnitsSold = 150, Revenue = "$3750" },
                new MonthSale { Month = "April", Description = "April Discounts", UnitsSold = 180, Revenue = "$4500" }
            };

            // Привязка данных
            SalesItemsControl.ItemsSource = salesData;
        }
    }

    public class MonthSale
    {
        public string Month { get; set; }
        public string Description { get; set; }
        public int UnitsSold { get; set; }
        public string Revenue { get; set; }
    }
}
