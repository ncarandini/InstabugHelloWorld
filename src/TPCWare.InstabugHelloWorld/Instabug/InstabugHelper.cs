using Xamarin.Forms;

namespace TPCWare.InstabugHelloWorld
{
    public static class InstabugHelper
    {
        public static void Login(string email, string name)
        {
            IInstabug instabug = DependencyService.Get<IInstabug>();
            instabug.IdentifyUser(email ?? "unknown@email.com", name ?? "Unknown");
        }

        public static void Logout()
        {
            IInstabug instabug = DependencyService.Get<IInstabug>();
            instabug.Logout();
        }
    }
}
