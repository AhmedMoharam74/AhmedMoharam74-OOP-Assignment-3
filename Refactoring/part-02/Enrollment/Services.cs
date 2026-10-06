public sealed record Student(string Name);
public sealed record Course(string Title);
public sealed class PaymentGateway { public void Charge(Student student, Course course) => Console.WriteLine($"Charged {student.Name} for {course.Title}"); }
public sealed class SeatInventory { public void Reserve(Course course) => Console.WriteLine($"Seat reserved: {course.Title}"); }
public sealed class InvoiceGenerator { public string Generate(Student student, Course course) { Console.WriteLine($"Invoice generated for {student.Name}"); return $"Invoice: {student.Name} / {course.Title}"; } }
public sealed class EmailService { public void Send(Student student, string invoice) => Console.WriteLine($"Email sent to {student.Name}: {invoice}"); }
