using android_cloud_test.Logic;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject
{
    public class NamesTest
    {
        [Fact]
        public void AddName_NormalName_ReturnsName()
        {
            //Arrange
            String name = "John Doe";
            List<String> namesList = new List<String>();
            Names names = new Names(namesList);

            // Act
            String addedName = names.AddName(name);

            // Assert
            Assert.Equal(name, addedName);
        }

        [Fact]
        public void AddName_NullName_ThrowsException()
        {
            //Arrange
            String name = null;
            List<String> namesList = new List<String>();
            Names names = new Names(namesList);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => names.AddName(name));
        }

        [Theory]
        [InlineData("Toni Vučić", "Toni Vučić")]
        public void AddName_BosnianName_ReturnsName(String name, String expected)
        {
            //Arrange
            List<String> namesList = new List<String>();
            Names names = new Names(namesList);

            // Act
            String addedName = names.AddName(name);

            // Assert
            Assert.Equal(name, addedName);
        }
    }
}
