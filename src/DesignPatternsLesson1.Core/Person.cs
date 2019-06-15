using System;

namespace DesignPatternsLesson1.Core
{
    public class Person : ICloneable<Person>
    {
        public string Name { get; }
        public DateTime Birthday { get; }
        public float Weight { set; get; }
        public float Height { set; get; }

        public Person Mother { get; private set; }
        public Person Father { get; private set; }

        public Person(string name, DateTime birthday, float weight, float height)
        {
            Name = name;
            Birthday = birthday;
            Weight = weight;
            Height = height;
        }

        public Person(string name, DateTime birthday, float weight, float height, Person mother, Person father)
        {
            Name = name;
            Birthday = birthday;
            Weight = weight;
            Height = height;
            Mother = mother;
            Father = father;
        }

        public Person Clone()
        {
            var copy = (Person)MemberwiseClone();
            copy.Father = Father?.Clone();
            copy.Mother = Mother?.Clone();
            return copy;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Person;
            if (obj is null) return false;

            return Name == other.Name &&
                NumbersComparer.AreEqual(Weight, other.Weight) &&
                NumbersComparer.AreEqual(Height, other.Height) &&
                Birthday == other.Birthday &&
                Father == other.Father &&
                Mother == other.Mother;
        }

        public static bool operator ==(Person me, Person other)
        {
            if(!(me is null))
            {
                return me.Equals(other);
            }
            else
            {
                return other is null;
            }
        }

        public static bool operator !=(Person me, Person other)
        {
            if (!(me is null))
            {
                return !me.Equals(other);
            }
            else
            {
                return !(other is null);
            }
        }
    }
}
