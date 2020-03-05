using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _35_ClicktoSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject _raycastTarget;
    [SerializeField]
    GameObject _spawnObject;
    int _index = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouseclick Positive");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction);

            //this if checks, a detection of hit in an GameObject with the mouse on screen
            if (Physics.Raycast(ray, out hit) && hit.collider.tag == "floor")
            {

                GameObject newEnemy = Instantiate(_spawnObject, hit.point + new Vector3(0f,0.5f,0f), Quaternion.identity);
                newEnemy.name = "newEnemy_" + _index.ToString();
                _index++;
                //      GameObject.Find("Nameofyourobject") search your gameobject on the hierarchy with the desired name and allows you to use it
                //      Destroy(this.gameObject);
            }
        }
    }


}
