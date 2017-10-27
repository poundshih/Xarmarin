using Xamarin.Forms;

namespace Hello
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new HelloPage();
            MainPage = new ReflectedColorsPage();
            /*
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "hello world!!"
                        } 
                    }
                }
            };
            */
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
