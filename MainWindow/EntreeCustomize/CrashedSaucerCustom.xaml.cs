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
    /// Interaction logic for CrashedSaucerCustom.xaml
    /// </summary>
    public partial class CrashedSaucerCustom : Window
    {
        /// <summary>
        /// temporary object variable to handle custom options
        /// </summary>
        public CrashedSaucer cs;
        public CrashedSaucerCustom()
        {
            ///Initialization and creation of temp variable
            cs = new CrashedSaucer();
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
            cs.Syrup = (bool)Syrup.IsChecked;
            cs.HalfStack = (bool)HalfStack.IsChecked;
            cs.WhippedCream = (bool)WhippedCream.IsChecked;
            cs.SyrupFlavor = (TheFlyingSaucer.Data.Enums.SyrupFlavor)Flavor.SelectedIndex;
            Close();
        }

    }
}
