using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class _19_CoinDisplayandUI : MonoBehaviour
{


    public GameObject _individualCoin;
    private int _index;
    private int _clickedCoins = 0;
    [SerializeField]
    private Text _PlayerNameText;


    // Start is called before the first frame update
    void Start()
    {
        _PlayerNameText.text = "Coins Collected: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newEnemy = Instantiate(_individualCoin, new Vector3(Random.Range(-9f,9f),-1f,0f), Quaternion.identity);
            newEnemy.name = "newEnemy_" + _index.ToString();
            _index++;

        }
        //this if check for the mouse left click
        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("Mouseclick Positive");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction);
            //Debug.Log(hit.collider);
            //this if checks, a detection of hit in an GameObject with the mouse on screen
            if (Physics.Raycast(ray, out hit))
            {
                _clickedCoins++;
                _PlayerNameText.text = "Coins Collected: " + _clickedCoins.ToString();
                Debug.Log(hit.collider.name);
                Debug.Log("RaycastCommand Positive");

                //GameObject.Find("Nameofyourobject") search your gameobject on the hierarchy with the desired name and allows you to use it
                Destroy(GameObject.Find(hit.collider.gameObject.name));
            }
        }

    }
}
