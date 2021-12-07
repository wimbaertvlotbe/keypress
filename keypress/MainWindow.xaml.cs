/* ing. W. Baert
 * Test keyboard events
 * 
 */
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

namespace keypress
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EventManager.RegisterClassHandler(typeof(Window),Keyboard.KeyUpEvent, new KeyEventHandler(keyboardEvent), true);
        }

        private void keyboardEvent(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.Key.ToString());
        }


    }
}
