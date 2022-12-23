using System;
using System.Windows.Media;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace EevolutionOfTrust
{
    public static class Ext
    {
        public static async void BorderYellow(this Border border)
        {
            border.Background = new SolidColorBrush(Color.FromRgb(241, 196, 15));
            await Task.Delay(800);
            border.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        public static async void LabelYellow(this Label label)
        {
            label.Foreground = new SolidColorBrush(Color.FromRgb(241, 196, 15));
            await Task.Delay(800);
            label.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        public static void SetImage(this Image image)
        {
            if (DataBank.GameTurn < 5)
            {
                image.Source = new BitmapImage(new Uri("Images/Simulator.png", UriKind.Relative));
            }
            else if (DataBank.GameTurn < 9)
            {
                image.Source = new BitmapImage(new Uri("Images/Cheater.png", UriKind.Relative));
            }
            else if (DataBank.GameTurn < 13)
            {
                image.Source = new BitmapImage(new Uri("Images/Naive.png", UriKind.Relative));
            }
            else if (DataBank.GameTurn < 17)
            {
                image.Source = new BitmapImage(new Uri("Images/Malignant.png", UriKind.Relative));
            }
            else if (DataBank.GameTurn < 24)
            {
                image.Source = new BitmapImage(new Uri("Images/Detective.png", UriKind.Relative));
            }
        }
    }
}