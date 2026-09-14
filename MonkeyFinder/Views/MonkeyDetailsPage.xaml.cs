using MonkeyFinder.Models;

namespace MonkeyFinder.Views;

public partial class MonkeyDetailsPage : ContentPage
{
    public MonkeyDetailsPage(Monkey monkey)
    {
        InitializeComponent();
        BindingContext = monkey ?? throw new ArgumentNullException(nameof(monkey));
    }
}
