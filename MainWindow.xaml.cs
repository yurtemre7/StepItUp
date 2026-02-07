using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StepItUp
{
    public partial class MainWindow : Window
    {
        private int count = 0;

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);


        private static void FocusGameWindow(string processName)
        {
            // Attempt to locate the game process
            var processes = Process.GetProcessesByName(processName);
            Console.WriteLine(processes.Length);
            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine(processes[i].MainWindowTitle);
            }

            if (processes.Length > 0)
            {
                // If the process is found, attempt to set it as the foreground window
                SetForegroundWindow(processes[0].MainWindowHandle);
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            // Load the settings
            count = Properties.Settings.Default.CounterValue;
            numberLabel.Content = count.ToString();
            maxTextBox.Text = Properties.Settings.Default.MaxText;
            topicTextBox.Text = Properties.Settings.Default.CounterText;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to reset the count and label?", "Confirm Reset", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                count = 0;
                numberLabel.Content = count.ToString();
                topicTextBox.Text = "";
                maxTextBox.Text = "";

                Properties.Settings.Default.CounterText = "";
                Properties.Settings.Default.MaxText = "";
                Properties.Settings.Default.CounterValue = 0;
                Properties.Settings.Default.Save();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            count++;
            numberLabel.Content = count.ToString();

            Properties.Settings.Default.CounterValue = count;
            Properties.Settings.Default.Save();

            FocusGameWindow("x2");
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (count == 0)
            {
                return;
            }
            count--;
            numberLabel.Content = count.ToString();

            Properties.Settings.Default.CounterValue = count;
            Properties.Settings.Default.Save();

            FocusGameWindow("x2");
        }

        private void CounterText_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Save the text setting
            Properties.Settings.Default.CounterText = topicTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void MaxText_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Save the text setting
            Properties.Settings.Default.MaxText = maxTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
