# Organizational Design Pattern

## How the Idea appeared

I have used the Class name as Manager a lot of times. Most of the times, a Manager class handles the responsibility of a lot of other classes. Similary, we have the concept of Director. Basically, these represent some sort of Responsibility. So, why can't we have something similar in code where the class name can lead us to the behavior and encourage readibility.

It's about the usage of Organization like design where different components are organized in Hierarchy.

One team doesn't talk directly,  their Manager talk, At a Higher level, their Directors talk and So on, In this way we can create a design where Classes also take the same kind of hierarchy and responsbility as the Organization Hierarchy.

## Where it can be useful

* Delegation to Lower Layer


## Still thinking ???

* May be useful as an attribute, as it can make clear what the Usage of the Class can do ?


```
internal class Developer
{

}

internal class SrDeveloper
{

}

internal class LeadDeveloper
{

}

internal class Manager
{

}

internal class SrManager
{

}

public class Director
{
 public void DoWork()
 {
     // Delegate

 }
}

Director D1 = new Director1();
D1.DoWork();

```


