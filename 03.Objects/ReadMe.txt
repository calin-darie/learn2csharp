Welcome to Week3: Objects!

You will learn about:
- methods
- properties
- fields
- constructors

Test often! Test and commit (but not push) after each exercise. 
This way you can go about the changes with courage. 
Should something go horribly wrong, don't panic! You've got git to back you up. Go to team explorer, find the changes tab, right click any file or files you want to revert to the previous commit, and choose to undo the changes.

Suppose you develop a simple 2D game. In this game, there are some circles moving on a 2D surface.


1) The game has to detect when you click on a circle.

Given 
a point at (clickPointX, clickPointY)
circle A, centered at (circleCenterX, circleCenterY), with a radius of radiusA,
Is the point inside the circle?

A point is inside a circle if the distance between the point and the circle's center is less than or equal to the circle's radius.

The distance between the two points (clickPointX, clickPointY) and (circleCenterX, circleCenterY) is 
Math.Sqrt((clickPointX - circleCenterX)*(clickPointX - xA) + (clickPointY - circleCenterY)*(clickPointY - circleCenterY))



2) The game has to detect when two circles are colliding with each other.

Given 
circle A, centered at (circleCenterX, circleCenterY), with a radius of radiusA and
circle B, centered at (othercircleCenterX, othercircleCenterY), with a radius of radiusB
Did the circles collide?

In our game, two circles collide if the sum of their radii is less than or equal to the distance between their centers.

The distance between two points (circleCenterX, circleCenterY) and (othercircleCenterX, othercircleCenterY) is 
Math.Sqrt((othercircleCenterX - circleCenterX)*(othercircleCenterX - circleCenterX) +
 (othercircleCenterY - circleCenterY)*(othercircleCenterY - circleCenterY))


3) Time to clean the code up a little - part 1: extracting a method. 
See how the formula to compute the distance between two points appears twice in the program? This is wrong in multiple ways:
- as a reader of the program, you have no immediate way to figure out that the logic is the same. Suppose someone else reads your code, or you revisit it one year from now. You'll have to carefully compare the code to know it's the same logic. You have to understand the same logic twice. 
- as a bug fixer, you'll have to remember to fix twice. Suppose someone reports a bug for clicking on a circle. You happily fix only the first of the two occurrences, oblivious of the second. The point-in-circle part of the program gets retested. The issue gets closed. Suppose another bug is reported, this time for the collision detection. Someone else fixes that bug, and after testing only collision detection, the second bug is closed. Now we're in a mess: we still have two bugs about to be reported, so we're going through the overhead of reporting-planning-dev-testing twice. And now we have code that was originally supposed to work the same, but has diverged, and not by design. If someone now carefully compares the two pieces of code, they'll discover it's not the same logic. "Hmm... this could be for a reason. No one quite remembers why, and we don't have time to investigate right now.". If you need to reuse the logic for a third purpose, which version will they extract now and why?
- as a new story developer, if you ever want to reuse the code, you'll want to extract it into its own method eventually

So we need to extract the duplicated logic into its own method. 
A method is a way of describing a piece of behavior. It's made out of a signature and a body. In a signature you can find the name of the behavior, a parameter list, and a return type, like this:

        <return type> methodName (<type of parameter1> <name of parameter1>, ..., <type of parameter N> <name of parameter N>)

Parameters are usually input for the method, a notable exception being the output parameters of methods like Dictionary<,>.TryGetValue, double.TryParse etc.


For our example, let's give the new method a name to explain its purpose, like DistanceBetweenPoints. It needs the x and y coordinates of two points as parameters, as double values. It returns a distance as double. So the signature should look like this:

        static double DistanceBetweenPoints(double pointX, double pointY, double otherPointX, double otherPointY)

We're making this method static, to be able to call it from the static method Main. The first double is the return type. Then comes the name. Then, between parentheses, comes the parameter list.

After the signature, in curly brackets, comes the method body . The body needs to compute and then return the distance. You may first compute the distance in a variable, then return that variable. This is what the body may look like:

        {
            var distance = Math.Sqrt((pointX - otherPointX)*(pointX - otherPointX) +
                                     (pointY - otherPointY)*(pointY - otherPointY));
            return distance;
        }

Now one of the two Math.Sqrt(...) calls has been replaced with a more readable DistanceBetweenPoints(...) call. Replace the other Math.Sqrt(...) expression with a call to DistanceBetweenPoints.

In other languages, a static method like we just extracted can be called function, or subroutine.


4) Cleanup part 2: introducing a Point class

