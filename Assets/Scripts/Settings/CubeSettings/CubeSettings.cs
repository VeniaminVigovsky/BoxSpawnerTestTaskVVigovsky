using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct CubeSettings
{
    public float MovementSpeed => Mathf.Max(0.1f, _movementSpeed);
    public float Distance => _distance;

    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _distance;

    public CubeSettings (float movementSpeed, float distance)
    {
        _movementSpeed = movementSpeed;
        _distance = distance;
    }
}
