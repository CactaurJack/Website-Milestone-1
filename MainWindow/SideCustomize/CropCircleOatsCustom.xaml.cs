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
    /// Interaction logic for CropCircleOatsCustom.xaml
    /// </summary>
    public partial class CropCircleOatsCustom : Window
    {
        /// <summary>
        /// Temp object to hold cutomized item
        /// </summary>
        public CropCircleOats cco;
        public CropCircleOatsCustom()
        {
            cco = new CropCircleOats();
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
            cco.Butter = (bool)Butter.IsChecked;
            cco.Syrup = (bool)Syrup.IsChecked;
            cco.SyrupFlavor = (TheFlyingSaucer.Data.Enums.SyrupFlavor)Flavor.SelectedIndex;
            cco.Size = (TheFlyingSaucer.Data.Enums.Size)Size.SelectedIndex;
            Close();
        }
    }
}
