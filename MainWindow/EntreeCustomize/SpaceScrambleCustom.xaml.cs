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
    /// Interaction logic for SpaceScrambleCustom.xaml
    /// </summary>
    public partial class SpaceScrambleCustom : Window
    {
        /// <summary>
        /// temp object to hold custom options
        /// </summary>
        public SpaceScramble ss;
        public SpaceScrambleCustom()
        {
            ss = new SpaceScramble();
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
            ss.Sausage = (bool)Sausage.IsChecked;
            ss.Peppers = (bool)Peppers.IsChecked;
            ss.Potatoes = (bool)Potatoes.IsChecked;
            ss.Cheese = (bool)Cheese.IsChecked;
            ss.SourCream = (bool)SourCream.IsChecked;
            ss.EggStyle = (TheFlyingSaucer.Data.Enums.EggStyle)Style.SelectedIndex;
            Close();
        }
    }
}
