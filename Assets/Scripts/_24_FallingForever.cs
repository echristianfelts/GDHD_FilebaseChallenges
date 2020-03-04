using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _24_FallingForever : MonoBehaviour
{
    float _force = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("We are getting some action...");
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * _force, ForceMode.Impulse);
        this.transform.position = new Vector3(0f, 5f, 0f);
        //_force = _force + _force;
    }

}
