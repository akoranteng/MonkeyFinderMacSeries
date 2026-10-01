using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MonkeyFinder.Models;
using MonkeyFinder.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MonkeyFinder.ViewModels;

public partial class MonkeysViewModel : BaseViewModel
{
    private readonly MonkeyService _service;

    public ObservableCollection<Monkey> Monkeys { get; } = new();

    // Parameterless constructor for XAML
    public MonkeysViewModel() : this(new MonkeyService())
    {
    }

    // DI-friendly constructor
    public MonkeysViewModel(MonkeyService service)
    {
        _service = service;
        Title = "Monkey Finder";

        // Load data immediately so the page is never blank
        _ = LoadMonkeysAsync();
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
        }
        finally
        {
            IsBusy = false;
        }
    }
}
