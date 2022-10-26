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
            DataHandler data = new DataHandler();
            InitializeComponent();
            

            //list.Add("str");
            //ToManyCurrencyResult.ItemsSource = list;

            //ToManyCurrencyResult.Items.Add(list);

            //foreach (string l in list)
            //{
            //    //ListBoxItem item = new ListBoxItem();
            //    //item.Name = l;
            //    ToManyCurrencyResult.Items.Add(l);
            //}


            //ToManyCurrencyResult.SetBinding(bind, _example);


            //bind.ElementName = _example;

            //ToManyCurrencyResult.SetBinding(, bind);


            //Binding bind2 = BindingOperations.SetBinding(ToManyCurrencyResult,TopProperty ,bind);



            

            
        }
        


        private void ToManyCurrencyResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ToManyCurrencyResult.
        }

    }

    
            
    }

    //public partial class CheckComboBox : ComboBox
    //{
    //    /// <summary>
    //    /// C'tor
    //    /// </summary>
    //    public CheckComboBox()
    //    {
    //        this.DrawMode = DrawMode.OwnerDrawFixed;
    //        this.DrawItem += new DrawItemEventHandler(CheckComboBox_DrawItem);
    //        this.SelectedIndexChanged += new EventHandler(CheckComboBox_SelectedIndexChanged);
    //        SelectedText = "Select Options";
    //    }

    //    /// <summary>
    //    /// Invoked when the selected index is changed on the dropdown.  This sets the check state
    //    /// of the CheckComboBoxItem and fires the public event CheckStateChanged using the 
    //    /// CheckComboBoxItem as the event sender.
    //    /// </summary>
    //    /// <param name="sender"></param>
    //    /// <param name="e"></param>
    //    void CheckComboBox_SelectedIndexChanged(object sender, EventArgs e)
    //    {
    //        CheckComboBoxItem item = (CheckComboBoxItem)SelectedItem;
    //        item.CheckState = !item.CheckState;
    //        if (CheckStateChanged != null)
    //            CheckStateChanged(item, e);
    //    }

    //    /// <summary>
    //    /// Invoked when the ComboBox has to render the drop-down items.
    //    /// </summary>
    //    /// <param name="sender"></param>
    //    /// <param name="e"></param>
    //    void CheckComboBox_DrawItem(object sender, DrawItemEventArgs e)
    //    {
    //        // make sure the index is valid (sanity check)
    //        if (e.Index == -1)
    //        {
    //            return;
    //        }

    //        // test the item to see if its a CheckComboBoxItem
    //        if (!(Items[e.Index] is CheckComboBoxItem))
    //        {
    //            // it's not, so just render it as a default string
    //            e.Graphics.DrawString(
    //                Items[e.Index].ToString(),
    //                this.Font,
    //                Brushes.Black,
    //                new Point(e.Bounds.X, e.Bounds.Y));
    //            return;
    //        }

    //        // get the CheckComboBoxItem from the collection
    //        CheckComboBoxItem box = (CheckComboBoxItem)Items[e.Index];

    //        // render it
    //        CheckBoxRenderer.RenderMatchingApplicationState = true;
    //        CheckBoxRenderer.DrawCheckBox(
    //            e.Graphics,
    //            new Point(e.Bounds.X, e.Bounds.Y),
    //            e.Bounds,
    //            box.Text,
    //            this.Font,
    //            (e.State & DrawItemState.Focus) == 0,
    //            box.CheckState ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal);
    //    }

    //    /// <summary>
    //    /// Fired when the user clicks a check box item in the drop-down list
    //    /// </summary>
    //    public event EventHandler CheckStateChanged;

    //}
//}
