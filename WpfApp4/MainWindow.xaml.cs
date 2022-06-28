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

namespace WpfApp4
{
    public struct TextMessageModel
    {
        public string? Text { get; set; }
        public string? CreationDate { get; set; }
    }


    public partial class MainWindow : Window
    {
        public List<TextMessageModel> Messages { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Messages = new List<TextMessageModel>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Messages.Add(new TextMessageModel { Text = tbox.Text, CreationDate = DateTime.Now.TimeOfDay.ToString() });

            foreach (var message in Messages)
            {
                listv.Items.Add(message.CreationDate);
                listv.Items.Add(message.Text);
            }

            tbox.Text = string.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.HorizontalAlignment = HorizontalAlignment.Right;
            menu.VerticalAlignment = VerticalAlignment.Bottom;
            menu.Items.Add("Report");
            menu.Items.Add("Block");
            menu.Items.Add("Mute");
            menu.Items.Add("Clear chat");

            grid.Children.Add(menu);
            
        }
        
    }

}
