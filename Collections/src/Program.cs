var phoneInputs = new[] { "01012345678", "+201512345678", "01312345678", "0101234567", "0101234567a", "  " };
foreach (var value in phoneInputs)
    Console.WriteLine($"{value}: {value.IsValidEgyptianPhone()} (phone)");

var ids = new[] { "29901011234567", "19901011234567", "2990101123456", "  " };
foreach (var value in ids)
    Console.WriteLine($"{value}: {value.IsValidEgyptianNationalId()} (national ID)");
