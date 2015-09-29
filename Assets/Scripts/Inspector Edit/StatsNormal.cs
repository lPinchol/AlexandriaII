using UnityEngine;
using System.Collections;

public class StatsNormal : MonoBehaviour
{
    public string nameHero;

    public int lvlHero;

    public float expHero;

    public TypeArm typeArm = TypeArm.Sword;
}

public enum TypeArm
{
    Sword,
    Dagge,
    Staff,
    Stick
}
