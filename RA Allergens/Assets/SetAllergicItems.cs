using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SetAllergicItems : MonoBehaviour
{
    public string[] restaurants;
    public string[] restaurantsallergies;
    public string SetRest;
    public string Text;
    public string NewText;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable() {
        GameObject.Find("RestaurantName_Title").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("Store");
        for(int i =0; i <restaurants.Length;i++)
        {
            if(GameObject.Find("RestaurantName_Title").GetComponent<TMP_Text>().text == restaurants[i])
            {
                Text = restaurantsallergies[i];
                Text = Text.Replace("\t", "\n");
                gameObject.GetComponent<TMP_Text>().text = Text;
                SetRest=restaurants[i];
                index = i;
            }
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
