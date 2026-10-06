# Generics — Answers

## Step 2
Both stores add, find, list, and remove items by integer ID. Their stored types and displayed properties differ: a student has a name; a course has a title and price.

## Step 3
Compiler error (representative): `T does not contain a definition for Id and no accessible extension method Id accepting a first argument of type T could be found`. `T` could be any type, so the compiler cannot assume an `Id` property until we constrain it.

## Step 7
`Store<string>` must not compile because `string` does not implement `IHasId`, which is required by the generic constraint.

The common name for this constrained reusable class is a **generic repository** (or generic store/repository pattern).
