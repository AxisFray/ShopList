using System.Threading.Tasks;

namespace ShopList;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async Task Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("MainPage");
    }
}