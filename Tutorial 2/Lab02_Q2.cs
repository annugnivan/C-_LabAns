//main method
class Program
    {
        static void Main(string[] args)
        {
            //creates obj
            car Honda = new car("Honda", "Yellow", 69, 420);
            //prints content of object
            Console.WriteLine(Honda);

            //speed management
            Honda.accelerate(20);
            Honda.decelerate(10);
            Honda.stop();

            //prints content of object
            Console.WriteLine(Honda);
            Console.ReadKey();
        }
        
    }

//car class
public class car
    {
        //getters and setters
        private String brand { get; set; }
        private String colour { get; set; }
        private int engine_size { get; set; }
        private int speed { get; set; }

        //constructor
        public car() { }

        //overloaded constructor
        public car(String b, String c, int e, int s)
        {
            brand = b;
            colour = c;
            engine_size = e;
            speed = s;
        }

        //accelerate method to speed this nigga
        public void accelerate(int acc)
        {
            speed = speed + acc;
            Console.WriteLine("Car is moving at {0} MPH\n", speed);
        }

        //decelerate method to slow this nigga
        public void decelerate(int decc)
        {
            if (speed - decc < 0)
            {
                speed = 0;
                Console.WriteLine("Car has stopped\n");
            }
            else
            {
                speed = speed - decc;
                Console.WriteLine("Car has slowed down to {0} MPH\n", speed);
            }
        }

        //stop method to stop this nigga
        public void stop()
        {
            speed = 0;
            Console.WriteLine("Car has stopped\n");
        }

        //holy toString method
        public override string ToString()
        {
            return "Car brand: " + brand +"\nColour: " + colour + "\nSpeed: " + speed + "\nEngine size: " + engine_size + "\n";
        }
    }