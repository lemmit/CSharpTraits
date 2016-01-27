# C# traits

Many programming languages have got a trait/mixin mechanism. You can find those in modern programming languages like Scala and Ruby. 
It is possible to make it work if language allows multiple inheritance (base class then can be threated like trait).
But no in C#.

I tried to emulate somehow trait behaviour.

##Steps - how it was done
###Step 1
Create project with ILoggingTrait in LoggingTrait namespace. [ILoggingTrait interface](https://github.com/lemmit/CSharpTraits/blob/master/LoggingTrait/ILoggingTrait.cs)
That will be used to annotate classes ("extending the trait") [Extended class](https://github.com/lemmit/CSharpTraits/blob/master/CSharpTraits/LoggableClass.cs):
  public class LoggableClass : ILoggingTrait
###Step 2
Define trait. Create another project and create class inside LoggingTrait namespace. [Defined trait](https://github.com/lemmit/CSharpTraits/blob/master/DefineLoggingTrait/DummyLoggingTrait.cs)
It have to be public static class with public static methods that takes this ILoggable @this param.
It will be use as trait definition/placeholder. It can be used when implementing as a stub.
The project that uses the trait should reference project with ILoggingTrait, and that DummyLoggingTrait
###Step 3
Create project and class inside LoggingTrait namespace. This will be concrete implementation of the trait. Again it have to implement extension methods on ILoggingTrait.

###Step 4
Project that contains a class that uses the trait ([Example](https://github.com/lemmit/CSharpTraits/blob/master/CSharpTraits/)) references two projects: the one that contains LoggingTrait.ILoggingTrait interface and one that contains concrete implementation.
In this way we can swap the implementations (just change reference in csproj to other project, or remove old reference and add new in Visual). 

Adventages:
We can mix methods into our classes.
In case we have any method missing from our implementation we'll get a compile time error!
Resolved at compile time (no real-time DI).
Traits can also use state. Just specify the properties in an ITrait.

Disadventages:
No tools to pick concrete implementation easier, and no Intellisense with information that some methods from Dummy trait should be implemented.
Changes of concrete trait implementation made project-wise.


##Something Extra - interface with default implementation
Define interface -> Implement it using extension methods -> call from class if want to use default implementation using a convention:
  this.MethodName(params, @default: true);
More in code (c'mon, it's just one file): [Here](https://github.com/lemmit/CSharpTraits/blob/master/CSharpInterfaceWithDefaultImplementation/Program.cs)
