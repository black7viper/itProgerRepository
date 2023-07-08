using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace itProger.Learn
{
    internal class Serialazable
    {
        public static void Main()
        {
            learnSerializable();
        }

        public static void learnSerializable()
        {
            Animal cat = new Animal("Tom", 3, "cat");
            Animal dog = new Animal("John", 2, "dog");
            Animal[] animals = { cat, dog };

            //устарело
            BinaryFormatter binary = new BinaryFormatter();
            XmlSerializer xml = new XmlSerializer(typeof(Animal[]));
            using (FileStream file = new FileStream("D:\\Projects_C#\\itProgerGit\\Animals.xml", FileMode.OpenOrCreate))
            {
                //binary.Serialize(file, animals);
                xml.Serialize(file, animals);
                Console.WriteLine("Сериализаация прошла успешно");
            };
            using (FileStream file = new FileStream("D:\\Projects_C#\\itProgerGit\\Animals.xml", FileMode.OpenOrCreate))
            {
                //Animal[] newAnimal = (Animal[])binary.Deserialize(file);
                Animal[] newAnimals = xml.Deserialize(file) as Animal[] ?? new Animal[0];
                Console.WriteLine("Десериализаация прошла успешно");
            };
        }

    }
}
