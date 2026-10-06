var output = Path.Combine(Environment.CurrentDirectory, "reports");
var rows = new[] { "Alice", "Bob", "Carol" };
new CsvReportExporter(output).Export(rows);
new JsonReportExporter(output).Export(rows);
new TextReportExporter(output).Export(rows);
var enrollment = new EnrollmentFacade(new PaymentGateway(), new SeatInventory(), new InvoiceGenerator(), new EmailService());
enrollment.Enroll(new Student("Mona"), new Course("OOP"));
