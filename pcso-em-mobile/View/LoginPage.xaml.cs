using pcso_em_mobile.ViewModel;

namespace pcso_em_mobile.View;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();
		BindingContext = loginViewModel;
	}
}