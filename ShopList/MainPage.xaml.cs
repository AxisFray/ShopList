using System.Collections.ObjectModel;
using System.Globalization;
using static ShopList.MainPage;
using Microsoft.Maui.Graphics;



namespace ShopList
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public ObservableCollection<Produkt> Produkty { get; set; }
        public class Produkt
        {
            public string Nazwa { get; set; }
            public bool IsDone { get; set; }
        }

        public MainPage()
        {
            InitializeComponent();
            Produkty = new ObservableCollection<Produkt>
        {
            new Produkt { Nazwa = "Apple"},
            new Produkt { Nazwa = "Mango"}
        };
            BindingContext = this;
        }

        public void OnAddClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ItemEntry.Text))
            {
                Produkty.Add(new Produkt { Nazwa = ItemEntry.Text });
                ItemEntry.Text = string.Empty;
            }
        }
        
        private void Done(object sender, EventArgs e)
        {
            var button = sender as Button;
            var produkt = button?.BindingContext as Produkt;
            if (produkt != null && Produkty.Contains(produkt))
            {
                Produkty.Remove(produkt);
            }
        }
        private void OnLabelTapped(object sender, EventArgs e)
        {
            var label = sender as Label;
            var produkt = label?.BindingContext as Produkt;

            if (produkt != null)
            {
                produkt.IsDone = true;

                // Przenieś na koniec listy
                Produkty.Remove(produkt);
                Produkty.Add(produkt);
                
            }
        }

        
        

    }
}
