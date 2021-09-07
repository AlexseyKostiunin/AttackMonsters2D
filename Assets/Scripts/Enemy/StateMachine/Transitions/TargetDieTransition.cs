using UnityEngine;

public class TargetDieTransition : Transition
{
    private void Update()
    {
        TransitionConditions();
    }

    protected override void TransitionConditions()
    {
        if (Target == null)
            NeedTransit = true;
    }
}
