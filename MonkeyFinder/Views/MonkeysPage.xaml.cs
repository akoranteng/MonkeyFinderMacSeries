using MonkeyFinder.ViewModels;

namespace MonkeyFinder.Views;

public partial class MonkeysPage : ContentPage
{
    public MonkeysPage()
    {
        InitializeComponent();
        BindingContext = new MonkeysViewModel();
    }
}
