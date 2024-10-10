using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] SkillFactory skillFactory;
    [SerializeField] Transform player;


    public void UseHealSkill(string skillName)
    {
        skillFactory.CreateSkill(skillName, player);
    }
}
