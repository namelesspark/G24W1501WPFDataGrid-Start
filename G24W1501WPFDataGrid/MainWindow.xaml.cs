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

namespace G24W1501WPFDataGrid;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{   
    protected List<GundamModel> GundamList = new List<GundamModel>();
    public MainWindow()
    {
        InitializeComponent();

        GundamGrid.ItemsSource = GundamList;

        GundamList.Add(new GundamModel("건담", "RX-78-2", "연방군"));
        GundamList.Add(new GundamModel("자쿠II", "MS-06", "지온군"));
    }

    public void OnAdd(object sender, RoutedEventArgs e)
    {
        GundamList.Add(new GundamModel("건탱크", "RX-75-4", "연방군"));
        GundamGrid.Items.Refresh();
    }
}