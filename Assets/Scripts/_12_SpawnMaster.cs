using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _12_SpawnMaster : MonoBehaviour
{
    private float _timerTime;

    public GameObject[] objectsToSpawn = new GameObject[4];
    //private GameObject _switch;

    // Start is called before the first frame update
    void Start()
    {
        _timerTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

            if (_timerTime < Time.time)
            {
                for (int i = 0; i <= 3; i++)
                {

                    //WaitForSeconds(.5);
                    Debug.Log(_timerTime);
                    _timerTime = Time.time + 2f;
                    Debug.Log(_timerTime);
                    GameObject newEnemy = Instantiate(objectsToSpawn[Random.Range(0, 4)], Vector3.zero, Quaternion.identity);
                }
            }

    }


    
}
