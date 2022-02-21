using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Seed Type")]
public class SeedTypes : ScriptableObject
{
    public new string name;

    public float growthTimer;

    public GameObject spawnWhenFullyGrown;
}
