using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using Xunit;
using Xunit.Sdk;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Get_TestClassObject()
        {
            //Arrange
            var testObject = new TestClass();

            var context = new Mock<DbContext>();
            var dbSetMock = new Mock<DbSet<TestClass>>();

            context.Setup(x => x.Set<TestClass>()).Returns(dbSetMock.Object);
            dbSetMock.Setup(x => x.Find(It.IsAny<int>())).Returns(testObject);

            // Act
            var repository = new MovieRepository<TestClass>(context.Object);
            repository.Get(1);

            // Assert
            context.Verify(x => x.Set<TestClass>());
            dbSetMock.Verify(x => x.Find(It.IsAny<int>()));

        }
    }
}
