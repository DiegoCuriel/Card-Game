using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class desplegarCarta : MonoBehaviour
{
    public List<ScriptableObject> cardList;
    public Image imagen;
    public bool aletorizar;

    private void Start()
    {
        int randomIndex = Random.Range(0, cardList.Count); // Obtener un índice aleatorio
        ScriptableObject randomCard = cardList[randomIndex]; // Obtener el ScriptableObject aleatorio

        Sprite cardSprite = null;
        if (randomCard is Carta) // Verificar si el ScriptableObject es del tipo correcto
        {
            cardSprite = ((Carta)randomCard).spriteImage; // Obtener la imagen del ScriptableObject
        }
        else
        {
            Debug.LogWarning("El ScriptableObject seleccionado no es del tipo correcto.");
        }

        if (cardSprite != null)
        {
            imagen.sprite = cardSprite; // Asignar la imagen al componente Image
        }
    }

}