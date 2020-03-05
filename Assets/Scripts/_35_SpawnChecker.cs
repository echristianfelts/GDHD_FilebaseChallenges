using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _35_SpawnChecker : MonoBehaviour
{
    float _localBirthTime;
    float _age;

    // Start is called before the first frame update
    void Start()
    {
        _localBirthTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        _age = Time.time - _localBirthTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(Time.time);

        if (other.tag == "avoid" && _age < .01)
        {
            Destroy(this.gameObject);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(Time.time);

    //    if (collision.collider.tag == "avoid" && _age <.01)
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}
}
