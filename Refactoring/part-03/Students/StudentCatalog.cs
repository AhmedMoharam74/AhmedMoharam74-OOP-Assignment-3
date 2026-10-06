public sealed record Student(int Id, string Name);
public sealed class StudentCatalog
{
 public IEnumerable<Student> GetStudents(int count)
 {
  for (var i=1; i<=count; i++) yield return new Student(i, $"Student {i}");
 }
}
