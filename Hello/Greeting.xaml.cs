using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Hello
{
    public partial class Greeting : ContentPage
    {
        public Greeting()
        {
            InitializeComponent();

            Content = new Label
            {
                Text = "Greeting Page!!",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,

            };

            //Padding = GetPagePadding();

        }

        public static Thickness GetPagePadding()
        {
            double topPadding;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    topPadding = 20;
                    break;
                default:
                    topPadding = 0;
                    break;
            }

            return new Thickness(5, topPadding, 5, 0);
        }
    }
}
