# Answers

## Blocked users and students
Before optimization, nested membership checks are O(users × blockedUsers), i.e. O(n·m). The baseline milliseconds must be measured against the original starter code on your machine; it was not present in this workspace. After building a HashSet once, expected complexity is O(n + m), with O(m) extra memory. The count remains the number of user entries found in the blocked set.

The student catalog uses `yield return`; taking three results creates only those three students, rather than materializing the full catalog.

| Measurement | Time |
|---|---:|
| Before | [run original and enter ms] |
| After | [run refactored and enter ms] |
