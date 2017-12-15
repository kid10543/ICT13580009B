using Xamarin.Forms;

namespace ICT13580009B
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var np = new NavigationPage(new NavPage1());

            var tp = new TabbedPage();

            tp.Children.Add(new TabbedPage1());
            tp.Children.Add(new TabbedPage2());
            tp.Children.Add(new TabbedPage3());

            var cp = new CarouselPage();
            cp.Children.Add(new TabbedPage1());
            cp.Children.Add(new TabbedPage2());
            cp.Children.Add(new TabbedPage3());

            MainPage = cp ;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
