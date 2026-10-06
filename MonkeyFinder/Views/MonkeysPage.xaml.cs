using MonkeyFinder.ViewModels;
using MonkeyFinder.Models;   // ⭐ REQUIRED

namespace MonkeyFinder.Views;

public partial class MonkeysPage : ContentPage
{
    public MonkeysPage()
    {
        InitializeComponent();
        System.Diagnostics.Debug.WriteLine(">>> MonkeysPage constructor ran");
        //throw new Exception("THIS IS THE REAL MONKEYSPAGE CONSTRUCTOR");

        BindingContext = new MonkeysViewModel();   // ⭐ REQUIRED
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is MonkeysViewModel vm)
            await vm.LoadMonkeysAsync();
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    if (e.CurrentSelection.FirstOrDefault() is Monkey monkey)
    {
        System.Diagnostics.Debug.WriteLine(">>> SelectionChanged fired — " + monkey.Name);

        if (BindingContext is MonkeysViewModel vm)
            vm.GoToDetailsCommand.Execute(monkey);
    }
}


}
