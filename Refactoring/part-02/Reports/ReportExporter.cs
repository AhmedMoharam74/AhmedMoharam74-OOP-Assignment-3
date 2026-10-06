public abstract class ReportExporter(string outputDirectory)
{
 protected abstract string FileName { get; }
 protected abstract string Render(IEnumerable<string> rows);
 public string Export(IEnumerable<string> rows)
 {
  ArgumentNullException.ThrowIfNull(rows);
  Directory.CreateDirectory(outputDirectory);
  var content = Render(rows);
  var path = Path.Combine(outputDirectory, FileName);
  File.WriteAllText(path, content);
  return path;
 }
}
public sealed class CsvReportExporter(string dir) : ReportExporter(dir)
{ protected override string FileName => "report.csv"; protected override string Render(IEnumerable<string> rows) => "value" + Environment.NewLine + string.Join(Environment.NewLine, rows.Select(Escape)); private static string Escape(string x) => "\"" + x.Replace("\"", "\"\"") + "\""; }
public sealed class JsonReportExporter(string dir) : ReportExporter(dir)
{ protected override string FileName => "report.json"; protected override string Render(IEnumerable<string> rows) => "[" + string.Join(",", rows.Select(row => System.Text.Json.JsonSerializer.Serialize(row))) + "]"; }
public sealed class TextReportExporter(string dir) : ReportExporter(dir)
{ protected override string FileName => "report.txt"; protected override string Render(IEnumerable<string> rows) => string.Join(Environment.NewLine, rows); }
