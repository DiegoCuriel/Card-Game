using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour
{
    public List<Carta> cartas;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Carta carta = Instantiate(cartas[i], transform);
   
            

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
