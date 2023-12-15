using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface TriggerCheckable
{
    bool IsAggroed { get; set; }
    bool IsWithinStriking { get; set; }

    void setAggroStatus(bool isAggroed);
    void setStrikingDistanceBool(bool isWithinStrikingDistance);
}
