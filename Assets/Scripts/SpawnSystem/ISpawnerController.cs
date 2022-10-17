using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawnerController
{
    void UpdateSpawnSettings(SpawnSettings spawnSettings);
    void Spawn();
}
