using System.Text.RegularExpressions;

public static class StringValidationExtensions
{
    private static readonly Regex EgyptianPhone = new(@"\A(?:01[0125]\d{8}|\+201[0125]\d{8})\z", RegexOptions.Compiled);
    private static readonly Regex EgyptianNationalId = new(@"\A[23]\d{13}\z", RegexOptions.Compiled);

    public static bool IsValidEgyptianPhone(this string? value) =>
        !string.IsNullOrWhiteSpace(value) && EgyptianPhone.IsMatch(value);

    public static bool IsValidEgyptianNationalId(this string? value) =>
        !string.IsNullOrWhiteSpace(value) && EgyptianNationalId.IsMatch(value);
}
