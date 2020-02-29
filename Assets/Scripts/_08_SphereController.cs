using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _08_SphereController : MonoBehaviour
{
    public GameObject Sphere_01;
    public GameObject Sphere_02;
    public GameObject Sphere_03;
    private int _collisionCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().material.color = new Vector4(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0);
    }

    // Update is called once per frame
    void Update()
    { 

        {
            Sphere_01.GetComponent<Rigidbody>().useGravity = true;
            Debug.Log("Words...");
        }

        if (_collisionCount == 1)
        {
            Sphere_02.GetComponent<Rigidbody>().useGravity = true;
            Debug.Log("More Words...");
        }

        if (_collisionCount == 2)
        {
            Sphere_03.GetComponent<Rigidbody>().useGravity = true;
            Debug.Log("Still More Words...");
        }

        if (_collisionCount == 3)
        {
            Sphere_01.GetComponent<Renderer>().material.color = new Vector4(0, 1, 0, 0);
            Sphere_02.GetComponent<Renderer>().material.color = new Vector4(0, 1, 0, 0);
            Sphere_03.GetComponent<Renderer>().material.color = new Vector4(0, 1, 0, 0);
            Debug.Log("Final Words...");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Renderer>().material.color = new Vector4(1, 0, 0, 0);
        _collisionCount++;
    }
}
