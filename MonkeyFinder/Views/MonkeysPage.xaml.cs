using MonkeyFinder.ViewModels;

namespace MonkeyFinder.Views;

public partial class MonkeysPage : ContentPage
{
    public MonkeysPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is MonkeysViewModel vm)
            await vm.LoadMonkeysAsync();
    }
}
