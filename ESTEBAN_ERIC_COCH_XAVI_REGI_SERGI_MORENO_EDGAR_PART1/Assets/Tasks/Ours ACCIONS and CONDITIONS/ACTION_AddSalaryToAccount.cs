using UnityEngine;
using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus

[Action("MyActions/AddSalaryToAccount")]
[Help("Increment Flowers Count +1. Uses agent's own BB")]

public class ACTION_AddSalaryToAccount : BBUnity.Actions.GOAction
{

    public override void OnStart()
    {
        base.OnStart();
    }

    public override TaskStatus OnUpdate()
    {
        // get the blackboard. Fail + error message if no blackboard attached 
        BOB_Blackboard blackboard = gameObject.GetComponent<BOB_Blackboard>();
        if (blackboard == null)
        {
            Debug.Log("No blackboard attached to gameobject in Drink Beer. Failing");
            return TaskStatus.FAILED;
        }
        else
        {
            blackboard.GetPaid();
            blackboard.numBoxesTransported = 0;
            return TaskStatus.COMPLETED;
        }
    }

}
