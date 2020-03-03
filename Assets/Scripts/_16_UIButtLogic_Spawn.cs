using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _16_UIButtLogic_Spawn : MonoBehaviour
{
    private int _cubeCount = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void SpawnCube()
    {
        if (_cubeCount < 1)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.name = "TestCube";
            _cubeCount++;
        }
    }
}
