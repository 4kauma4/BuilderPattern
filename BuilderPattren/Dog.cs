using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattren
{
    public class Dog
    {
        private string _name;
        private string _breed;
        private int _age;
        private List<string> _toys;

        // приват конструктор
        private Dog() { }

        // аксессор
        public string GetName()
        {
            return _name;
        }

        public string GetBreed()
        {
            return _breed;
        }

        public int GetAge()
        {
            return _age;
        }

        public List<string> GetToys()
        {
            return new List<string>(_toys); 
        }

        // строитель
        public class DogBuilder
        {
            private string _name;
            private string _breed;
            private int _age;
            private List<string> _toys;

            public DogBuilder()
            {
                _toys = new List<string>();
            }

            // мутатор
            public DogBuilder SetName(string name)
            {
                _name = name;
                return this; // ввозврыщаем для цепочки выозовов
            }

            
            public DogBuilder SetBreed(string breed)
            {
                _breed = breed;
                return this; 
            }

           
            public DogBuilder SetAge(int age)
            {
                _age = age;
                return this; 
            }

            
            public DogBuilder AddToy(string toy)
            {
                _toys.Add(toy);
                return this; 
            }

            // объект
            public Dog Build()
            {
                Dog dog = new Dog();
                dog._name = _name;
                dog._breed = _breed;
                dog._age = _age;
                dog._toys = new List<string>(_toys); 
                return dog;
            }
        }
    }
}
