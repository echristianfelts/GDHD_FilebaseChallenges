using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class _17_DynamicLivesDisplay : MonoBehaviour
{
    //public SpriteRenderer healthSprite_01a;
    public GameObject healthSprite_01;
    public GameObject healthSprite_02;
    public GameObject healthSprite_03;
    public GameObject healthSprite_04;
    public GameObject healthSprite_05;
    private int _healthcount = 3;

    // Start is called before the first frame update
    void Start()
    {
        healthSprite_01.SetActive(true);
        healthSprite_02.SetActive(true);
        healthSprite_03.SetActive(true);
        healthSprite_04.SetActive(false);
        healthSprite_05.SetActive(false);
        //Image _image = healthSprite_01.GetComponent<Image>();
        //_image.tintColor = new Vector4(1, 0, 0, 0);

        //Sprite_01 = new Vector4(0,0,0,1);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _healthcount ++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _healthcount--;
        }
        if (_healthcount < 0)
        {
            _healthcount = 0;
        }
        if (_healthcount >= 5)
        {
            _healthcount = 5;
        }

        switch (_healthcount)
        {
            case 0:
                healthSprite_01.SetActive(false);
                healthSprite_02.SetActive(false);
                healthSprite_03.SetActive(false);
                healthSprite_04.SetActive(false);
                healthSprite_05.SetActive(false);
                break;
            case 1: //easy
                healthSprite_01.SetActive(true);
                healthSprite_02.SetActive(false);
                healthSprite_03.SetActive(false);
                healthSprite_04.SetActive(false);
                healthSprite_05.SetActive(false);
                break;
            case 2: //medium
                healthSprite_01.SetActive(true);
                healthSprite_02.SetActive(true);
                healthSprite_03.SetActive(false);
                healthSprite_04.SetActive(false);
                healthSprite_05.SetActive(false);
                break;
            case 3:
                healthSprite_01.SetActive(true);
                healthSprite_02.SetActive(true);
                healthSprite_03.SetActive(true);
                healthSprite_04.SetActive(false);
                healthSprite_05.SetActive(false);
                break;
            case 4:
                healthSprite_01.SetActive(true);
                healthSprite_02.SetActive(true);
                healthSprite_03.SetActive(true);
                healthSprite_04.SetActive(true);
                healthSprite_05.SetActive(false);
                break;
            case 5:
                healthSprite_01.SetActive(true);
                healthSprite_02.SetActive(true);
                healthSprite_03.SetActive(true);
                healthSprite_04.SetActive(true);
                healthSprite_05.SetActive(true);
                break;
            default:
                break;

        }
    }
}
