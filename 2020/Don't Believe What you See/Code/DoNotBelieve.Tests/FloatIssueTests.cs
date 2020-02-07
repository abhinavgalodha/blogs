using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Strings.Test
{
    public class FloatIssueTests
    {
        [Fact]
        public void WhenDecimalComparisonInFloat()
        {
            Assert.Equal(0.3, 0.1 + 0.1 + 0.1);
        }
    }
}
