using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CelebrationState : State
{
    private Animator _animator;

    public const string Celebration = "Celebration";

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play(nameof(Celebration));
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }

}
