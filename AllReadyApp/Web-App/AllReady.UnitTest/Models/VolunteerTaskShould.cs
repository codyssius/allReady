using System;
using AllReady.Models;
using Xunit;

namespace AllReady.UnitTest.Models
{
    public class VolunteerTaskShould
    {
        [Fact]
        public void IsClosed_ShouldBeTrue_IfEndDatePriorToCurrentDate()
        {
            var task = new VolunteerTask { EndDateTime = DateTime.UtcNow.AddDays(-1) };
            Assert.True(task.IsClosed);
        }

        [Fact]
        public void IsClosed_ShouldBeFalse_IfEndDateLaterThanCurrentDate()
        {
            var task = new VolunteerTask { EndDateTime = DateTime.UtcNow.AddDays(1) };
            Assert.False(task.IsClosed);
        }
    }
}
