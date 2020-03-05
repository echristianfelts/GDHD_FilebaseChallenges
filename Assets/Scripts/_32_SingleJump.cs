using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _32_SingleJump : MonoBehaviour
{
    int jumpflag = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) && jumpflag ==1)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up*5f, ForceMode.Impulse);
            jumpflag = 0;
        }
    }

    void OnCollisionEnter(Collision otherObject)

    {
        Debug.Log("Do something here");
        jumpflag = 1;
        //print("Just entered the trigger defined by the object " + otherObject.gameObject.name);

    }




}
