using ExtensionMethods;
using System;
using Xunit;

namespace AdvancedTest
{
    public class UnitTest1
    {
        [Fact]
        public void Shold_Error_If_NumberOfWord_Be_Minus_Zero()
        {
            var post = "";
            Assert.Throws<ArgumentOutOfRangeException>(() => post.Shorten(-2));
        }


        [Fact]
        public void Shold_String_Empty()
        {
            var post = "";
            Assert.Equal("", post.Shorten(1));
        }
    }
}
