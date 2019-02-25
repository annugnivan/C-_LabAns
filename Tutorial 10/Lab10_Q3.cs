//main class
class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string, int> genericClass = new GenericClass<string, int>("Integer", 69);

            genericClass.Print();

            Console.ReadKey();
        }

    }

//generic class
class GenericClass<T, V>
    {
        public T Type {get; set;}
        public V Value { get; set; }

        public GenericClass(T type, V value)
        {
            Type = type;
            Value = value;

        }
        public void Print()
        {
            Console.WriteLine("The present type of this generic object is " + Type + " with value: " + Value);
        }
        

    }