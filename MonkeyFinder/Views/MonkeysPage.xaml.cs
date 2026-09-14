using MonkeyFinder.Models;
using MonkeyFinder.ViewModels;

namespace MonkeyFinder.Views;

public partial class MonkeysPage : ContentPage
{
    public MonkeysPage()
    {
        InitializeComponent();
        BindingContext = new MonkeysViewModel();
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Monkey monkey)
        {
            await Navigation.PushAsync(new MonkeyDetailsPage(monkey));
        }
    }
}
