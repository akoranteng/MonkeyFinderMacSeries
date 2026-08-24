using System.Collections.ObjectModel;
using MonkeyFinder.Models;

namespace MonkeyFinder.ViewModels;

public class MonkeysViewModel : BaseViewModel
{
    public ObservableCollection<Monkey> Monkeys { get; } = new();

    public MonkeysViewModel()
    {
        Title = "Monkey Finder";
        LoadMonkeys();
    }

    void LoadMonkeys()
    {
        Monkeys.Clear();

        Monkeys.Add(new Monkey
        {
            Name = "Baboon",
            Location = "Africa"
        });

        Monkeys.Add(new Monkey
        {
            Name = "Capuchin Monkey",
            Location = "South America"
        });

        Monkeys.Add(new Monkey
        {
            Name = "Blue Monkey",
            Location = "Central Africa"
        });

        Monkeys.Add(new Monkey
        {
            Name = "Squirrel Monkey",
            Location = "Central & South America"
        });

        Monkeys.Add(new Monkey
        {
            Name = "Golden Lion Tamarin",
            Location = "Brazil"
        });
    }
}
