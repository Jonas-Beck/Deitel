using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace Ex_2306
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void startButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "Calculating...";
            startButton.IsEnabled = false;

            Task<long> totalLines = Task.Run(() => modifyTextFile());
            //long totalLines = modifyTextFile();

            await totalLines;

            resultLabel.Content = totalLines.Result.ToString();
            startButton.IsEnabled = true;

        }

        private long modifyTextFile()
        {

            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = Path.Combine(docPath, "WriteLines.Txt");

            // Total Lines counter
            long totalLines = 0;

            // Start stopwatch
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Loop for min 5 seconds
            while (stopwatch.Elapsed.TotalSeconds < 5)
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    // Write 10000 lines in WriteLine.txt
                    for (int i = 0; i < 10000; i++)
                    {
                        streamWriter.WriteLine(" Ut faucibus rutrum ligula, quis vehicula ipsum luctus ut. Nam ultricies mauris molestie nunc vestibulum ullamcorper. Sed eget porttitor nisl. Nam imperdiet metus enim, eget consequat odio varius eu. Donec aliquet erat ligula. Nulla aliquam ultrices mi, vel varius magna varius eget. Phasellus et augue nibh. Curabitur iaculis at mauris ac sollicitudin. Suspendisse vitae rhoncus lectus. Nunc id sapien et eros vulputate tempus eget eget metus. Maecenas sollicitudin erat et faucibus pulvinar. Proin ac orci tellus. ");
                        totalLines++;
                    }
                }

                using (StreamWriter writer = new StreamWriter(path))
                {
                    // Clear all lines
                }

            }

            stopwatch.Stop();

            // Return total amount of lines printed 
            return totalLines;
        }
    }
}
