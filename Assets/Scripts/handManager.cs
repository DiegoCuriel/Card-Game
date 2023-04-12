using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handManager : MonoBehaviour
{
    
    public List<GameObject> cardList;
    private Vector3 posiciones;
    private bool actualizar = false;

    private void Start()
    {
        // crea un vector con las posiciones de las cartas
        
        for(int i = 0; i < 5; i++)
        {
            
            GameObject carta = Instantiate(cardList[i], transform);
            carta.transform.position = new Vector3(100+i*200, 254, 0);
        }

    }
    public void shuffle()
    {
        actualizar = true;
    }
    private void Update()
    {
        //borra las cartas anteriores y crea las nuevas
        if (actualizar)
        {
            for (int i = 0; i < 5; i++)
            {
                Destroy(transform.GetChild(i).gameObject);
            }
            for (int i = 0; i < 5; i++)
            {
                GameObject carta = Instantiate(cardList[i], transform);
                carta.transform.position = new Vector3(100 + i * 200, 254, 0);
            }
            actualizar = false;
        }
    }
}
