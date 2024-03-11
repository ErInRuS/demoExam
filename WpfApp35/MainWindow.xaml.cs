using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp35
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Product.Products.Add(new Product("Молоко"));
            Product.Products.Add(new Product("Хлеб"));
            Product.Products.Add(new Product("Свинец 500г"));

            foreach (Product product in Product.Products)
            {
                StackPanel sp = new StackPanel();
                sp.Orientation = Orientation.Horizontal;
                var img = new Image();
                img.Height = 50;
                img.Width = 50;
                img.Source = new BitmapImage(new Uri("C:\\Users\\User.work-pc\\source\\repos\\WpfApp35\\WpfApp35\\img\\img.png"));
                var lbl = new Label();
                lbl.Content = product.Show();
                lbl.VerticalAlignment = VerticalAlignment.Center;
                sp.Children.Add(img);
                sp.Children.Add(lbl);

                listProducts.Items.Add(sp);
            }

            //listProducts.ItemsSource = from t in Product.Products let img = new Image().Source = new BitmapImage(new Uri("C:\\Users\\User.work-pc\\source\\repos\\WpfApp35\\WpfApp35\\img\\img.png")) select string.Format("{0:000} {1,-50}",t.id,t.Name);
            //text.Content = string.Join("\n",from t in Product.Products select t.Show());

        }
    }
}
