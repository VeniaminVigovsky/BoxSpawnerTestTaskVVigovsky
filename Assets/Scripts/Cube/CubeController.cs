using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : ICubeController
{
    private Transform _selfT;
    private GameSettings _gameSettings;

    private float _movementSpeed;
    private float _distance;

    private Vector3 _startPosition;

    private bool _isInit;

    public CubeController(Transform selfT, GameSettings gameSettings)
    {
        _selfT = selfT;
        _gameSettings = gameSettings;
        if (_gameSettings != null)
        {
            _gameSettings.CubeSettingsChanged += UpdateCubeSettings;
            UpdateCubeSettings(_gameSettings.CubeSettings);
        }
    }

    public void InitCube()
    {
        if (_selfT == null) return;

        _startPosition = _selfT.position;
        _isInit = true;
    }

    public void UpdateCubeSettings(CubeSettings cubeSettings)
    {
        _movementSpeed = cubeSettings.MovementSpeed;
        _distance = cubeSettings.Distance;
    }

    public void Move()
    {
        if (_selfT == null || !_isInit) return;

        _selfT.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);

        if (_selfT.position.z - _startPosition.z >= _distance)
        {
            _selfT.gameObject.SetActive(false);
            _isInit = false;
        }
    }
}
