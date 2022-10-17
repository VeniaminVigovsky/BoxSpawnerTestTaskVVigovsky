using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController<T> : ISpawnerController where T : Component, ISpawnItem
{
    private GameSettings _gameSettings;

    private ObjectPool<T> _spawningPool;

    private float _timeBetweenSpawns;
    private float _lastSpawnTime;

    public SpawnerController(T spawnItemPrefab, GameSettings gameSettings)
    {
        _spawningPool = new ObjectPool<T>(spawnItemPrefab, 5);        
        _gameSettings = gameSettings;

        if (_gameSettings != null)
        {
            _gameSettings.SpawnSettingsChanged += UpdateSpawnSettings;
            UpdateSpawnSettings(_gameSettings.SpawnSettings);
        }

        _lastSpawnTime = Time.time - _timeBetweenSpawns;
    }

    public void Spawn()
    {
        if (_lastSpawnTime + _timeBetweenSpawns > Time.time) return;

        var spawnItem = _spawningPool.GetFromPool();
        if (spawnItem != null)
        {
            spawnItem.transform.position = Vector3.zero;
        }
        spawnItem?.OnSpawn();
        _lastSpawnTime = Time.time;
    }

    public void UpdateSpawnSettings(SpawnSettings spawnSettings)
    {
        _timeBetweenSpawns = spawnSettings.TimeBetweenSpawns;
    }
}
