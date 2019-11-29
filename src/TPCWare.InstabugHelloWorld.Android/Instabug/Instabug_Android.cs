using Com.Instabug.Library;
using TPCWare.InstabugHelloWorld.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(Instabug_Android))]
namespace TPCWare.InstabugHelloWorld.Droid
{
    class Instabug_Android : IInstabug
    {
        public void IdentifyUser(string email, string name)
        {
            Instabug.IdentifyUser(email, name);
        }

        public void Logout()
        {
            Instabug.LogoutUser();
        }

        public void SetUserAttribute(string attributeName, string attributeValue)
        {
            Instabug.SetUserAttribute(attributeName, attributeValue);
        }
    }
}