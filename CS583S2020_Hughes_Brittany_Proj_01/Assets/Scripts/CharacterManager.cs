using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

[Serializable] //This is Complete
public class CharacterManager {
    public String name = "John Doe"; //{ get; set; }
    public String uclass;
    public String allignment;
    public String race;

    public float strength = 15;
    public float dexterity = 15;
    public float constitution = 15;
    public float intelligence = 15;
    public float wisdom = 15;
    public float charisma = 15; 

    public int CurrentXP = 15;
    public int MaxXP = 15; 
    public int Currenthp = 15;
    public int Maxhp = 15;
    public int armorClass = 15;
    public int speed = 15;
    public List<string> item = new List<string>();//item list - leave empty for this assignment 

    // JSON CREATION


}
