using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF_examples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Colors { get; set; } = new ObservableCollection<string>();
        public Movie CurrentMovie { get; set; } = new Movie();

        public MainWindow()
        {
            Colors.Add("Red");
            Colors.Add("Green");
            Colors.Add("Blue");
            Colors.Add("Black");
            Colors.Add("White");

            InitializeComponent();

            myButton.FontSize = 20;
            myTextBlock.Text = "Overriden text";

            TextBlock myTb = new TextBlock
            {
                Text = "Hello world!"
            };

            myTb.Inlines.Add(" (added using inlines)");
            //this.Content = myTb;

            // widok przygotowany na data binding z tej klasy
            //DataContext = this;
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Foreground = Brushes.Red;
        }

        private void myButton_MouseEnter(object sender, MouseEventArgs e)
        {
            myLabel.FontSize++;
        }

        private void myButton_MouseLeave(object sender, MouseEventArgs e)
        {
            myLabel.FontSize--;
        }

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (tbSliderValue != null)
            {
                tbSliderValue.Text = mySlider.Value.ToString();
            }
        }

        private void BtnAddColour_Click(object sender, RoutedEventArgs e)
        {
            Colors.Add(tbAddColour.Text);
        }

        private void BtnIncreasePb_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Value += 10;
        }

        private void BtnPage1_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new Page1();
        }

        private void BtnPage2_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new Page2();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                textBlock.Text = "Wprowadzono: " + textBox.Text;
        }
    }
}
