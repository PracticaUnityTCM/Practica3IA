using UnityEngine;
using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus

[Action("MyActions/InstanceBoucket")]
[Help("Increment Flowers Count +1. Uses agent's own BB")]

public class ACTION_InstanceBoucket : BBUnity.Actions.GOAction
{
    [InParam("Bloucket")]
    public GameObject Boucket;

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
            Debug.Log("incflowers");
           
            return TaskStatus.COMPLETED;
        }
    }

}
