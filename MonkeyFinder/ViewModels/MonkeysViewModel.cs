using System.Collections.ObjectModel;
using MonkeyFinder.Models;
using MonkeyFinder.Services;

namespace MonkeyFinder.ViewModels;

public class MonkeysViewModel : BaseViewModel
{
    public ObservableCollection<Monkey> Monkeys { get; } = new();

    public MonkeysViewModel()
    {
        Title = "Monkey Finder";
        LoadMonkeysFromService();
    }

    void LoadMonkeysFromService()
    {
        Monkeys.Clear();

        var service = new MonkeyService();
        var items = service.GetMonkeys();

        foreach (var monkey in items)
            Monkeys.Add(monkey);
    }
}
