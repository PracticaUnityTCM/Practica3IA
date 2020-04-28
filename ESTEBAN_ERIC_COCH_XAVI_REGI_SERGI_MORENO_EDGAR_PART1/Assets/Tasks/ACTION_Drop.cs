using UnityEngine;
using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus


[Action("MyActions/Drop")]
[Help("Drops (unparents = nullifies parent) an object")]

public class Action_Drop : BBUnity.Actions.GOAction
{

    [InParam("Object to drop")]
    public GameObject target;


    public override void OnStart()
    {
        base.OnStart();
    }

    public override TaskStatus OnUpdate()
    {
        if (target == null) return TaskStatus.FAILED;
        else
        {
            target.transform.parent = null;
            return TaskStatus.COMPLETED;
        }
    }

}