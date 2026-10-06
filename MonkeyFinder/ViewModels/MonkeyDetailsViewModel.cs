using MonkeyFinder.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MonkeyFinder.ViewModels;

[QueryProperty(nameof(Monkey), "Monkey")]
public partial class MonkeyDetailsViewModel : ObservableObject
{
    [ObservableProperty]
    Monkey monkey;
}