The method we extracted is called DistanceBetweenPoints. The name is suggesting we're working with two points. The parameter list however contains four double values. This is making the code a bit harder to read, plus there's the risk that we mess up the order of parameters and send p1X, p2X, p1Y, p2Y instead of p1X, p1Y,   p2X, p2Y. Methods with more than a couple parameters are usually hard to read and maintain. In this case, we can group the parameters together two by two, for clarity and brevity. We can replace each of the two groups of coordinate parameters with a Point parameter. Let's create a new DistanceBetween method, that takes two Point objects as arguments. Copy the existing DistanceBetweenPoints method, and paste it below. Then modify it to look like this:

        static double DistanceBetween(Point point, Point otherPoint)
        {
            var distance = Math.Sqrt((point.X - otherPoint.X)*(point.X - otherPoint.X) +
                                     (point.Y - otherPoint.Y)*(point.Y - otherPoint.Y));
            return distance;
        }

The compiler will complain as soon as you type the first Point parameter. With the cursor on Point, type ctrl+. and use the arrow keys and the enter key to select Generate class for 'Point'.

The compiler will also complain about point.X and point.Y, because there are no properties yet on the newly generated class. With the cursor on X, hit ctrl+. again, and say you want to Generate a property stub for X in CircleCollisionDetection.Point.

The compiler still isn't happy, so let's head over to the newly created point class. With the cursor on Point, hit F12 to go to definition. Now and fix the type of X and Y to be double instead of object. Also make Point public.

public class Point 
{
	double X {get; set;}
	double Y {get; set;}
}

Let's first refactor the old method to use the new one. We can then test that the program behaves the same, before starting to change the code that's calling the method. We need to create a new instance of Point for each couple of (X, Y) coordinate parameters, and then call the new method:

        static double DistanceBetweenPoints(double pointX, double pointY, double otherPointX, double otherPointY)
        {
            var point = new Point
            {
                X = pointX,
                Y = pointY
            };
            var otherPoint = new Point
            {
                X = otherPointX,
                Y = otherPointY
            };
            return DistanceBetween(point, otherPoint);
        }

After we've tested to make sure the refactoring will succeed, we can move the calls over from the old method to the new one. After we're done moving the calls, we can remove the old method, DistanceBetweenPoints. 
Let's start with the click. We need to group clickPointX and clickPointY together in a Point object.
So in Main, after we read clickPointX and clickPointY, let's create a new instance of Point and initialize its X and Y properties:

            var clickPoint = new Point
            {
                X = clickPointX, 
                Y = clickPointY
            };

You may be tempted to combine the initialization of X and Y with the reading, like new Point { X= ReadDouble("x:"), ...}, but you should keep the initialization logic simple. It's easier to debug, plus there are two different things going on in there: 
1. read point coordinates
2. create a Point object

Next, let's do the same for the circleCenter as we did for the click. After you read the x and y for the circle center, add:

            var circleCenter = new Point
            {
                X = circleCenterX,
                Y = circleCenterY
            };

We can now replace the first call to DistanceBetweenPoints. Instead of DistanceBetweenPoints(clickPointX, clickPointY, circleCenterX, circleCenterY), it becomes:

DistanceBetween(clickPoint, circleCenter)

Now that's nicer, more concise. Next, let's move on to replace the second call with 

DistanceBetween(circleCenter, othercircleCenter)

To finish this exercise, delete DistanceBetweenPoints. We donn't need it anymore.

5) Add behavior to Point.
A deeper benefit we get for extracting the Point class is that we can now also move some behavior over to it. DistanceBetween is operating strictly on Point objects, and asking multiple times about Point properties, so its place is actually as a method on the Point class. We can ask a Point object for the DistanceTo another Point.

This is going to work pretty much the same as the previous exercise: 
- copy the DistanceBetween method over to the Point class. Paste it inside the brackets of class Point, either before or after the X and Y properties.
- make it public, and not static
- rename it to DistanceTo
- delete the first argument. The compiler now complains that 'point' is undefined. The first of the two points will be the point we're calling the method on, so where there's an error, replace 'point' with 'this'
            var distance = Math.Sqrt((this.X - otherPoint.X) * (this.X - otherPoint.X) +
                                     (this.Y - otherPoint.Y) * (this.Y - otherPoint.Y));
- in the body of DistanceBetween, as a first line, 
return point.DistanceTo(otherPoint);
- test 
- wherever you have DistanceBetween(a, b), replace with a.DistanceTo(b)
- delete the now unused DistanceBetween method

6) Run the DistanceTo unit test.
There's a project in this solution called CircleCollisionDetection.UnitTests.
There are already some tests in there, that you'll have to enable and run.
- Go to the Solution Explorer window.
- In Solution Explorer, select the project called CircleCollisionDetection.UnitTests
- At the top of the Solution Explorer window, there's a toolbar, with a home button and some other buttons. Hover over the buttons, and wait for the toolptip. Among them there's one whose tooltip says "Show All Files". Click Show All Files
- A bunch of files appear as children of the unit tests project. Right click on PointDistanceTo.cs, and pick "Include in project" from the context menu
- Open PointDistanceTo.cs by double clicking it
- Press ctrl+R,A to run all the tests, or ctrl+R,T to run the tests at the cursor.
- Watch the status bar to know when the tests are done. Then look for the Test Explorer window for the test results.

