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
            for (int i = 0; i < SAI.restaurants.Length; i++)
            {
                if(GameManager.StoreName == SAI.restaurants[i])
                {
                    Name.text = GameManager.list[i,0];
                    Review.text = GameManager.list[i,1];
                }
            }
        }
        if(gameObject.name == ("Review (1)"))
        {
            for (int i = 0; i < SAI.restaurants.Length; i++)
            {
                if(GameManager.StoreName == SAI.restaurants[i])
                {
                    Name.text = GameManager.list[i,2];
                    Review.text = GameManager.list[i,3];
                }
            }
        }

        
    }
}
