using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeView : MonoBehaviour, ISpawnItem
{
    public ICubeController CubeController
    {
        get
        {
            if (!_isInit) Init();
            return _cubeController;
        }
    }

    [SerializeField] private GameSettings _gameSettings;

    private ICubeController _cubeController;

    private bool _isInit;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        if (_isInit) return;

        _cubeController = new CubeController(transform, _gameSettings);

        _isInit = true;
    }

    private void Update()
    {
        if (!_isInit) Init();

        _cubeController?.Move();
    }

    public void OnSpawn()
    {
        if (!_isInit) Init();

        _cubeController?.InitCube();
    }
}
