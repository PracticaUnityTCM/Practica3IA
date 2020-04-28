using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;

[Condition("MyConditions/Has Item")]
[Help("true if parenting an object with the given tag")]

public class CONDITION_HaveItem : GOCondition
{

    [InParam("item tag")]
    public string tag;

    public override bool Check()
    {
        foreach (Transform child in gameObject.transform)
        {
            if (child.gameObject.tag == tag)
                return true;
        }
        return false;
    }
}
