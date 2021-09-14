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
using System.Media;

namespace MPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       /* bool pause = true;
        SoundPlayer sp = new SoundPlayer(@"C:\Users\student\Desktop\Cruzo - Epic Sax Guy (Cruzo Remix).wav");
       */
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            while (true)
            {
                //Console.Beep((int)Math.Abs(Math.Sin(x * 10) * 600) + 200, 250);
                Console.Beep((int)(Math.Sin(x * 30) + Math.Cos(x * 50)) * 600 + 637, 500);
                Console.Beep(37, 500);
                Console.Beep((int)(Math.Sin(x * 30) + Math.Cos(x * 50)) * 600 + 637, 500);
                Console.Beep(37, 500);
                x++;
            }
        }
    }
}
