namespace JopApplicationLibrary.Services
{
    public interface IIdentityValidator
    {
        bool IsValid(string identityNumber);
    }
}