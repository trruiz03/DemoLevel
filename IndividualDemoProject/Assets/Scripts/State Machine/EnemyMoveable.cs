using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface EnemyMoveable
{
    Rigidbody RB { get; set; }

    void EnemyMove(Vector3 velocity);
}
