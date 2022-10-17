using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSettingsController : ICubeSettingsController
{
    private GameSettings _gameSettings;

    public CubeSettingsController(GameSettings gameSettings)
    {
        _gameSettings = gameSettings;
    }

    public void UpdateCubeSettings(CubeSettings cubeSettings)
    {
        if (_gameSettings == null) return;
        _gameSettings.CubeSettings = cubeSettings;
    }
}
