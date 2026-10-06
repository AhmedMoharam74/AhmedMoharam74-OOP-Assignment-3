public sealed class BlockedUserChecker
{
 public int CountBlocked(IEnumerable<string> users, IEnumerable<string> blockedUsers)
 {
  ArgumentNullException.ThrowIfNull(users); ArgumentNullException.ThrowIfNull(blockedUsers);
  var blocked = new HashSet<string>(blockedUsers, StringComparer.OrdinalIgnoreCase);
  var count = 0; foreach (var user in users) if (blocked.Contains(user)) count++; return count;
 }
}
