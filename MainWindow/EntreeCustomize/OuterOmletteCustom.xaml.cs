using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TheFlyingSaucer.Data.Entrees;

namespace mainWindow.EntreeCustomize
{
    /// <summary>
    /// Interaction logic for OuterOmletteCustom.xaml
    /// </summary>
    public partial class OuterOmletteCustom : Window
    {
        /// <summary>
        /// Temp object to hold custom options
        /// </summary>
        public OuterOmelette oo;
        public OuterOmletteCustom()
        {
            oo = new OuterOmelette();
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for done button
        /// Takes current attributes, assigns them to the temp and closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Done_Click(object sender, EventArgs e)
        {
            oo.Tomatoes = (bool)Tomatoes.IsChecked;
            oo.Mushrooms = (bool)Mushrooms.IsChecked;
            oo.Peppers = (bool)Peppers.IsChecked;
            oo.Onions = (bool)Onions.IsChecked;
            oo.Spinach = (bool)Spinach.IsChecked;
            oo.Ham = (bool)Ham.IsChecked;
            oo.Cheese = (bool)Cheese.IsChecked;
            oo.SourCream = (bool)SourCream.IsChecked;
            Close();
        }
    }
}
