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
using TheFlyingSaucer.Data.Sides;

namespace mainWindow.SideCustomize
{
    /// <summary>
    /// Interaction logic for GlowingHaystackCustom.xaml
    /// </summary>
    public partial class GlowingHaystackCustom : Window
    {
        /// <summary>
        /// Temp object to hold cutomized item
        /// </summary>
        public GlowingHaystack gh;
        public GlowingHaystackCustom()
        {
            gh = new GlowingHaystack();
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
            gh.Sauced = (bool)Sauced.IsChecked;
            gh.Size = (TheFlyingSaucer.Data.Enums.Size)Size.SelectedIndex;
            Close();
        }
    }
}
