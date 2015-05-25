using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HomeworkStudents
    {
        //with the help of *npaunov*
        static void Main()
        {
            var student = new List<Student>
            {
                new Student("Pesho","Peshev",18,"223214","+359 2 45657567","pesho@abv.bg",new List<int>{4,3,3,5},1),
                new Student("Ivan","Ivanov",23,"243415","0876342545","ivan@gmail.bg",new List<int>{5,6,5,4},2),
                new Student("Gosho","Georgiev",20,"335714","+35925467765","gosho@abv.bg",new List<int>{5,5,4,3},1),
                new Student("Rositza","Roseva",21,"624516","0885123456","rosi@abv.bg",new List<int> {4, 2, 6, 3},2),
                new Student("Mariika","Marieva",20,"521414","025465476","mariika@yahoo.com",new List<int> {2, 2, 5, 4},1),
                new Student("Ivan","Petrov",36,"743315","0887346578","petrov@gmail.com",new List<int> {6, 2, 6, 6},3)            

            };

            // Task 2.Students By Group
            //

                    //var groupedStudents =
                    //    from st in student
                    //    where st.GroupNumber == 2
                    //    orderby st.FirstName
                    //    select st;
                    //foreach (var st in groupedStudents)
                    //{
                    //    Console.WriteLine("{0} {1}, Age:{2}, FacultyNumber:{3}, Phone:{4}, E-mail:{5}, Marks:{6}, GroupNumber:{7}", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(", ", st.Marks), st.GroupNumber);
                    //}

            // Task 3.Students by First and Last Name

                    //var firstAndLastName =
                    //    from st in student
                    //    where st.FirstName.CompareTo(st.LastName) < 0
                    //    select st;
                    //foreach (var st in firstAndLastName)
                    //{
                    //    Console.WriteLine("{0} {1}, Age:{2}, FacultyNumber:{3}, Phone:{4}, E-mail:{5}, Marks:{6}, GroupNumber:{7}",st.FirstName, st.LastName,st.Age,st.FacultyNumber,st.Phone,st.Email,string.Join(", ",st.Marks),st.GroupNumber);
                    //}

            // Task 4.Students By Age

                    //var studentsByAge =
                    //    from st in student
                    //    where st.Age >= 18 && st.Age <= 24
                    //    select new { st.FirstName, st.LastName, st.Age };
                    //foreach (var st in studentsByAge)
                    //{
                    //    Console.WriteLine(st.FirstName + " " + st.LastName + " " + st.Age);
                    //}

            // Task 5. Sort Students

                    // with Lambda
                    //Console.WriteLine("With Lambda:");
                    //Console.WriteLine();

                    //var sortedWithLambda = student.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName).Select(st => (string.Format("{0} {1}", st.FirstName, st.LastName)));

                    //foreach (var st in sortedWithLambda)
                    //{
                    //    Console.WriteLine(st);
                    //}
                    //Console.WriteLine();

                    //// with LINQ
                    //Console.WriteLine("With LINQ:");
                    //Console.WriteLine();
                    //var sortedWithLINQ =
                    //    from st in student
                    //    orderby st.FirstName descending, st.LastName descending
                    //    select st;

                    //foreach (var st in sortedWithLINQ)
                    //{
                    //    Console.WriteLine("{0} {1}",st.FirstName,st.LastName);
                    //}

            // Task 6.Filter Students By Email Domain

                    //var printByEmail =
                    //    from st in student
                    //    where st.Email.Contains("@abv.bg")
                    //    select st;
                    //foreach (var st in printByEmail)
                    //{
                    //    Console.WriteLine(st.FirstName + " " + st.LastName + " Email:" + st.Email);
                    //}

            // Task 7.Filter Students By Phone

                    //var printByPhone =
                    //    from st in student
                    //    where (st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592") || st.Phone.StartsWith("+359 2"))
                    //    select st;
                    //foreach (var st in printByPhone)
                    //{
                    //    Console.WriteLine(st.FirstName + " " + st.LastName + " --> " + st.Phone);
                    //}

            // Task 8.Excellent Students

                    //var excelentStudents =
                    //    from st in student
                    //    where (st.Marks.Max() == 6)
                    //    select new { Fullname = string.Join(" ", st.FirstName, st.LastName), Marks = string.Join(",", st.Marks) };
                    //foreach (var st in excelentStudents)
                    //{
                    //    Console.WriteLine(st.Fullname + " " + st.Marks);
                    //}

            // Task 9.Weak Students

                    //var weakStudents = student.ExtensionCount();

                    //foreach (var i in weakStudents)
                    //{
                    //    Console.WriteLine("{0} {1} Marks:{2}",i.FirstName,i.LastName,string.Join(", ",i.Marks));
                    //}

            // Task 10.Students Enrolled in 2014

                    //var enrolledIn2014 =
                    //    from st in student
                    //    where st.FacultyNumber.EndsWith("14")
                    //    select st;

                    //foreach (var st in enrolledIn2014)
                    //{
                    //    Console.WriteLine("{0} {1} FacultyNumber:{2}", st.FirstName, st.LastName, st.FacultyNumber);
                    //}

        }
    }
