using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIManager : MonoBehaviour //mono allows you to connect to game object 
{
    //stuff im too lazy to organize 
    public List<float> strengthAbility = new List<float>();
    public List<float> dexAbility = new List<float>();
    public List<float> constitutionAbility = new List<float>();
    public List<float> IntelligenceAbility = new List<float>();
    public List<float> WisdomAbility = new List<float>();
    public List<float> CharismaAbility = new List<float>();

    public float totalStrength, totalDex, totalCons, totalCharisma, totalIntelli, totalWis;

    // _________________________
    public CharacterManager cm;
    public string json; 
   
 
   
    void OnEnable() { // onEnable is called once - use it for Character Manager   
        cm = new CharacterManager();
    }

    // trying something 
    public void playerRace(string choice)
    {
        Debug.Log("test :"+ choice);
        cm.race = choice;
        Debug.Log("STORING  " + cm.race);
    }
    public void playerClass(string choice)
    {
       
        Debug.Log("test :" + choice);
        cm.uclass = choice;
        Debug.Log("STORING  " + cm.uclass);


    }
    
    public void playerAlignment(string choice)
    {
        Debug.Log("test 2 :"+ choice);
        cm.allignment = choice;
        Debug.Log("STORING  " + cm.race);

    }

    public void playerStrength()
    {
        strengthAbility.Clear();
        for (int i = 0; i < 5; i++)
        {
            strengthAbility.Add(Random.Range(1, 7));
        }
        strengthAbility.Sort();
        totalStrength = strengthAbility[4] + strengthAbility[3] + strengthAbility[2];
        totalStrength = totalStrength + 2;
        cm.strength = totalStrength;
        

    }
    public void playerDexterity()
    {
        dexAbility.Clear();
        for (int i = 0; i < 5; i++)
        {
            dexAbility.Add(Random.Range(1, 7));
        }
        dexAbility.Sort();
        totalDex = dexAbility[4] + dexAbility[3] + dexAbility[2];
        totalDex = totalDex + 2;
        cm.dexterity = totalDex;
    }
    public void playerConstitution()
    {
        constitutionAbility.Clear();
        for (int i = 0; i < 5; i++)
        {
            constitutionAbility.Add(Random.Range(1, 7));
        }
        constitutionAbility.Sort();
        totalCons = constitutionAbility[4] + constitutionAbility[3] + constitutionAbility[2];
        totalCons = totalCons + 2;
        cm.constitution = totalCons;
    }
    public void playerIntelligence()
    {
        IntelligenceAbility.Clear();
        for (int i = 0; i < 5; i++)
        {
            IntelligenceAbility.Add(Random.Range(1, 7));
        }
        IntelligenceAbility.Sort();
        totalIntelli = IntelligenceAbility[4] + IntelligenceAbility[3] + IntelligenceAbility[2];
        totalIntelli = totalIntelli + 2;
        cm.intelligence = totalIntelli;
    }
    public void playerWisdom()
    {
        WisdomAbility.Clear();
        for (int i = 0; i < 5; i++)
        {
            WisdomAbility.Add(Random.Range(1, 7));
        }
        WisdomAbility.Sort();
        totalWis = WisdomAbility[4] + WisdomAbility[3] + WisdomAbility[2];
        totalWis = totalWis + 2;
        cm.wisdom = totalWis; 

    }
    public void playerCharisma()
    {
        CharismaAbility.Clear();
        for (int i = 0; i < 5; i++)
        {
            CharismaAbility.Add(Random.Range(1, 7));
        }
        CharismaAbility.Sort();
        totalCharisma = CharismaAbility[4] + CharismaAbility[3] + CharismaAbility[2];
        totalCharisma = totalCharisma + 2;
        cm.charisma = totalCharisma;
    } 
    public void playerName(string n)
    {
        string name = n;
        cm.name = name; 
    }
    // DISPLAYING JSON TEXT 
    public void saveToJson()
    {
        json = JsonUtility.ToJson(cm);
        Debug.Log(json);
      
    }


    //________________________________________---
    public void CurrentXP() {cm.CurrentXP = 15;}
    public void MaxXP() {cm.MaxXP = 15;}
    public void Currenthp(){cm.Currenthp = 15;}
    public void Maxthp(){cm.Maxhp = 15;}
    public void armorClass(){cm.armorClass = 15;}
    public void speed(){cm.speed = 15;}    


}
