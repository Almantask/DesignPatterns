using DesignPatternsLesson1.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternLesson1Core.Tests
{
    public class PersonCompareTests
    {
        [Fact]
        public void ComparePerson_NoParent_Ok()
        {
            var bday = DateTime.Parse("2000-05-05");

            var person1 = new Person("Thomas", bday, 50, 160);
            var person2 = new Person("Thomas", bday, 50, 160);

            Assert.Equal(person1, person2);
        }
    }
}
