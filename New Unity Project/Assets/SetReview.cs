using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SetReview : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text Name;
    public TMP_Text Review;
    public Allergy GameManager;
    public SetAllergicItems SAI;
    public int index;

    private void OnEnable() {

    }
    // Update is called once per frame
    void Update()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<Allergy>();
        Name = gameObject.transform.Find("Username").GetComponent<TMP_Text>();
        Review = gameObject.transform.Find("Review Text").GetComponent<TMP_Text>();
        SAI = GameObject.Find("Allergic Items_List").GetComponent<SetAllergicItems>();
        if(gameObject.name == ("Review"))
        {
            if(GameManager.StoreName == "Mcdonalds")
                {
                    Name.text = "Donny";
                    Review.text = "im lovin it";
                }else
                
                   Delete(); 
                
        }
        if(gameObject.name == ("Review (1)"))
        {
            if(GameManager.StoreName == "Mcdonalds")
                {
                    Name.text = "Donny2";
                    Review.text = "im lovin it2";
                } else
                Delete();
        }

        
    }
    void Delete()
    {
        Name.text = "";
        Review.text = "";
    }
}
