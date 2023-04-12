using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class desplegarCarta : MonoBehaviour
{
    public Carta carta;
    public Image imagen;
   
    void Start()
    {
        imagen.sprite = carta.spriteImage;
        
    }
}