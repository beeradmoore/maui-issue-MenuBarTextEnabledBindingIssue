namespace MenuBarTextEnabledBindingIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageModel();
	}
}