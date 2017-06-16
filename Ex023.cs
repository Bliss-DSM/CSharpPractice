using System;

//델리게이트(6) (208p ~ 213p)
namespace Ex023
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] personArray =
                new Person[] { new Person(20, "조은형"), new Person(15, "이진영"), new Person(39, "김지수"), new Person(75, "김지하"), new Person(3, "조경욱") };

            SortObject so = new SortObject(personArray);
            so.Sort(AscSortByName);
            so.Display();
        }

        static bool AscSortByName(object arg1, object arg2)
        {
            Person person1 = arg1 as Person;
            Person person2 = arg2 as Person;

            return person1.name.CompareTo(person2.name) < 0;
        }
    }
    
    class Person
    {
        public int age;
        public string name;

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public override string ToString()
        {
            return name + ": " + age;
        }
    }

    delegate bool CompareDelegate(object arg1, object arg2);

    class SortObject
    {
        object[] things;

        public SortObject(object[] things)
        {
            this.things = things;
        }

        public void Sort(CompareDelegate compareMethod)
        {
            object temp;

            for(int i = 0; i < things.Length; i++)
            {
                int lowPos = i;

                for(int j = i + 1; j < things.Length; j++)
                {
                    if(compareMethod(things[j], things[lowPos]))
                    {
                        lowPos = j;
                    }
                }

                temp = things[lowPos];
                things[lowPos] = things[i];
                things[i] = temp;
            }
        }

        public void Display()
        {
            for(int i = 0; i < things.Length; i++)
            {
                Console.WriteLine(things[i] + ",");
            }
        }
    }
}