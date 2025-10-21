using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba1pickmi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Storyboard rotateStoryboard;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetupAnimation()
        {
            rotateStoryboard = new Storyboard();
            DoubleAnimation rotateAnimation = new DoubleAnimation
            {
                By = 360,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                RepeatBehavior = RepeatBehavior.Forever
            };
            Storyboard.SetTarget(rotateAnimation, TexturedButton.RenderTransform);
            Storyboard.SetTargetProperty(rotateAnimation, new PropertyPath("Angle"));
            rotateStoryboard.Children.Add(rotateAnimation);
        }

        private void TexturedButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            rotateStoryboard.Begin();
        }

        private void TexturedButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            rotateStoryboard.Stop();
        }
    }

}