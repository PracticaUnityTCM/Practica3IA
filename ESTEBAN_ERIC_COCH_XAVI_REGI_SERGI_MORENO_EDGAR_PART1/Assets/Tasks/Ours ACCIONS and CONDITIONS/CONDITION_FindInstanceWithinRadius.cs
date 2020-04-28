using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;


[Condition("MyConditions/FindInstanceWithinRadius")] //name of the condition for the 
// BB engine
[Help("Find an instance tagged in a radius from entity")]

public class CONDITION_FindInstanceWithinRadius : GOCondition
// GOCondition is the superclass of conditions that have access to the gameobject
{
    [InParam("radius")]
    public float radius;

    [InParam("tag")]
    public string tag;

    [OutParam("Instance found")] // NOTICE: OutParam
    public GameObject instance;

    // only relevant method for conditions. Perform a check and return the result
    public override bool Check()
    {
        instance = SensingUtils.FindInstanceWithinRadius(gameObject, tag, radius);
        if (instance == null)
            return false;
        else
            return true;
    }
}
