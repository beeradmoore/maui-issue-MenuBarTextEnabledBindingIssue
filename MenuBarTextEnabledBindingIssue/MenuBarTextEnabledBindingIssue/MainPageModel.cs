using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MenuBarTextEnabledBindingIssue;

public partial class MainPageModel : ObservableObject
{
	[ObservableProperty]
	[NotifyPropertyChangedFor(nameof(MenuBarItemText))]
	[NotifyPropertyChangedFor(nameof(MenuFlyoutItemText))]
	[NotifyPropertyChangedFor(nameof(IsOddClicks))]
	[NotifyPropertyChangedFor(nameof(ButtonLabel))]
	int buttonTaps = 0;


	public string MenuBarItemText => $"Menu - {ButtonTaps}";
	public string MenuFlyoutItemText => $"Flyout - {ButtonTaps}";
	public bool IsOddClicks => (ButtonTaps % 2 == 0);
	public string ButtonLabel => ButtonTaps == 0 ? "Click me" : $"Clicked {ButtonTaps} times";

	[RelayCommand]
	void ButtonTapped()
	{
		++ButtonTaps;
	}
}