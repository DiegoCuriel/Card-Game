using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Carta", menuName = "Carta")]
public class Carta : ScriptableObject
{
     public int id;
    public string cardName;
    public string cardDescription;
    public int cost;
    public int power;   
    public int health;
    public Sprite spriteImage;
    
}
