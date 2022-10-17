using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct SpawnSettings
{
    public float TimeBetweenSpawns => Mathf.Max(0.2f, _timeBetweenSpawns);
    [SerializeField] private float _timeBetweenSpawns;

    public SpawnSettings(float timeBetweenSpawns)
    {
        _timeBetweenSpawns = timeBetweenSpawns;
    }
}
