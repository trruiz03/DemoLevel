using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Damageable
{
    void Damage(float damageAmount);

    void die();

    float MaxHealth { get; set; }
    float currentHealth {  get; set; }
}
