using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _21_AntiGravity : MonoBehaviour
{
    float _speed = 1;
    int _flag = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_flag == 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * _speed);
            //if (transform.position.y > 6f)
            //{
            //    Destroy(this.gameObject);
            //}
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        _flag++;
        Debug.Log("Do something here");
        this.GetComponent<Renderer>().material.color = Color.red;
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Ceiling")
        {
            //_flag++;
            //Debug.Log("Do something here");
            //this.GetComponent<Renderer>().material.color = Color.red;
            //If the GameObject's name matches the one you suggest, output this message in the console
            //this.GetComponent<Rigidbody>().useGravity = true;
            //this.GetComponent<Rigidbody>().isKinematic = true;
            //this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            //this.GetComponent<Rigidbody>().sleepVelocity = 0f;
            //rb.isKinematic = true;
            //rb.velocity = Vector3.zero;
            //this.transform.Translate(Vector3.zero);

            //Check for a match with the specific tag on any GameObject that collides with your GameObject
            if (collision.gameObject.tag == "Wall")
            {
                //If the GameObject has the same tag as specified, output this message in the console
                Debug.Log("Do something else here");
                //transform.Translate(Vector3.up * Time.deltaTime * 0 );
            }
        }
    }
}