Try to make the test fail by writing wrong code in DistanceTo. Then make it right again.

7) Notice the pattern 
Console.WriteLine();
var x = ReadDouble("x: ");
var y = ReadDouble("y: ");
var point = new Point {X = x, Y= y}

Extract a method that returns a Point, and takes a string prompt as parameter
static Point ReadPoint (string prompt) 
{
    // writeline prompt; read x and y; construct a point; return the point you created
}

Replace all three occurrences of the pattern with the method.
        Point circleCenter = ReadPoint("Enter center coordinates");
        ...
        Point clickPoint = ReadPoint("Enter click coordinates");
        ...
        Point othercircleCenter = ReadPoint("Enter center coordinates");

In the body of ReadPoint, rename circleCenterX or clickPointX to x, and circleCenterY or clickPointY to y. Use ctrl+R, R


8) Note the "//was the click point on the circle?" comment. 
This comment is explaining what the two lines below are doing. 
Whenever you see an explaining comment, consider extracting a method.
In this case, to better explain the intent, extract a method called IsPointInCircle, that takes a Point, and then another Point for the circle's center and a double for the radius. The method should return a bool: true when the point lies inside the circle, false when it does not.

    static bool IsPointInCircle (Point point, Point circleCenter, double circleRadius)

Now you may safely remove the "//was the click point on the circle?" comment :)

9) Again, we're talking points and circles and sending Point, Point, double. Let's introduce a Circle class, like we did for Point. 
In Solution Explorer, right click on the CircleCollisionDetection project. Choose Add > Add class... Name it Circle. Make it public. Add two properties: Point Center and double Radius:

namespace CircleCollisionDetection
{
    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
    }
}

Now move the IsPointInCircle method over to the Circle class, and name it ContainsPoint. We're not putting the method on Point, 'cause Circle already knows about Point - for its Center - but Point doesn't have to know about Circle. Avoid circular dependencies when you can!

namespace CircleCollisionDetection
{
    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public bool ContainsPoint(Point point)
        {
			//copy the body of IsPointInCircle here. circleCenter becomes this.Center; circleRadius becomes this.Radius;
        }
    }
}

In Main, declare a Circle variable named circle and initialize it to a new Circle instance.
Replace the call to IsPointInCircle with a call to 
    
	circle.Contains(clickPoint)

You may now remove the now unused IsPointInCircle method.

Include CircleContainsPoint.cs in the unit tests project and run the  tests again.

10) There's another comment trying to explain what part of Main is doing:
// did the circles collide?
Create a method on Circle named CollidesWith, that takes another Circle and returns a bool: true when the two circles collide, false when they don't

        public bool CollidesWith(Circle other)
        {
            // compute distance to other circle's center; compare with sum of radii; return the result;
			// as a first step, you may want paste the lines you're trying to extract here; circleCenter becomes this.center; othercircleCenter becomes other.Center
        }

Include and run the CircleCollidesWith tests.

Back in Main, create another Circle object for the second circle we're reading.

            Circle othercircle = new Circle
            {
                Center = othercircleCenter,
                Radius = othercircleRadius
            };

Replace the lines the comment explains with a call to CollidesWith:

	circle.CollidesWith(othercircle)

Remove the "// did the circles collide?" comment


11) Extract a ReadCircle method and use it twice. This should be similar to the way you extracted ReadPoint earlier.

    static Circle ReadCircle(string prompt)

The code in Main should now look like:
            var circle = ReadCircle("Describe a circle");
			...
            var otherCircle = ReadCircle("Describe another circle");

12) White box testing. Your first unit test.

	Add the method below to Circle:

    public class Circle
    {
		...
        public bool Contains(Circle other)
        {
            double distanceBetweenCenters = this.Center.DistanceTo(other.Center);
            return distanceBetweenCenters < this.Radius;
        }
		...
    }

	Include and run the CircleContainsCircle unit tests.

	There's a bug in this new Contains method, that the existing tests aren't catching. 
	You must find a test case that's failing, write the test, see it fail, then fix the Contains method. *Don't* use the console. 
	
	Write a new unit test in CircleContainsCircle to verify your assumptions. Play with the values in the test and run it often. It's faster than using the console, and then it stays there as self-executing spec for your program.
	
	If intuition is failing you, you may use drawings on math / graph paper, or just google "circle contains circle", or look at the answer here http://stackoverflow.com/questions/33490334/check-if-a-circle-is-contained-in-another-circle
	In any case, first write the failing unit test, and only then solve the problem in the Circle class. 
	
	You're done when the new test changes from red to green.
	Of course, if you have other test cases in mind, go ahead and write automated tests for them :)
	
	Note that we can name two methods the same as long as their parameter types vary. This is called overloading.
	

===============================================================
This series of exercises has just evolved code written like a script to something that starts to resemble Object Oriented Programming.
As soon as code is no longer all crammed up in a single method
   - we can see at a glance what the original method is doing. it's just a few self-explaining lines now
   - we can start testing the pieces individually