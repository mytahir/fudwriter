using System.Windows;
using Fluent;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

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

        void onDragDelta(object sender, DragDeltaEventArgs e)
        {
            //Move the Thumb to the mouse position during the drag operation
            double yadjust = myCanvasStretch.Height + e.VerticalChange;
            double xadjust = myCanvasStretch.Width + e.HorizontalChange;
            if ((xadjust >= 0) && (yadjust >= 0))
            {
                myCanvasStretch.Width = xadjust;
                myCanvasStretch.Height = yadjust;
                Canvas.SetLeft(myThumb, Canvas.GetLeft(myThumb) +
                                        e.HorizontalChange);
                Canvas.SetTop(myThumb, Canvas.GetTop(myThumb) +
                                        e.VerticalChange);
                //changes.Text = "Size: " +
                //                myCanvasStretch.Width.ToString() +
                //                 ", " +
                //                myCanvasStretch.Height.ToString();
            }
        }

        private void myThumb_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Cursor cur = Cursors.SizeNWSE;
            this.Cursor = cur;
        }

        private void myThumb_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Cursor cur = Cursors.Arrow;
            this.Cursor = cur;
        }

        void onDragStarted(object sender, DragStartedEventArgs e)
        {
            myThumb.Background = Brushes.White;
        }

        void onDragCompleted(object sender, DragCompletedEventArgs e)
        {
            myThumb.Background = Brushes.Blue;
            myInk.Height = myCanvasStretch.Height;
            myInk.Width = myCanvasStretch.Width;
            canvasContainer.Margin = new Thickness(0,0,0,20);
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
