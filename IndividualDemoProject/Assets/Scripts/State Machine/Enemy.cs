using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour, Damageable, EnemyMoveable, TriggerCheckable
{
    [field: SerializeField] public float MaxHealth { get; set; } = 100f;
    public float currentHealth { get; set; }
    public Rigidbody RB { get; set; }

    public EnemyStateMachine StateMachine { get; set; }

    public bool IsAggroed { get; set; }
    public bool IsWithinStriking { get; set; }

    //State Machine Variables
    public EnemyIdleState IdleSate { get; set; }
    public EnemyAttackState AttackState { get; set; }
    public EnemyWalkState WalkState { get; set; }
    public EnemyDeadState DeadState { get; set; }

    //______________________________________________

    public Rigidbody fireball;

    public float RandomMovementRange = 15f;
    public float RandomMovementSpeed = 2f;

    //_______________________________________________

    private void Awake()
    {
        StateMachine = new EnemyStateMachine();

        IdleSate = new EnemyIdleState(this, StateMachine);
        WalkState = new EnemyWalkState(this, StateMachine);
        AttackState = new EnemyAttackState(this, StateMachine);
        DeadState = new EnemyDeadState(this, StateMachine);
    }

    private void Start()
    {
        this.gameObject.transform.eulerAngles = Vector3.zero;

        currentHealth = MaxHealth;

        RB = GetComponent<Rigidbody>();

        StateMachine.Initialize(IdleSate);
    }

    private void Update()
    {
        StateMachine.CurrentEnemyState.FrameUpdate();
    }

    private void FixedUpdate()
    {
        StateMachine.CurrentEnemyState.PhysicsUpdate();
    }

    public void Damage(float damageAmount)
    {

        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            die();
        }
    }

    public void die()
    {
        StateMachine.ChangeState(DeadState);
    }

    public void EnemyMove(Vector3 velocity)
    {
        RB.velocity = velocity;
    }

    public void setAggroStatus(bool isAggroed)
    {
        IsAggroed = isAggroed;
    }

    public void setStrikingDistanceBool(bool isWithinStrikingDistance)
    {
        IsWithinStriking = isWithinStrikingDistance;
    }
}


