using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSkill : Skill
{
    public override string skillName => "Heal";

    public override void Activate()
    {
        Debug.Log("Using skill: Heal");
    }
}
