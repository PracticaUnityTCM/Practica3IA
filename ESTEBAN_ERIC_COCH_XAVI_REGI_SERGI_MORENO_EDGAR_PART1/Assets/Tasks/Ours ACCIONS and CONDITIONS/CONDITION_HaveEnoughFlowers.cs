
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;


[Condition("MyConditions/HaveEnounghFlowers")] //name of the condition for the 
// BB engine
[Help("Find an instance tagged in a radius from entity")]



public class CONDITION_HaveEnoughFlowers : GOCondition
// GOCondition is the superclass of conditions that have access to the gameobject
{
    [InParam("numFlawers")]
    public float numFlowers;

  
   private BOB_Blackboard Blackboard;
    // only relevant method for conditions. Perform a check and return the result
     
    public override bool Check()
    {
        BOB_Blackboard blackboard = gameObject.GetComponent<BOB_Blackboard>();
        if(blackboard.flowers>=numFlowers)
            return false;
        else
            return true;
    }
}
