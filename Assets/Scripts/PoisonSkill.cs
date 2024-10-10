using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonSkill : Skill
{
    public override string skillName => "Poison";

    public override void Activate()
    {
        Debug.Log("Using skill: Poison");
    }
}
