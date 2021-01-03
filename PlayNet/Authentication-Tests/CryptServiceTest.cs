using Authentication.Microservice.Helpers;

using Xunit;

namespace Authentication_Tests
{
    public class CryptServiceTest
    {

        [Fact]
        public void Decrypt_Encryption_Equals_PlainText()
        {
            // Arrange
            CryptService cryptService = new CryptService();
            string plainText = "text_to_encrypt";

            // Act
            string encryption = cryptService.EncryptString(plainText);
            string decryption = cryptService.DecryptString(encryption);

            //Assert
            Assert.Equal(plainText, decryption);
        }
    }
}
