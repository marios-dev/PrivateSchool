using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class PrivateSchool
    {
        private List<Student> _student;
        private List<Assignment> _assignment;
        private List<Trainer> _trainer;
        private List<Course> _course;
        private List<Student> _studentpercoursejavapart;
        private List<Student> _studentpercoursejavafull;
        private List<Student> _studentpercoursecsharppart;
        private List<Student> _studentpercoursecsharpfull;
        public PrivateSchool()
        {
            _student = new List<Student>();
            _assignment = new List<Assignment>();
            _trainer = new List<Trainer>();
            _course = new List<Course>();
            _studentpercoursejavapart = new List<Student>();
            _studentpercoursejavafull = new List<Student>();
            _studentpercoursecsharppart = new List<Student>();
            _studentpercoursecsharpfull = new List<Student>();
        }
        public void AddAssignment(Assignment assignment)
        {
            _assignment.Add(assignment);
        }
        public void Start()                                  // Η Αρχη του προγράμματος
        {
            bool end = false;
            string input;
            Console.WriteLine("--------- This is a private school structure ----------"); //Title
            do
            {
                Console.WriteLine("Press 1 to insert data or press 2 to use synthetic"); //Choice between Manual or Synthetic
                input = Console.ReadLine();
            } while (input != "1" && input != "2");
            if (input == "1")                               // If Manual Entry
            {
                Console.WriteLine("Press 1 if you want to add a student");
                Console.WriteLine("Press 2 if you want to add a trainer");
                Console.WriteLine("Press 3 if you want to add a course");
                Console.WriteLine("Press 4 if you want to add an Assignment");
                Console.WriteLine("Press anything if you want to exit the application");
                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":                               //Insert Student
                        Console.WriteLine("Please insert the first name of the student");
                        string studentfirst = Console.ReadLine();
                        Console.WriteLine("Please insert the last name of the student");
                        string studentlast = Console.ReadLine();
                        Console.WriteLine("Please insert the date of birth of the student in the following output yyyy/mm/dd");
                        DateTime dateofbirth = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Please insert the student's tuition fees");
                        decimal fees = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine();
                        Student student = new Student(studentfirst, studentlast, dateofbirth, fees);
                        Console.WriteLine(student);
                        break;

                    case "2":                               // Insert Trainer
                        Console.WriteLine("Please insert the first name of the trainer");
                        string trainerfirst = Console.ReadLine();
                        Console.WriteLine("Please insert the last name of the trainer");
                        string trainerlast = Console.ReadLine();
                        Console.WriteLine("Please insert the subject of the trainer");
                        string trainersubj = Console.ReadLine();
                        Console.WriteLine();
                        Trainer trainer = new Trainer(trainerfirst, trainerlast, trainersubj);
                        Console.WriteLine(trainer);
                        break;

                    case "3":                               // Insert Course
                        Console.WriteLine("Please insert the title of the course");
                        string coursetitle = Console.ReadLine();
                        Console.WriteLine("Please insert the stream of the course");
                        string coursestream = Console.ReadLine();
                        Console.WriteLine("Please insert the type of the course");
                        string coursetype = Console.ReadLine();
                        Console.WriteLine("Please insert the start date of the course yyyy/mm/dd");
                        DateTime coursesubdate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Please insert the end date the course in format yyyy/mm/dd");
                        DateTime courseenddate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine();
                        Course course = new Course(coursetitle, coursestream, coursetype, coursesubdate, courseenddate);
                        Console.WriteLine(course);
                        break;

                    case "4":                               //Insert Assignment
                        Console.WriteLine("Please insert the title of the assignment");
                        string assigntitle = Console.ReadLine();
                        Console.WriteLine("Please insert the description of the assignment");
                        string assigndesc = Console.ReadLine();
                        Console.WriteLine("Please insert the subdate time of the assignment in format yyyy/mm/dd");
                        DateTime subdate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Please insert the oral mark of the assignment");
                        decimal oralmark = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Please insert the total mark of the assignment");
                        decimal totalmark = Convert.ToDecimal(Console.ReadLine());
                        Assignment assignment = new Assignment(assigntitle, assigndesc, subdate, oralmark, totalmark);
                        Console.WriteLine(assignment);
                        break;
                    default:
                        break;
                }while (!end) ;
            }
            else if (input == "2")                          // If Synthetic
                do
                {
                    Console.WriteLine("Press 1 for a list of students");
                    Console.WriteLine("Press 2 for a list of trainers");
                    Console.WriteLine("Press 3 for a list of Courses");
                    Console.WriteLine("Press 4 for a list of Assignments");
                    Console.WriteLine("Press 5 for a list of Students Per Course");
                    Console.WriteLine("Press anything else if you want to exit the application");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":                           //Synthetic Students
                            Console.WriteLine("---------------The students of the school are: ---------------");
                            SyntheticStudents();
                            Console.WriteLine(); 
                            break;
                        case "2":                           //Synthetic Trainers
                            Console.WriteLine("---------------The trainers of the school are: ---------------");
                            SyntheticTrainers();
                            Console.WriteLine();
                            break;
                        case "3":                           //Synthetic Courses
                            Console.WriteLine("---------------The courses of the school are: ---------------");
                            SyntheticCourses();
                            Console.WriteLine();
                            break;
                        case "4":                           //Synthetic Assignments
                            Console.WriteLine("---------------The assignments of the school are: ---------------");
                            SyntheticAssignments();
                            Console.WriteLine();
                            break;
                        case "5":                           //Synthetic Student per Course
                            Console.WriteLine("-------In the C# Full time course-------");
                            StudentsPerCourseCsharpFull();
                            Console.WriteLine();
                            Console.WriteLine("-------In the C# Part time Course-------");
                            StudentsPerCourseCsharpPart();
                            Console.WriteLine();
                            Console.WriteLine("-------In the Java Full time Course-------");
                            StudentsPerCourseJavaFull();
                            Console.WriteLine();
                            Console.WriteLine("-------In the Java Part time Course-------");
                            StudentsPerCourseJavaPart();
                            Console.WriteLine();
                            break;
                        default:
                            end = true;                     //End
                            break;
                    }
                } while (!end);
            Console.WriteLine("Press any key to exit the application");
        }
        public void SyntheticStudents()                     //List of Students
        {
            Student student1 = new Student("Nikos", "Agorastos", new DateTime(1992, 12, 3), 3000);
            _student.Add(student1);
            _studentpercoursejavapart.Add(student1);
            Console.WriteLine(student1.FirstName);
            Console.WriteLine(student1.LastName);
            Console.WriteLine(student1.DateOfBirth);
            Console.WriteLine(student1.TuitionFees);
            Console.WriteLine();
            Student student2 = new Student("Petros", "Plexhs", new DateTime(1995, 8, 9), 3000);
            _student.Add(student2);
            _studentpercoursejavapart.Add(student2);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);
            Console.WriteLine(student2.DateOfBirth);
            Console.WriteLine(student2.TuitionFees);
            Console.WriteLine();
            Student student3 = new Student("Xristos", "Loghs", new DateTime(1990, 12, 19), 3000);
            _student.Add(student3);
            _studentpercoursejavafull.Add(student3);
            Console.WriteLine(student3.FirstName);
            Console.WriteLine(student3.LastName);
            Console.WriteLine(student3.DateOfBirth);
            Console.WriteLine(student3.TuitionFees);
            Console.WriteLine();
            Student student4 = new Student("Vales", "Darras", new DateTime(1989, 7, 5), 3000);
            _student.Add(student4);
            _studentpercoursejavafull.Add(student4);
            Console.WriteLine(student4.FirstName);
            Console.WriteLine(student4.LastName);
            Console.WriteLine(student4.DateOfBirth);
            Console.WriteLine(student4.TuitionFees);
            Console.WriteLine();
            Student student5 = new Student("Rigas", "Tsonis", new DateTime(1992, 3, 20), 3000);
            _student.Add(student5);
            _studentpercoursecsharppart.Add(student5);
            Console.WriteLine(student5.FirstName);
            Console.WriteLine(student5.LastName);
            Console.WriteLine(student5.DateOfBirth);
            Console.WriteLine(student5.TuitionFees);
            Console.WriteLine();
            Student student6 = new Student("Ntama", "Nikou", new DateTime(1993, 3, 9), 3000);
            _student.Add(student6);
            _studentpercoursecsharppart.Add(student6);
            Console.WriteLine(student6.FirstName);
            Console.WriteLine(student6.LastName);
            Console.WriteLine(student6.DateOfBirth);
            Console.WriteLine(student6.TuitionFees);
            Console.WriteLine();
            Student student7 = new Student("Loukas", "Potis", new DateTime(1994, 4, 1), 3000);
            _student.Add(student7);
            _studentpercoursecsharpfull.Add(student7);
            Console.WriteLine(student7.FirstName);
            Console.WriteLine(student7.LastName);
            Console.WriteLine(student7.DateOfBirth);
            Console.WriteLine(student7.TuitionFees);
            Console.WriteLine();
            Student student8 = new Student("Giannis", "Rhgas", new DateTime(1995, 2, 18), 3000);
            _student.Add(student8);
            _studentpercoursecsharpfull.Add(student8);
            Console.WriteLine(student8.FirstName);
            Console.WriteLine(student8.LastName);
            Console.WriteLine(student8.DateOfBirth);
            Console.WriteLine(student8.TuitionFees);
            Console.WriteLine();
            Student student9 = new Student("Nikos", "Panou", new DateTime(1991, 7, 12), 3000);
            _student.Add(student9);
            _studentpercoursecsharpfull.Add(student9);
            Console.WriteLine(student9.FirstName);
            Console.WriteLine(student9.LastName);
            Console.WriteLine(student9.DateOfBirth);
            Console.WriteLine(student9.TuitionFees);
            Console.WriteLine();
            Student student10 = new Student("Panos", "Xristoy", new DateTime(1991, 4, 24), 3000);
            _student.Add(student10);
            _studentpercoursecsharpfull.Add(student10);
            Console.WriteLine(student10.FirstName);
            Console.WriteLine(student10.LastName);
            Console.WriteLine(student10.DateOfBirth);
            Console.WriteLine(student10.TuitionFees);
            Console.WriteLine();
            Student student11 = new Student("Xristina", "Rodopoulou", new DateTime(1985, 3, 6), 3000);
            _student.Add(student11);
            _studentpercoursecsharppart.Add(student11);
            Console.WriteLine(student11.FirstName);
            Console.WriteLine(student11.LastName);
            Console.WriteLine(student11.DateOfBirth);
            Console.WriteLine(student11.TuitionFees);
            Console.WriteLine();
            Student student12 = new Student("Iwanna", "Tsoxatzopouloy", new DateTime(1989, 1, 29), 3000);
            _student.Add(student12);
            _studentpercoursecsharppart.Add(student12);
            Console.WriteLine(student12.FirstName);
            Console.WriteLine(student12.LastName);
            Console.WriteLine(student12.DateOfBirth);
            Console.WriteLine(student12.TuitionFees);
            Console.WriteLine();
            Student student13 = new Student("Myrtw", "Alexioy", new DateTime(1990, 5, 21), 3000);
            _student.Add(student13);
            _studentpercoursejavafull.Add(student13);
            Console.WriteLine(student13.FirstName);
            Console.WriteLine(student13.LastName);
            Console.WriteLine(student13.DateOfBirth);
            Console.WriteLine(student13.TuitionFees);
            Console.WriteLine();
            Student student14 = new Student("Petros", "Rodos", new DateTime(1991, 9, 17), 3000);
            _student.Add(student14);
            _studentpercoursejavafull.Add(student14);
            Console.WriteLine(student14.FirstName);
            Console.WriteLine(student14.LastName);
            Console.WriteLine(student14.DateOfBirth);
            Console.WriteLine(student14.TuitionFees);
            Console.WriteLine();
            Student student15 = new Student("Giwrgos", "Lastixos", new DateTime(1995, 8, 15), 3000);
            _student.Add(student15);
            _studentpercoursejavafull.Add(student15);
            Console.WriteLine(student15.FirstName);
            Console.WriteLine(student15.LastName);
            Console.WriteLine(student15.DateOfBirth);
            Console.WriteLine(student15.TuitionFees);
        }
        public void SyntheticTrainers()                     // List of trainers
        {
            Trainer trainer1 = new Trainer("Nikos", "Papadopoulos","C#");
            _trainer.Add(trainer1);
            Console.WriteLine(trainer1.FirstName);
            Console.WriteLine(trainer1.LastName);
            Console.WriteLine(trainer1.Subject);
            Console.WriteLine();
            Trainer trainer2 = new Trainer("Giannis", "Xristopoulos","C#");
            _trainer.Add(trainer2);
            Console.WriteLine(trainer2.FirstName);
            Console.WriteLine(trainer2.LastName);
            Console.WriteLine(trainer2.Subject);
            Console.WriteLine();
            Trainer trainer3 = new Trainer("Xristina", "Agorastou","C#");
            _trainer.Add(trainer3);
            Console.WriteLine(trainer3.FirstName);
            Console.WriteLine(trainer3.LastName);
            Console.WriteLine(trainer3.Subject);
            Console.WriteLine();
            Trainer trainer4 = new Trainer("Baggelis", "Anagnwstou","C#");
            _trainer.Add(trainer4);
            Console.WriteLine(trainer4.FirstName);
            Console.WriteLine(trainer4.LastName);
            Console.WriteLine(trainer4.Subject);
            Console.WriteLine();
            Trainer trainer5 = new Trainer("Ilianna", "Daskalakh","Java");
            _trainer.Add(trainer5);
            Console.WriteLine(trainer5.FirstName);
            Console.WriteLine(trainer5.LastName);
            Console.WriteLine(trainer5.Subject);
            Console.WriteLine();
            Trainer trainer6 = new Trainer("Chris", "Talker","Java");
            _trainer.Add(trainer6);
            Console.WriteLine(trainer6.FirstName);
            Console.WriteLine(trainer6.LastName);
            Console.WriteLine(trainer6.Subject);
            Console.WriteLine();
            Trainer trainer7 = new Trainer("Marina", "Lykourgoy","Java");
            _trainer.Add(trainer7);
            Console.WriteLine(trainer7.FirstName);
            Console.WriteLine(trainer7.LastName);
            Console.WriteLine(trainer7.Subject);
            Console.WriteLine();
            Trainer trainer8 = new Trainer("Iwanna", "Panopoulou","Java");
            _trainer.Add(trainer8);
            Console.WriteLine(trainer8.FirstName);
            Console.WriteLine(trainer8.LastName);
            Console.WriteLine(trainer8.Subject);
            Console.WriteLine();
        }
        public void StudentsPerCourseJavaPart()             //Students in Java part time course
        {
            foreach(Student student in _studentpercoursejavapart)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
        public void StudentsPerCourseJavaFull()             //Students in Java full time course
        {
            foreach (Student student in _studentpercoursejavafull)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
        public void StudentsPerCourseCsharpPart()           //Students in C# part time course
        {
            foreach (Student student in _studentpercoursecsharppart)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
        public void StudentsPerCourseCsharpFull()           //Students in C# full time course
        {
            foreach (Student student in _studentpercoursecsharpfull)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
        public void SyntheticCourses()                      // List of courses
        {
            Course course1 = new Course("C# Coding", "C#", "Full Time", new DateTime(2019, 1, 1), new DateTime(2019, 3, 31));
            _course.Add(course1);
            Console.WriteLine(course1.Title);
            Console.WriteLine(course1.Stream);
            Console.WriteLine(course1.Type);
            Console.WriteLine(course1.StartDate);
            Console.WriteLine(course1.EndDate);
            Console.WriteLine();
            Course course2 = new Course("Java coding", "java", "Full Time", new DateTime(2019, 1, 1), new DateTime(2019, 3, 31));
            _course.Add(course2);
            Console.WriteLine(course2.Title);
            Console.WriteLine(course2.Stream);
            Console.WriteLine(course2.Type);
            Console.WriteLine(course2.StartDate);
            Console.WriteLine(course2.EndDate);
            Console.WriteLine();
            Course course3 = new Course("C# mastering", "C#", "Part Time", new DateTime(2019, 1, 1), new DateTime(2019, 3, 31));
            _course.Add(course3);
            Console.WriteLine(course3.Title);
            Console.WriteLine(course3.Stream);
            Console.WriteLine(course3.Type);
            Console.WriteLine(course3.StartDate);
            Console.WriteLine(course3.EndDate);
            Console.WriteLine();
            Course course4 = new Course("Java mastering", "Java", "Part Time", new DateTime(2019, 1, 1), new DateTime(2019, 3, 31));
            _course.Add(course4);
            Console.WriteLine(course4.Title);
            Console.WriteLine(course4.Stream);
            Console.WriteLine(course4.Type);
            Console.WriteLine(course4.StartDate);
            Console.WriteLine(course4.EndDate);
            Console.WriteLine();
        }
        public void SyntheticAssignments()                  // List of assignments
        {
            Assignment assignment1 = new Assignment("Assignment 1 C#", "C# lvl1", new DateTime(2019, 9, 6), 20, 80);
            _assignment.Add(assignment1);
            Console.WriteLine(assignment1.Title);
            Console.WriteLine(assignment1.Description);
            Console.WriteLine(assignment1.SubDateTime);
            Console.WriteLine(assignment1.OralMark);
            Console.WriteLine(assignment1.TotalMark);
            Console.WriteLine();
            Assignment assignment2 = new Assignment("Assignment 2 C#", "C# lvl2", new DateTime(2019, 9, 12), 20, 80);
            _assignment.Add(assignment2);
            Console.WriteLine(assignment2.Title);
            Console.WriteLine(assignment2.Description);
            Console.WriteLine(assignment2.SubDateTime);
            Console.WriteLine(assignment2.OralMark);
            Console.WriteLine(assignment2.TotalMark);
            Console.WriteLine();
            Assignment assignment3 = new Assignment("Assignment 3 C#", "C# lvl3", new DateTime(2019, 9, 16), 20, 80);
            _assignment.Add(assignment3);
            Console.WriteLine(assignment3.Title);
            Console.WriteLine(assignment3.Description);
            Console.WriteLine(assignment3.SubDateTime);
            Console.WriteLine(assignment3.OralMark);
            Console.WriteLine(assignment3.TotalMark);
            Console.WriteLine();
            Assignment assignment4 = new Assignment("Assignment 4 C#", "C# lvl4", new DateTime(2019, 9, 22), 20, 80);
            _assignment.Add(assignment4);
            Console.WriteLine(assignment4.Title);
            Console.WriteLine(assignment4.Description);
            Console.WriteLine(assignment4.SubDateTime);
            Console.WriteLine(assignment4.OralMark);
            Console.WriteLine(assignment4.TotalMark);
            Console.WriteLine();
            Assignment assignment5 = new Assignment("Assignment 5 C#", "C# lvl5", new DateTime(2019, 9, 28), 20, 80);
            _assignment.Add(assignment5);
            Console.WriteLine(assignment5.Title);
            Console.WriteLine(assignment5.Description);
            Console.WriteLine(assignment5.SubDateTime);
            Console.WriteLine(assignment5.OralMark);
            Console.WriteLine(assignment5.TotalMark);
            Console.WriteLine();
            Assignment assignment6 = new Assignment("Assignment 6", "C# individual project", new DateTime(2019, 10, 10), 20, 80);
            _assignment.Add(assignment6);
            Console.WriteLine(assignment6.Title);
            Console.WriteLine(assignment6.Description);
            Console.WriteLine(assignment6.SubDateTime);
            Console.WriteLine(assignment6.OralMark);
            Console.WriteLine(assignment6.TotalMark);
            Console.WriteLine();
            Assignment assignment7 = new Assignment("Assignment 7", "C# team project", new DateTime(2019, 10, 21), 20, 80);
            _assignment.Add(assignment7);
            Console.WriteLine(assignment7.Title);
            Console.WriteLine(assignment7.Description);
            Console.WriteLine(assignment7.SubDateTime);
            Console.WriteLine(assignment7.OralMark);
            Console.WriteLine(assignment7.TotalMark);
            Console.WriteLine();
            Assignment assignment8 = new Assignment("Assignment 1 Java", "Java lvl1", new DateTime(2019, 9, 6), 20, 80);
            _assignment.Add(assignment8);
            Console.WriteLine(assignment8.Title);
            Console.WriteLine(assignment8.Description);
            Console.WriteLine(assignment8.SubDateTime);
            Console.WriteLine(assignment8.OralMark);
            Console.WriteLine(assignment8.TotalMark);
            Console.WriteLine();
            Assignment assignment9 = new Assignment("Assignment 2 Java", "Java lvl2", new DateTime(2019, 9, 12), 20, 80);
            _assignment.Add(assignment9);
            Console.WriteLine(assignment9.Title);
            Console.WriteLine(assignment9.Description);
            Console.WriteLine(assignment9.SubDateTime);
            Console.WriteLine(assignment9.OralMark);
            Console.WriteLine(assignment9.TotalMark);
            Console.WriteLine();
            Assignment assignment10 = new Assignment("Assignment 3 Java", "Java lvl3", new DateTime(2019, 9, 16), 20, 80);
            _assignment.Add(assignment10);
            Console.WriteLine(assignment10.Title);
            Console.WriteLine(assignment10.Description);
            Console.WriteLine(assignment10.SubDateTime);
            Console.WriteLine(assignment10.OralMark);
            Console.WriteLine(assignment10.TotalMark);
            Console.WriteLine();
            Assignment assignment11 = new Assignment("Assignment 4 Java", "Java lvl4", new DateTime(2019, 9, 22), 20, 80);
            _assignment.Add(assignment11);
            Console.WriteLine(assignment11.Title);
            Console.WriteLine(assignment11.Description);
            Console.WriteLine(assignment11.SubDateTime);
            Console.WriteLine(assignment11.OralMark);
            Console.WriteLine(assignment11.TotalMark);
            Console.WriteLine();
            Assignment assignment12 = new Assignment("Assignment 5 Java", "Java lvl5", new DateTime(2019, 9, 28), 20, 80);
            _assignment.Add(assignment12);
            Console.WriteLine(assignment12.Title);
            Console.WriteLine(assignment12.Description);
            Console.WriteLine(assignment12.SubDateTime);
            Console.WriteLine(assignment12.OralMark);
            Console.WriteLine(assignment12.TotalMark);
            Console.WriteLine();
            Assignment assignment13 = new Assignment("Assignment 6 Java", "Java individual project", new DateTime(2019, 10, 10), 20, 80);
            _assignment.Add(assignment13);
            Console.WriteLine(assignment13.Title);
            Console.WriteLine(assignment13.Description);
            Console.WriteLine(assignment13.SubDateTime);
            Console.WriteLine(assignment13.OralMark);
            Console.WriteLine(assignment13.TotalMark);
            Console.WriteLine();
            Assignment assignment14 = new Assignment("Assignment 7 Java", "Java team project", new DateTime(2019, 10, 21), 20, 80);
            _assignment.Add(assignment14);
            Console.WriteLine(assignment14.Title);
            Console.WriteLine(assignment14.Description);
            Console.WriteLine(assignment14.SubDateTime);
            Console.WriteLine(assignment14.OralMark);
            Console.WriteLine(assignment14.TotalMark);
            Console.WriteLine();
        }
    }
}
