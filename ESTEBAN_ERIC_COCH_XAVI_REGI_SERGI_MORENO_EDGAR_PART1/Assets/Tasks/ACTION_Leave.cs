using UnityEngine;
using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus
using BBUnity.Actions;		  // actions with "gameobject"


[Action("MyActions/Leave")] 
[Help("Leaves an object (param object) in a specified location (param location)")]

public class ACTION_Leave : GOAction {

    [InParam("object")] 
    public GameObject obj;

    [InParam("location")]
    public GameObject loc;

    public override void OnStart()
    {
        base.OnStart();
    }

    public override TaskStatus OnUpdate()
    {
        if (obj!=null || loc!=null)
        {
            obj.transform.parent = null;
            obj.transform.position = loc.transform.position;
            return TaskStatus.COMPLETED;
        }
        else
        {
            Debug.Log("Action leave fails because null object and or location");
            return TaskStatus.FAILED;
        }
    }

   
}
