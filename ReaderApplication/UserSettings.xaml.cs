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
using System.Windows.Shapes;
using ReaderApplication.Properties;

namespace ReaderApplication
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class UserSettings : Window
    {
        public UserSettings()
        {
            InitializeComponent();
            Loaded += OnStart;
        }
        private void OnStart(object sender, System.EventArgs e) 
        {
            var numb = (double)Properties.Settings.Default["VoiceSpeed"];
            ReadingSpeedSlider.Value = numb;
        }

        private void RadioButton_Checked_Male_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you clicked male button 1");
        }

        private void RadioButton_Checked_Male_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you clicked male button 2");
        }

        private void RadioButton_Checked_Female_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you clicked female button 1");
        }

        private void RadioButton_Checked_Female_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you clicked female button 2");
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default["VoiceSpeed"] = ReadingSpeedSlider.Value;
            Properties.Settings.Default.Save();
        }

    }
}
