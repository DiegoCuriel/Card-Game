using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handManager : MonoBehaviour
{
    
    public GameObject cardPrefab;
    public Transform handPanel;
    public List<ScriptableObject> cardList;

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject card = Instantiate(cardPrefab, handPanel);
            card.GetComponent<desplegarCarta>().cardList = cardList;
        }
        


    }

}
