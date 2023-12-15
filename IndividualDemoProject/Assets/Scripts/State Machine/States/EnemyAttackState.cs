using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : EnemyState
{
    private Transform playerTransform;
    private Transform shootingAnchor;

    private float timer;
    private float shotCooldown = 2.33f;

    private float exitTimer;
    private float timeTillExit = 1f;
    private float distanceToCountExit = 2f;
    public EnemyAttackState(Enemy enemy, EnemyStateMachine enemyStateMachine) : base(enemy, enemyStateMachine)
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        shootingAnchor = GameObject.FindGameObjectWithTag("Anchor").transform;

    }

    public override void EnterState()
    {
        base.EnterState();
        Debug.Log("Dragon is Attacking");
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void FrameUpdate()
    {
        base.FrameUpdate();

        enemy.EnemyMove(Vector3.zero);


        if (timer > shotCooldown)
        {
            timer = 0f;
            Vector3 dir = (playerTransform.position - enemy.transform.position).normalized;

            Rigidbody ball = GameObject.Instantiate(enemy.fireball, shootingAnchor.transform.position, Quaternion.identity);
            ball.velocity = dir * 20f;
        }

        if (Vector3.Distance(playerTransform.position, enemy.transform.position) < distanceToCountExit)
        {
            exitTimer += Time.deltaTime;

            if (exitTimer > timeTillExit)
            {
                enemy.StateMachine.ChangeState(enemy.WalkState);
            }
        }
        else
        {
            exitTimer = 0f;
        }
        timer += Time.deltaTime;
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
