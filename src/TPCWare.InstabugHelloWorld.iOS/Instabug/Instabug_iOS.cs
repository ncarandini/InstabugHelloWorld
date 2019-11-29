using InstabugLib;
using TPCWare.InstabugHelloWorld.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(Instabug_iOS))]
namespace TPCWare.InstabugHelloWorld.iOS
{
    class Instabug_iOS : IInstabug
    {
        public void IdentifyUser(string email, string name)
        {
            Instabug.IdentifyUserWithEmail(email, name);
        }

        public void Logout()
        {
            Instabug.LogOut();
        }

        public void SetUserAttribute(string attributeName, string attributeValue)
        {
            Instabug.SetUserAttribute(attributeName, attributeValue);
        }
    }
}