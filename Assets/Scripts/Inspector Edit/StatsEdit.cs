using UnityEngine;
using System.Collections;

public class StatsEdit : MonoBehaviour
{
    [Header("Name Hero")]
    [Multiline(2)]
    [Tooltip("Name of Hero")]
    public string nameHero;


    [Header("Stats Hero")]
    [Tooltip("Level of Hero")]
    public int lvlHero;

    [Range(1, 100)]
    [Tooltip("Xperience of Hero (1-100)")]
    public float expHero;

    [Tooltip("Type Arm of Hero")]
    public TypeArm2 typeArm = TypeArm2.Sword;
}

public enum TypeArm2
{
    Sword,
    Dagge,
    Staff,
    Stick
}