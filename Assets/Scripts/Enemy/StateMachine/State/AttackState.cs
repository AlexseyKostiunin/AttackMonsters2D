using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AttackState : State
{
    [SerializeField] private int _damage;
    [SerializeField] private float _delayAttack;

    private float _lastAttackTime;
    private Animator _animator;

    public const string Attack = "Attack";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        TimerBetweenAttack();
    }

    private void TimerBetweenAttack()
    {
        if (_lastAttackTime <= 0)
        {
            Assault(Target);

            _lastAttackTime = _delayAttack;
        }

        _lastAttackTime -= Time.deltaTime;
    }

    private void Assault(Player target)
    {
        _animator.Play(nameof(Attack));

        target.ApplyDamage(_damage);
    }
}
