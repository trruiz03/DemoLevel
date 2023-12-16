using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleState : EnemyState
{
    private Vector3 targetPos;
    private Vector3 direction;
    public EnemyIdleState(Enemy enemy, EnemyStateMachine enemyStateMachine) : base(enemy, enemyStateMachine)
    {
    }

    public override void EnterState()
    {
        Debug.Log("I'm an idle Enemy");
        base.EnterState();

        targetPos = GetRandomPosInCircle();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void FrameUpdate()
    {
        base.FrameUpdate();

        if (enemy.IsAggroed)
        {
            enemy.StateMachine.ChangeState(enemy.WalkState);
        }

        direction = (targetPos = enemy.transform.position).normalized;

        enemy.EnemyMove(direction * enemy.RandomMovementSpeed);

        if ((enemy.transform.position = targetPos).sqrMagnitude < 0.01f)
        {
            targetPos = GetRandomPosInCircle();
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    private Vector3 GetRandomPosInCircle()
    {
        return enemy.transform.position + (Vector3)Random.insideUnitCircle * enemy.RandomMovementRange;
    }
}
