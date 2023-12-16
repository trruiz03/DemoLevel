using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalkState : EnemyState
{
    private Transform playerTransform;
    private float movementSpeed = 2f;
    public EnemyWalkState(Enemy enemy, EnemyStateMachine enemyStateMachine) : base(enemy, enemyStateMachine)
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public override void EnterState()
    {
        base.EnterState();
        Debug.Log("Dragon has spotted Enemy");
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void FrameUpdate()
    {
        base.FrameUpdate();

        Vector3 moveDirection = (playerTransform.position - enemy.transform.position).normalized;
        enemy.EnemyMove(moveDirection * movementSpeed);

        if (enemy.IsWithinStriking)
        {
            enemy.StateMachine.ChangeState(enemy.AttackState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
