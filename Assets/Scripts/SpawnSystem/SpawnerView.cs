using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerView : MonoBehaviour
{
    [SerializeField] private GameSettings _gameSettings;
    [SerializeField] private CubeView _cubePrefab;

    private ISpawnerController _spawnController;
    private bool _isInit;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        if (_isInit) return;

        _spawnController = new SpawnerController<CubeView>(_cubePrefab, _gameSettings);

        _isInit = true;
    }

    private void Update()
    {
        if (!_isInit) Init();

        _spawnController?.Spawn();
    }

}
