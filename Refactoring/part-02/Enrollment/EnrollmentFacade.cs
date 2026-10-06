public sealed class EnrollmentFacade(PaymentGateway payment, SeatInventory seats, InvoiceGenerator invoices, EmailService email)
{
 public void Enroll(Student student, Course course)
 {
  ArgumentNullException.ThrowIfNull(student); ArgumentNullException.ThrowIfNull(course);
  payment.Charge(student, course); seats.Reserve(course); var invoice = invoices.Generate(student, course); email.Send(student, invoice);
 }
}
