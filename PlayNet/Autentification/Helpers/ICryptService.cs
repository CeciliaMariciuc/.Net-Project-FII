namespace Authentication.Microservice.Helpers
{
    public interface ICryptService
    {
        string DecryptString(string encrString);
        string EncryptString(string strEncrypted);
    }
}