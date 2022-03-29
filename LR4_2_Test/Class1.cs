using LR4_2_WORK;
using System;
using Xunit;

namespace LR4_2_Test
{
    public class StringHandlerTests

    {

        [Fact]

        public void ChangeLastInclude_WithEmptyStr()

        {

            var actual = StringHandler.ChangeLastInclude("", 'a', 'z');

            var expected = "";

            Assert.Equal(expected, actual);

        }

        [Fact]

        public void ChangeLastInclude_WithAStr()

        {

            var actual = StringHandler.ChangeLastInclude("baaam", 'a', 'z');

            var expected = "baz";

            Assert.Equal(expected, actual);

        }

    }

}