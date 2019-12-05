using System.Windows;
using Fluent;


namespace fudwriter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        //bool StateOpen = true;
       
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        //private void FileTab_Click(object sender, RoutedEventArgs e)
        //{
        //    int index = int.Parse(((MenuItem)e.Source).Uid);

        //    switch (index)
        //    {
        //        case 0:
        //            if (StateOpen)
        //            {
        //                Container.Children.Clear();
        //                Container.Children.Add(new LeftMenu());
        //            }
        //            else
        //            {
        //                Container.Children.Clear();
        //            }
        //            StateOpen = !StateOpen;
        //            break;
        //        case 1:

        //            if (StateOpen)
        //            {
        //                Container.Children.Clear();
        //                home.Background = new SolidColorBrush(Colors.LightGray);
        //                Container2.Children.Add(new UpperMenu());
        //            }
        //            else
        //            {
        //                Container2.Children.Clear();
        //                home.Background = new SolidColorBrush(Colors.WhiteSmoke);
        //            }
        //            StateOpen = !StateOpen;
        //            break;

        //        default:
        //            Container.Children.Clear();
        //            Container2.Children.Clear();
        //            break;
        //    }

        //}
    }

}
