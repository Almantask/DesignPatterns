using DesignPatternsLesson1.Core;
using System;
using Xunit;

namespace DesignPatternLesson1Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ClonePerson_Shallow_Ok()
        {
            var bday = DateTime.Parse("2000-05-05");

            var person1 = new Person("Thomas", bday, 50, 160);
            var person2 = person1.Clone();

            Assert.Equal(person1, person2);
        }

        [Fact]
        public void ClonePerson_Deep_Ok()
        {
            var bdayFather = DateTime.Parse("1981-01-05");
            var father = new Person("Thomas The Great", bdayFather, 50, 160);

            var bdayMother = DateTime.Parse("1982-01-04");
            var mother = new Person("Jaina", bdayMother, 50, 160);

            var bday = DateTime.Parse("2000-05-05");
            var person1 = new Person("Thomas", bday, 50, 160, mother, father);

            var person2 = person1.Clone();

            Assert.Equal(person1, person2);
        }

        [Fact]
        public void ClonePerson_Deep_AfterOriginalChange_Ok()
        {
            var bdayFather = DateTime.Parse("1981-01-05");
            var father = new Person("Thomas The Great", bdayFather, 50, 160);

            var bdayMother = DateTime.Parse("1982-01-04");
            var mother = new Person("Jaina", bdayMother, 50, 160);

            var bday = DateTime.Parse("2000-05-05");
            var person1 = new Person("Thomas", bday, 50, 160, mother, father);

            var person2 = person1.Clone();

            person1.Father.Height = 183.3f;
            Assert.NotEqual(person1, person2);
        }
    }
}
