using MonkeyFinder.ViewModels;

namespace MonkeyFinder.Views;

public partial class MainPage : ContentPage
{
    private readonly MonkeysViewModel _viewModel;

    public MainPage(MonkeysViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (_viewModel.Monkeys.Count == 0)
            await _viewModel.LoadMonkeysAsync();
    }
}