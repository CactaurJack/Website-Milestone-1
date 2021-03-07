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
    /// Interaction logic for LiveStockMutilationCustom.xaml
    /// </summary>
    public partial class LiveStockMutilationCustom : Window
    {
        /// <summary>
        /// Temp object to hold customized item
        /// </summary>
        public LivestockMutilation ls;

        public LiveStockMutilationCustom()
        {
            ls = new LivestockMutilation();
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
            ls.GravyOnTheSide = (bool)GravyOnTheSide.IsChecked;
            Close();
        }
    }
}
