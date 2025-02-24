using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Polyline sky { get; set; }
    private bool isSky { get; set; } = true;

    public MainWindow()
    {
        InitializeComponent();



        sky = new Polyline();
        sky.Points = new PointCollection()
        {
            new Point(0,0),
            new Point(0,300),
            new Point(800,300),
            new Point(800,0)
        };
        var skybrush = new SolidColorBrush(Color.FromRgb(176, 224, 230));
        sky.Fill = skybrush;

        var ground = new Polyline();
        ground.Points = new PointCollection()
        {
            new Point(0, 300),
            new Point(800, 300),
            new Point(800, 600),
            new Point(0, 600)
        };
        var grbrush = new SolidColorBrush(Color.FromRgb(154, 205, 50));
        ground.Fill = grbrush;

        var home1 = new Polyline();
        home1.Points = new PointCollection()
        {
            new Point(100,500),
            new Point(100,300),
            new Point(250,200),
            new Point(400,300),
            new Point(400,500),
            new Point(100,500)
        };
        var hmbrush = new SolidColorBrush(Color.FromRgb(139, 69, 19));
        home1.Fill = hmbrush;
        home1.Stroke = Brushes.Black;

        var home2 = new Polyline();
        home2.Points = new PointCollection()
        {
            new Point(400,500),
            new Point(500,400),
            new Point(500,200),
            new Point(400,300)
        };
        home2.Fill = hmbrush;
        home2.Stroke = Brushes.Black;

        var krysha1 = new Polyline();
        krysha1.Points = new PointCollection()
        {
            new Point(250,200),
            new Point(70,320),
            new Point(70,310),
            new Point(250,190),
            new Point(430,310),
            new Point(430,320),
            new Point(250,200)
        };

        var kryshbrush = new SolidColorBrush(Color.FromRgb(184, 134, 11));
        krysha1.Fill = kryshbrush;
        krysha1.Stroke = Brushes.Black;

        var krysha2 = new Polyline();
        krysha2.Points = new PointCollection()
        {
            new Point(430,310),
            new Point(530,210),
            new Point(530,220),
            new Point(430,320),
            new Point(430,310)
        };
        krysha2.Fill = kryshbrush;
        krysha2.Stroke = Brushes.Black;

        var krysha3 = new Polyline();
        krysha3.Points = new PointCollection()
        {
            new Point(250,190),
            new Point(350,90),
            new Point(530,210),
            new Point(430,310),
            new Point(250,190)
        };
        krysha3.Fill = kryshbrush;
        krysha3.Stroke = Brushes.Black;

        var krysha4 = new Polyline();
        krysha4.Points = new PointCollection()
        {
            new Point(70,310),
            new Point(170,210),
            new Point(350,90),
            new Point(250,190),
            new Point(70,310)
        };
        krysha4.Fill = kryshbrush;
        krysha4.Stroke = Brushes.Black;

        var wn1 = new Polyline();
        wn1.Points = new PointCollection()
        {
            new Point(120,460),
            new Point(120,400),
            new Point(180,400),
            new Point(180,460),
            new Point(120,460)
        };

        var windbrush = new SolidColorBrush(Color.FromRgb(176, 224, 230));
        wn1.Fill = windbrush;
        wn1.Stroke = Brushes.Black;

        var wn2 = new Polyline();
        wn2.Points = new PointCollection()
        {
            new Point(320,460),
            new Point(320,400),
            new Point(380,400),
            new Point(380,460),
            new Point(320,460)
        };
        wn2.Fill = windbrush;
        wn2.Stroke = Brushes.Black;

        var wn3 = new Polyline();
        wn3.Points = new PointCollection()
        {
            new Point(180,360),
            new Point(320,360),
            new Point(320,320),
            new Point(260,260),
            new Point(240,260),
            new Point(180,320),
            new Point(180,360)

        };
        wn3.Fill = windbrush;
        wn3.Stroke = Brushes.Black;

        var wn4 = new Polyline();
        wn4.Points = new PointCollection()
        {
            new Point(420,440),
            new Point(480,380),
            new Point(480,320),
            new Point(420,380),
            new Point(420,440)


        };
        wn4.Fill = windbrush;
        wn4.Stroke = Brushes.Black;

        var door = new Polyline();
        door.Points = new PointCollection()
        {
            new Point(220,500),
            new Point(220,400),
            new Point(280,400),
            new Point(280,500),
            new Point(220,500)
        };
        var doorbrush = new SolidColorBrush(Color.FromRgb(160, 82, 45));
        door.Fill = doorbrush;
        door.Stroke = Brushes.Black;

        grid.Children.Add(sky);
        grid.Children.Add(ground);
        grid.Children.Add(home1);
        grid.Children.Add(home2);
        grid.Children.Add(krysha1);
        grid.Children.Add(krysha2);
        grid.Children.Add(krysha3);
        grid.Children.Add(krysha4);
        grid.Children.Add(door);
        grid.Children.Add(wn1);
        grid.Children.Add(wn2);
        grid.Children.Add(wn3);
        grid.Children.Add(wn4);



    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        sky.Fill = isSky
            ? new SolidColorBrush(Color.FromRgb(25, 25, 112))
            : new SolidColorBrush(Color.FromRgb(176, 224, 230));
        isSky = !isSky;
    }

}