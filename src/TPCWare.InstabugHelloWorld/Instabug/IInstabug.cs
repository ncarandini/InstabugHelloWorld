namespace TPCWare.InstabugHelloWorld
{
    public interface IInstabug
    {
        void IdentifyUser(string email, string name);

        void SetUserAttribute(string attributeName, string attributeValue);

        void Logout();
    }
}
