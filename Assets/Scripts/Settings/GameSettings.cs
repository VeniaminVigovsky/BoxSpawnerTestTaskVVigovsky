using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Game Settings", menuName ="Game Settings")]
public class GameSettings : ScriptableObject
{
    public event Action<CubeSettings> CubeSettingsChanged;
    public event Action<SpawnSettings> SpawnSettingsChanged;

    public CubeSettings CubeSettings
    {
        get
        {
            return _cubeSettings;
        }
        set
        {
            _cubeSettings = value;
            CubeSettingsChanged?.Invoke(_cubeSettings);
        }
    }

    public SpawnSettings SpawnSettings
    {
        get
        {
            return _spawnSettings;
        }
        set
        {
            _spawnSettings = value;
            SpawnSettingsChanged?.Invoke(_spawnSettings);
        }
    }

    [SerializeField] private CubeSettings _cubeSettings;
    [SerializeField] private SpawnSettings _spawnSettings;
}
