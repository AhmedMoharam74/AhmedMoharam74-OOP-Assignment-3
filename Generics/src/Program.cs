var students = new Store<Student>();
for (var i = 1; i <= 5; i++) students.Add(new Student(i, $"Student {i}"));
var courses = new Store<Course>();
courses.Add(new Course(101, "OOP", 1200m));
courses.Add(new Course(102, "C#", 900m));
courses.Add(new Course(103, "Databases", 800m));
Console.WriteLine(students.GetById(2));
Console.WriteLine(courses.GetById(102));
try { students.Add(new Student(2, "Duplicate")); }
catch (InvalidOperationException ex) { Console.WriteLine(ex.Message); }
foreach (var student in students.GetAll().Values.Page(2, 2)) Console.WriteLine(student);
var courseList = new List<Course> { new(201, "Algorithms", 700m), new(202, "Networks", 650m) };
Console.WriteLine(courseList.FindById(202));
// var invalid = new Store<string>(); // must NOT compile: string does not implement IHasId.
