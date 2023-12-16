using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.AI;

public class EnemyIdleState : EnemyState
{


    public EnemyIdleState(Enemy enemy, EnemyStateMachine enemyStateMachine) : base(enemy, enemyStateMachine)
    {
    }

    public override void EnterState()
    {
        Debug.Log("I'm an idle Enemy");
        base.EnterState();
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

    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

}
