
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;


[Condition("MyConditions/NumBoxesTransported")] //name of the condition for the 
// BB engine
[Help("Find an instance tagged in a radius from entity")]



public class CONDITION_NumBoxesTransported : GOCondition
// GOCondition is the superclass of conditions that have access to the gameobject
{

    private bool lastTime;

    private BOB_Blackboard Blackboard;
    // only relevant method for conditions. Perform a check and return the result
     
    public override bool Check()
    {
        BOB_Blackboard blackboard = gameObject.GetComponent<BOB_Blackboard>();
        return blackboard.numBoxesTransported < blackboard.numBoxesMax;
        /*
        if (blackboard.numBoxesTransported < blackboard.numBoxesMax)
        {
            lastTime = true;

            return true;
        }
        else if (blackboard.numBoxesTransported >= blackboard.numBoxesMax && !lastTime)
        {
            lastTime = false;
            return false;
        }
        else
            return lastTime;*/
      
    }
}
