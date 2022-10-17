using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSettingsView : MonoBehaviour
{
    [SerializeField] private GameSettings _gameSettings;

    private ICubeSettingsController _cubeSettingsController;
    private bool _isInit;

    private CubeSettings _cubeSettings;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        if (_isInit) return;

        if (_gameSettings != null)
        {
            _cubeSettings = _gameSettings.CubeSettings;

            _cubeSettingsController = new CubeSettingsController(_gameSettings);
        }

        _isInit = true; 
    }

    public void OnMovementSpeedChanged(string movementSpeedText)
    {
        if (!_isInit) Init();

        if (movementSpeedText == null) return;

        if (!float.TryParse(movementSpeedText, out var movementSpeed)) return;
        var distance = _cubeSettings.Distance;

        _cubeSettings = new CubeSettings(movementSpeed, distance);

        _cubeSettingsController?.UpdateCubeSettings(_cubeSettings);

    }

    public void OnDistanceChanged(string distanceText)
    {
        if (!_isInit) Init();        

        if (!float.TryParse(distanceText, out var distance)) return;
        var movementSpeed = _cubeSettings.MovementSpeed;

        _cubeSettings = new CubeSettings(movementSpeed, distance);

        _cubeSettingsController?.UpdateCubeSettings(_cubeSettings);
    }

}
