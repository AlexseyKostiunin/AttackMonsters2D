using UnityEngine;

public class DistanceTransition : Transition
{
    [SerializeField] private float _transitionRange;
    [SerializeField] private float _rangeSpread;

    private void Start()
    {
        RandomStopPoint();
    }

    private void Update()
    {
        TransitionConditions();
    }

    private void RandomStopPoint()
    {
        _transitionRange += Random.Range(-_rangeSpread, _rangeSpread);
    }

    protected override void TransitionConditions()
    {
        if (Vector2.Distance(transform.position, Target.transform.position) < _transitionRange)
        {
            NeedTransit = true;
        }
    }
}
