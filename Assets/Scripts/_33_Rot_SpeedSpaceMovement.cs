using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _33_Rot_SpeedSpaceMovement : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float m_Speed;
    float horizontalInput;
    float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 playerVector = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(playerVector * Time.deltaTime * m_Speed, Space.World);

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        //transform.rotation = Quaternion.LookRotation(movement);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);




        //transform.Translate(movement * m_Speed * Time.deltaTime, Space.World);


    }
}
        

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
        //    m_Rigidbody.velocity = transform.forward * m_Speed;
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
        //    m_Rigidbody.velocity = -transform.forward * m_Speed;
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    //Rotate the sprite about the Y axis in the positive direction
        //    transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * m_Speed, Space.World);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    //Rotate the sprite about the Y axis in the negative direction
        //    transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * m_Speed, Space.World);
        //}


