using UnityEngine;
using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus

[Action("MyActions/Take")]
[Help("parents an object ('takes it')")]

public class Action_Take : BBUnity.Actions.GOAction
{

    [InParam("Object to take")]
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
            target.transform.parent = gameObject.transform;
            return TaskStatus.COMPLETED;
        }
    }

}