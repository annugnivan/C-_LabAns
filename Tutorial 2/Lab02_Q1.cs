//main class
class Program
    {
        static void Main(string[] args)
        {
            GradeBook Philosophy = new GradeBook("Philosophy", 69.42);
            Philosophy.DisplayMessage();
            Philosophy.SetMarks(42);
            Philosophy.DisplayMessage();
            Console.ReadKey();
        }
        
    }
    
//gradebook class
public class GradeBook
    {
        //getters and setters
        public string CourseName { get; set; }
        public double CourseMarks { get; set; }
        
        //overloaded constructor
        public GradeBook(string name,double marks)
        {
            CourseName = name;
            CourseMarks = marks;
        }

        //displays the stuff
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book for \n{0}! Marks obtained: {1}", CourseName, CourseMarks);
        }

        //changes the marks
        public double SetMarks(double NuMark)
        {
            CourseMarks = NuMark;
            Console.WriteLine("Changing marks obtained to : {0}", NuMark);
            //since is a double method requires return type
            return CourseMarks;
            
        }
    }