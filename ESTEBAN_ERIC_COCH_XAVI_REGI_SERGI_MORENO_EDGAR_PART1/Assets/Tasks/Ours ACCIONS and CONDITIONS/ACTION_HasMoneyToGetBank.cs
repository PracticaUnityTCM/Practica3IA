using UnityEngine;
using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus

[Action("MyActions/HasMoneyToGetBank")]
[Help("Check if money in account. Uses agent's own BB")]

public class ACTION_HasMoneyToGetBank : BBUnity.Actions.GOAction
{

    public override void OnStart()
    {
        base.OnStart();
    }

    public override TaskStatus OnUpdate()
    {
        BOB_Blackboard blackboard = gameObject.GetComponent<BOB_Blackboard>();
        if (blackboard == null)
        {
            Debug.Log("No blackboard attached to gameobject in condition CheckMoney");
            return TaskStatus.FAILED;
        }
        if (blackboard.HasMoneyToGoBanck())
            return TaskStatus.COMPLETED;
        else return TaskStatus.FAILED;
        //    if (blackboard.HasMoneyToGoBanck())
        //    {
        //        lasTime = true;
        //        return true;
        //    }
        //    else if (!blackboard.HasMoneyToGoBanck() && !lasTime)
        //    {
        //        lasTime = false;
        //        return false;
        //    }
        //    else
        //        return lasTime;

        //    // get the blackboard. Fail + error message if no blackboard attached 
        //    BOB_Blackboard blackboard = gameObject.GetComponent<BOB_Blackboard>();
        //    if (blackboard == null)
        //    {
        //        Debug.Log("No blackboard attached to gameobject in Drink Beer. Failing");
        //        return TaskStatus.FAILED;
        //    }
        //    else
        //    {
        //        blackboard.GetPaid();
        //        blackboard.numBoxesTransported = 0;
        //        return TaskStatus.COMPLETED;
        //    }
    }

}


