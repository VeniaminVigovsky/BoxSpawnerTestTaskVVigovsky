using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSettingsView : MonoBehaviour
{
    [SerializeField] private GameSettings _gameSettings;

    private ISpawnSettingsController _spawnSettingsController;
    private bool _isInit;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        if (_isInit) return;

        _spawnSettingsController = new SpawnSettingsController(_gameSettings);

        _isInit = true;
    }

    public void OnTimeBetweenChanged(string timeBetweenText)
    {
        if (!_isInit) Init();
        
        if(!float.TryParse(timeBetweenText, out var timeBetween)) return;

        _spawnSettingsController?.UpdateSpawnSettings(new SpawnSettings(timeBetween));
    }

}
