using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SetReview : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text Name;
    public TMP_Text Review;
    public Allergy GameManager;
    public SetAllergicItems SAI;
    public int index;
    public int Stars;
    public GameObject[] Stars_;

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
                    Stars = GameManager.list2[i,0];
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
                    Stars = GameManager.list2[i,1];
                }
            }
        }
        for(int i=0; i <Stars_.Length;i++)
        {
            if(i< Stars)
            Stars_[i].GetComponent<Image>().color = new Color32(255, 232, 0, 255);
            else
            Stars_[i].GetComponent<Image>().color = new Color32(161, 161, 161, 255);
        }

        
    }
}
