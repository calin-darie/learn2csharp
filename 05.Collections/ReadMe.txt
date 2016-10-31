Welcome to Lab 5: Collections!

You will learn about 
- storing multiple items of the same type in a single object.
- lists
- dictionaries
- arrays 
- honorable mention: queues and stacks




Lists
A collection of items. You can add items to, and remove items from a list.

Practice #1: Generate Test Data
Goals:
- Enumerating a list 
- Generating test data
Suppose you want to test your app with lots of realistically looking data. 
You'll either write a lot of code or use a library to do the hard lifting.
A library is a compiled project, that usually somebody else wrote.
To download and reference a .NET library, you'll most often use NuGet.
Go to View -> Other Windows -> Package Manager Console
Enter the following:
Install-Package Genfu
Read the readme:
https://github.com/MisterJames/GenFu#readme
Generate a list of 25 Customers, and print the customer data to the console, like this:

Joe 
Smith
20/10/1978
fsdjkl@yahoo.com
19 Goldman ave.
===================
Jane
Doe
...



Arrays
A fixed-size collection of items.

The only way to create methods with a variable number of arguments in C# is by using a params [] argument.

Practice #2: MathExtensions
Goal: writing methods with variable number of arguments = variadic methods using params[]
Something the .NET team has never given priority to is writing such an overload for Math.Max or Math.Min*
We can fix this :)
Write some unit tests for MathEx.Min / Max.

* read the stackOverflow answers when you're either done or stuck:
http://stackoverflow.com/questions/6800838/in-c-sharp-is-there-a-method-to-find-the-max-of-3-numbers
http://stackoverflow.com/questions/9713390/why-arent-cs-math-min-max-variadic



Dictionaries
map from keys to values. Retrieving a value by using its key is very fast.
like, well, dictionaries :P real world dictionaries map from words to definitions

Practice #3: Online Exam
Goal: experiment with the performance of retrieving by key from a dictionary vs searching list elements one by one

Suppose this is part of the software for an online exam. 
The die is cast, the scores are known. Users have started to ask your website for their scores.
Implement two approaches for storing and retrieving scores. 
One will use a list and search by looping through the list elements one by one. It will return the score once it finds the element with the correct username.
The other will use a dictionary. The username is the key, so retrieving the score and possibly other data by username should be faster.
First, make the unit tests pass. 

Then, try the performance tests with different counts of scores and with different counts of queries.
The timing code is already there.
The dictionary is supposedly faster. 
Just how faster? Write the performance test output in a comment. 



Queues 
first in, first out
like people lining up for service.


You'll see them used in frameworks or components aimed at message publishing and subscription. 
-queue up work on a thread, be it the main UI thread or a background thread.
-queue up a message on a message queue, be it an event aggregator in the same process or an external message queue

Stacks 
last in, first out
like tennis ball dispensers - you can only get the top ball, and cannot get multiple balls at once.


Most frequently, you'll end up using just the call stack to store intermediate contexts in a recursive algorithm.

Each time a function is called, its state, including the values of its local variables, is added to the call stack. 
Upon the function's completion, the associated information is popped from the stack. The information at the top of the call stack represents the current function being executed. 
Note: This is *not* a .NET  Stack.

For a visual demonstration of the function call stack:
- pick a finished homework project
- set a breakpoint in a method. Avoid Main and the test methods, so that you get a call stack taller than one method call.
- start debugging: press F5 instead of ctrl+F5, or go to Debug/Start
- When the breakpoint hits, display the Call Stack window from Debug/Windows/Call Stack.

Practice #4: write a program that generates a stack overflow.

Stacks are also commonly used in parsing grammars, for example as a step to compile you're writing right now.