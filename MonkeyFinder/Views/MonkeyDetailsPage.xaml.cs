using MonkeyFinder.Models;
using MonkeyFinder.ViewModels;

namespace MonkeyFinder.Views;

public partial class MonkeyDetailsPage : ContentPage
{
    public MonkeyDetailsPage()
    {
        InitializeComponent();
        BindingContext = new MonkeyDetailsViewModel();
    }
}
