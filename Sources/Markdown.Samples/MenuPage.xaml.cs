﻿using Xamarin.Forms;

namespace MarkdownView.Samples
{
    public partial class MenuPage : ContentPage
    {
        public class Item
        {
            public Item(string title, string url)
            {
                Title = title;
                Url = url;
            }
            public string Title { get; }

            public string Url { get; }
        }

        public Item[] Items { get; } =
        {
            new Item("Embedded", ""),
            new Item("MarkdownView", "https://raw.githubusercontent.com/aloisdeniel/MarkdownView/master/README.md"),
            new Item("Markdig", "https://raw.githubusercontent.com/lunet-io/markdig/master/readme.md"),
            new Item("Xamarin.Forms", "https://raw.githubusercontent.com/xamarin/Xamarin.Forms/master/README.md"),
        };

        public MenuPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            MessagingCenter.Send(this, "theme", e.Value ? "dark" : "light");
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Item;
            MessagingCenter.Send(this, "new_md", item.Url);
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }
    }
}