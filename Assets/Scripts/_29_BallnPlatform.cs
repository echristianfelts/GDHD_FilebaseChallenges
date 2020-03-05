using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _29_BallnPlatform : MonoBehaviour
{

    public GameObject ball;
    public float verticalInput;
    public float _playerSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        Vector3 playerVector = new Vector3(0, verticalInput, 0);
        this.transform.Translate(playerVector * Time.deltaTime * _playerSpeed);
        if (this.transform.position.y < 0.35f)
        {
            this.transform.position = new Vector3(0, 0.35f, 0) ;
        }

        if (this.transform.position.y > 4.5f)
        {
            this.transform.position = new Vector3(0, 4.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject sphere = Instantiate(ball, this.transform.position + new Vector3(0f,1f,0f), Quaternion.identity); ;
        }
    }
}
