using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Strings.Test
{
    public class FloatIssueTests
    {
        [Fact]
        public void WhenComparisonInFloat()
        {
            Assert.Equal(0.3, 0.1 + 0.1 + 0.1);
        }

        [Fact]
        public void WhenComparisonInDecimal()
        {
            Assert.Equal(0.3M, 0.1M + 0.1M + 0.1M);
        }
    }
}
