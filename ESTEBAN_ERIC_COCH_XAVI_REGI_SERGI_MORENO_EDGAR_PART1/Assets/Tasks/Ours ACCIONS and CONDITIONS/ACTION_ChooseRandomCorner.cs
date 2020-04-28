using UnityEngine;
using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus

[Action("MyActions/ChooseRandomCorner")]
[Help("Coose Random Waypoint in Daisy BB")]

public class ACTION_ChosseRandomCorner : BBUnity.Actions.GOAction
{
    [OutParam("location")]
    public GameObject location;

    public override void OnStart()
    {
        Debug.Log("ssssssssssssss");
        base.OnStart();
    }

    public override TaskStatus OnUpdate()
    {
       
        // get the blackboard. Fail + error message if no blackboard attached 
        Daisy_Blackboard blackboard = gameObject.GetComponent<Daisy_Blackboard>();
        Debug.Log("sssssssssssss");
        if (blackboard == null)
        {
            Debug.Log("No blackboard attached to gameobject in Drink Beer. Failing");
            return TaskStatus.FAILED;
        }
        else
        {

            location = blackboard.GetRandomWaypoint();
          
            return TaskStatus.COMPLETED;
        }
    }
    public override void OnEnd()
    {
        base.OnEnd();
    }

}
