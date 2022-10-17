using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICubeController
{
    void InitCube();
    void UpdateCubeSettings(CubeSettings cubeSettings);
    void Move();
}
