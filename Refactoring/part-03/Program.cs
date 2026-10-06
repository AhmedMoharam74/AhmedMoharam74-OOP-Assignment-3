var checker = new BlockedUserChecker();
var users = Enumerable.Range(0, 100_000).Select(i => $"user{i}").ToArray();
var blocked = Enumerable.Range(0, 10_000).Select(i => $"USER{i*3}").ToArray();
var sw = System.Diagnostics.Stopwatch.StartNew();
var found = checker.CountBlocked(users, blocked); sw.Stop();
Console.WriteLine($"Found: {found}; elapsed: {sw.ElapsedMilliseconds} ms");
foreach (var student in new StudentCatalog().GetStudents(100_000).Take(3)) Console.WriteLine(student);
