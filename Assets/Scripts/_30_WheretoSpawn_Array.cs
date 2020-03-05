using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _30_WheretoSpawn_Array : MonoBehaviour
{
    public GameObject[] targetBlocks = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int randoNumber = Random.Range(0, 4);
            Debug.Log("randoNumber = " + randoNumber);

            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            float randoNumberX = targetBlocks[randoNumber].transform.position.x;
            float randoNumberZ = targetBlocks[randoNumber].transform.position.z;


            sphere.transform.position = new Vector3(randoNumberX, 1.5f, randoNumberZ);
        }


    }
}
