using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _18_CoinDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this if check for the mouse left click
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouseclick Positive");
            //Raycast;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction);
            //Debug.Log(hit.collider);
            //this if checks, a detection of hit in an GameObject with the mouse on screen
            if (Physics.Raycast(ray, out hit))
            {
                //GameObject.Find("Nameofyourobject") search your gameobject on the hierarchy with the desired name and allows you to use it
                Destroy(this.gameObject);
            }
        }
    }
}
