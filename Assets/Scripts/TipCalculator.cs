using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{

    public float mealcost = 20.00f;
    public float tipAmount = 18.5f;


    // Start is called before the first frame update
    void Start()
    {
        TipGenereator();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 

        TipGenereator();
         }

    }

    void TipGenereator()
    {
        float tip_ = mealcost * tipAmount * 0.01f;
        float mealcost_ = mealcost + tip_;
        float tip_15 = mealcost * 0.15f;
        float mealcost_15 = mealcost + tip_15;
        float tip_20 = mealcost * 0.20f;
        float mealcost_20 = mealcost + tip_20;
        float tip_25 = mealcost * 0.25f;
        float mealcost_25 = mealcost + tip_25;


        Debug.Log("Your bill is: $" + mealcost + ".");
        Debug.Log("A 15% tip is: $" + tip_15 + " and brings the cost to $" + mealcost_15 + ".");
        Debug.Log("A 20% tip is: $" + tip_20 + " and brings the meal cost to $" + mealcost_20 + ".");
        Debug.Log("A 25% tip is: $" + tip_25 + " and brings the meal cost to $" + mealcost_25 + ".");
        Debug.Log("And your custom " + tipAmount + "% tip is: " + tip_ + ".  That would be a total bill of : $" + mealcost_ + ".");

    }
}
