
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Unicode.Test
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class StringTests
    {
        [Fact]
        public void WhenStringContains_UnEscapedBackSlash_ThenSplit()
        {
            // Arrange
            var givenString = "Company\vendorid";

            // Act
            var splittedArray = givenString.Split(@"\");

            // Assert
            Assert.Equal(2, splittedArray.Length);

            //var firstStringWithSpaces = "  ";
            //var secondStringWithSpaces = "  ";
            //var resultSpaceComaprison = firstStringSpace === secondStringSpace;
        }

        [Fact]
        public void WhenStringContains_BackSlash_WithVerbatimString_ThenSplit_Working()
        {
            // Arrange
            var givenString = @"Company\vendorid";

            // Act
            var splittedArray = givenString.Split(@"\");

            // Assert
            Assert.Equal(2, splittedArray.Length);
        }

        [Fact]
        public void WhenStringContains_BackSlashWithEscapeCharacter_ThenSplit_Working()
        {
            // Arrange
            var givenString = "Company\\vendorid";

            // Act
            var splittedArray = givenString.Split(@"\");

            // Assert
            Assert.Equal(2, splittedArray.Length);
        }

        [Fact]
        public void WhenStringContains_SpacesWithEmptyCUnEscapedBackSlash_ThenSplit()
        {
            var firstStringWithSpaces = "  ";
            var secondStringWithSpaces = "  ";
            Assert.Equal(firstStringWithSpaces, secondStringWithSpaces);
        }
        
    }
}
