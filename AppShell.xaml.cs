using TravelExpenseTracker.Pages;

namespace TravelExpenseTracker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //aDDIN THE rEGISTER pAGE
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        }
    }
}
