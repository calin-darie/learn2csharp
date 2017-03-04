Welcome to Week 7: Advanced topics!

You will review:
- interfaces
You will learn about:
- delegates
- lambda expressions
- LINQ

1. ScifiShows
Follow the tutorial here:
http://codetunnel.io/introduction-to-linq-part-i-delegates/
Create a console app called ScifiShows based on the tutorial.

2. Store the following names in a list or array, or anything else IEnumerable.
Horia, Yusuf, Florin, Floarea, Horia, Elena, Filimon, Sofia, Horia, Leo, Hannah, Sorin, Mircea, Alan, Sorin
Write LINQ queries that return:
- the names ending in "a": Horia, Floarea, ... hint: filtering using .Where(
- all the names, transformed to uppercase: HORIA, YUSUF, FLORIN, ... hint: projection using .Select(
- the letter count for each name: 5, 5, 6, ... hint: projection using .Select(
- the names ending in "n", transformed to uppercase: FLORIN, ... hint: filtering followed by projection. you may chain the operations like this names.Where(...).Select(...)
- all distinct names
- the name count
- the distinct name count