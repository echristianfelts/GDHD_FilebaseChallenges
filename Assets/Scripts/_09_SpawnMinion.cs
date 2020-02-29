using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_SpawnMinion : MonoBehaviour
{
    public GameObject minion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject spawnLoc = GameObject.Find("Spawn_Position");
            GameObject spawnMinion = Instantiate(minion, spawnLoc.transform.position, Quaternion.identity);
            Debug.Log("Manditory Notation..!!!");
        }
    }
}


