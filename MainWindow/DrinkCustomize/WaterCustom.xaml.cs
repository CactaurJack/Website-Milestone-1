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
using TheFlyingSaucer.Data.Drink;

namespace mainWindow.DrinkCustomize
{
    /// <summary>
    /// Interaction logic for WaterCustom.xaml
    /// </summary>
    public partial class WaterCustom : Window
    {
        /// <summary>
        /// Temp object to hold cutomized item
        /// </summary>
        public Water w;
        public WaterCustom()
        {
            w = new Water();
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
            w.Size = (TheFlyingSaucer.Data.Enums.Size)Size.SelectedIndex;
            Close();
        }
    }
}
