using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Drawing;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            previewTextBlock.Text = textoTextBox.Text;
            previewTextBlock.TextAlignment = TextAlignment.Center;
            previewTextBlock.FontSize = 20d;
            if (azulRadioButton.IsChecked == true)
                previewTextBlock.Foreground = Brushes.Blue;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            previewTextBlock.FontWeight = FontWeights.Bold;
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            previewTextBlock.FontWeight = FontWeights.Normal;
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            previewTextBlock.FontStyle = FontStyles.Italic;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            previewTextBlock.FontStyle = FontStyles.Normal;
        }

        private void azulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            previewTextBlock.Foreground = Brushes.Blue;
        }

        private void rojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            previewTextBlock.Foreground = Brushes.Red;
        }

        private void verdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            previewTextBlock.Foreground = Brushes.Green;
        }
    }
}