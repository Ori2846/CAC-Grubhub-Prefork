using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SetAllergicItems : MonoBehaviour
{
    public string[] restaurants;
    public string[] restaurantsallergies;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable() {
        for(int i =0; i <restaurants.Length-1;i++)
        {
            if(GameObject.Find("RestaurantName_Title").GetComponent<TMP_Text>().text == restaurants[i])
            {
                gameObject.GetComponent<TMP_Text>().text = restaurantsallergies[i];
            }
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
