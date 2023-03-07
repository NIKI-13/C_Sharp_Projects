using System.Net;
using System.Windows;

namespace CHECK_INTERNET
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool result=checkInternet();
            if(result==true)
            {
                MessageBox.Show ("YOU ARE CONNECTED!");
            }
            else
            {
                MessageBox.Show("NO INTERNET!");
            }
        }

        private bool checkInternet()
        {
            WebRequest request = WebRequest.Create("http://www.google.com");
            WebResponse response;

            try
            {
                response=request.GetResponse();
                response.Close();
                request = null;
                return true;
            }

            catch
            {
                request = null;
                return false;
            }
        }
    }
}
