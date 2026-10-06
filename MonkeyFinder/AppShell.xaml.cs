using MonkeyFinder.Views;

namespace MonkeyFinder
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // ⭐ REQUIRED: Register navigation routes
            Routing.RegisterRoute(nameof(MonkeyDetailsPage), typeof(MonkeyDetailsPage));
        }
    }
}
