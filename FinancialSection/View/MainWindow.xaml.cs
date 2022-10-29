using System;
using System.Collections.Generic;
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
using FinancialSection.Presenter;
using System.ComponentModel;

namespace FinancialSection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public string _exampleString { get; set; }
        //public int _exampleInt { get; set; }
        //public bool _exampleBool { get; set; }


        public MainWindow()
        {
            //Binding + моделька-класс Handler
            InitializeComponent();
        }
        


        private void ToManyCurrencyResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

    }
}
