using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSettingsController : ISpawnSettingsController
{
    private GameSettings _gameSettings;

    public SpawnSettingsController(GameSettings gameSettings)
    {
        _gameSettings = gameSettings;
    }

    public void UpdateSpawnSettings(SpawnSettings spawnSettings)
    {
        if (_gameSettings == null) return;

        _gameSettings.SpawnSettings = spawnSettings;
    }
}
