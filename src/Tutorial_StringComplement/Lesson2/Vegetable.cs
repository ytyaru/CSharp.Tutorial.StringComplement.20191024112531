using System;

namespace Tutorial_StringComplement.Lesson2
{
    class Vegetable
    {
        public Vegetable(string name) => Name = name;
        public string Name { get; }
        public override string ToString() => Name;
    }
}
