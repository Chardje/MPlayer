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
using System.Threading;

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

            //Console.Beep(x*50, 250);
            Console.Beep((int)637, 500);
            Console.Beep((int)37, 500);

            Console.Beep((int)637, 500);
            Console.Beep((int)37, 500);

            Console.Beep((int)637, 500);
            Console.Beep((int)37, 500);

            Console.Beep((int)637, 500);
            Console.Beep((int)37, 500);



            Console.Beep((int)637, 500);
            Console.Beep((int)137, 500);

            Console.Beep((int)637, 500);
            Console.Beep((int)137, 500);

            Console.Beep((int)637, 500);
            Console.Beep((int)137, 500);

            Console.Beep((int)637, 500);
            Console.Beep((int)137, 500);

                /*Console.Beep((int)637, 500);
                Console.Beep((int) 637, 1000);
                Thread.Sleep(250);
                Console.Beep((int) 637, 500);
                Thread.Sleep(250);
                Console.Beep((int)637, 500);
                Thread.Sleep(1000);
                Console.Beep((int)637, 500);
                Thread.Sleep(500);*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.Beep((int)837, 500);
            

        }

        private void Music_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4; i +=1)
            {
                Console.Beep(200, 500);
                Console.Beep(300, 500);
                Console.Beep(400, 500);
                Console.Beep(500, 500);
            }
            for (int i = 0; i < 4; i += 1)
            {
                Console.Beep(300, 500);
                Console.Beep(400, 500);
                Console.Beep(500, 500);
                Console.Beep(600, 500);
            }
            for (int i = 0; i < 4; i += 1)
            {
                Console.Beep(400, 500);
                Console.Beep(500, 500);
                Console.Beep(600, 500);
                Console.Beep(700, 500);
            }
            for (int i = 0; i < 4; i += 1)
            {
                Console.Beep(400, 500);
                Console.Beep(500, 500);
                Console.Beep(600, 500);
                Console.Beep(800, 500);
            }
        }
    }
}
