using System.Collections.ObjectModel;
using MonkeyFinder.Models;
using MonkeyFinder.Services;

namespace MonkeyFinder.ViewModels;

public partial class MonkeysViewModel : BaseViewModel
{
    private readonly MonkeyService _service;

    public ObservableCollection<Monkey> Monkeys { get; } = new();

    public MonkeysViewModel(MonkeyService service)
    {
        Title = "Monkey Finder";
        _service = service;
    }

    [RelayCommand]
    public async Task LoadMonkeysAsync()
    {
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;

            var monkeys = await _service.GetMonkeysAsync();

            Monkeys.Clear();
            foreach (var monkey in monkeys)
                Monkeys.Add(monkey);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to load monkeys: {ex.Message}");
            await Shell.Current.DisplayAlert("Error", "Unable to load monkeys.", "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
}
