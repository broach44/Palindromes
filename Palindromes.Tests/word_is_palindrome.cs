using System;
using Xunit;

namespace Palindromes.Tests
{
    public class Word_is_palindrome
    {
        [Fact]
        public void Check_If_Stars_Is_Palindrome()
        {
            //Stars = false
            //Arrange
            var word = "Stars";
            var wordFlipper = new Flipper();

            //Act
            var actualResult = wordFlipper.WordFlip(word);
            //Assert
            Assert.False(actualResult);
        }

        [Fact]
        public void Check_If_OaKakUwakovLil()
        {
            //O, a kak Uwakov lil vo kawu kakao! = true
            //Arrange
            var word = "O, a kak Uwakov lil vo kawu kakao!";
            var wordFlipper = new Flipper();

            //Act
            var actualResult = wordFlipper.WordFlip(word);

            //Assert
            Assert.True(actualResult);

        }

        [Fact]
        public void Check_If_SomeMenInterpret()
        {
            //Some men interpret nine memos = true
            //Arrange
            var word = "Some men interpret nine memos";
            var wordFlipper = new Flipper();

            //Act
            var actualResult = wordFlipper.WordFlip(word);

            //Assert
            Assert.True(actualResult);
        }

        [Fact]
        public void Check_If_Tacocat()
        {
            //tacocat = true
            //Arrange
            var word = "Tacocat";
            var wordFlipper = new Flipper();

            //Act
            var actualResult = wordFlipper.WordFlip(word);

            //Assert
            Assert.True(actualResult);
        }

        [Fact]
        public void Check_If_Crystal()
        {
            //crystal = false
            //Arrange
            var word = "Crystal";
            var wordFlipper = new Flipper();

            //Act
            var actualResult = wordFlipper.WordFlip(word);

            //Assert
            Assert.False(actualResult);
        }
    }


}
