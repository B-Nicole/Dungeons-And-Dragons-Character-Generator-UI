using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public List<int> strengthAbility = new List<int>();
    public List<int> dexAbility = new List<int>();
    public List<int> constitutionAbility = new List<int>();
    public List<int> IntelligenceAbility = new List<int>();
    public List<int> WisdomAbility = new List<int>();
    public List<int> CharismaAbility = new List<int>();

    public Text strength, dexterity, constitution, intelligence, wisdom, charisma;
    public int totalStrength, totalDex, totalCons, totalCharisma, totalIntelli, totalWis;

    public string json;
    public Text jsonText, characterText;

    public void nextScene(string scene)
    {
        Debug.Log("Loading first");
        SceneManager.LoadScene(scene);
    }

    public void playerRace(string choice)
    {
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        Debug.Log("test :" + choice);
        UI.cm.race = choice;
        Debug.Log("STORING  " + UI.cm.race);
    }
    public void playerClass(string choice)
    {
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        Debug.Log("test :" + choice);
        UI.cm.uclass = choice;
        Debug.Log("STORING  " + UI.cm.uclass);


    }

    public void playerAlignment(string choice)
    {
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        Debug.Log("test :" + choice);
        UI.cm.allignment = choice;
        Debug.Log("STORING  " + UI.cm.allignment);


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
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        UI.cm.strength = totalStrength; 
        strength.text = totalStrength.ToString();

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
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        UI.cm.dexterity = totalDex; 
        dexterity.text = totalDex.ToString();

    }
    public void playerConstitution(){
      constitutionAbility.Clear();
        for (int i = 0; i < 5; i++)
        {
            constitutionAbility.Add(Random.Range(1, 7));
        }
        constitutionAbility.Sort();
        totalCons = constitutionAbility[4] + constitutionAbility[3] + constitutionAbility[2];
        totalCons = totalCons + 2; 
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        UI.cm.constitution = totalCons; 
        constitution.text = totalCons.ToString();     
    }
    
    public void playerIntelligence()
    {
        IntelligenceAbility.Clear();
        for (int i = 0; i < 5; i++)
        {
            IntelligenceAbility.Add(Random.Range(1, 7));
        }
        IntelligenceAbility.Sort();
        totalIntelli = IntelligenceAbility[4] +IntelligenceAbility[3] + IntelligenceAbility[2];
        totalIntelli = totalIntelli + 2;
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        UI.cm.intelligence = totalIntelli;
        intelligence.text = totalIntelli.ToString();
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
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        UI.cm.wisdom = totalWis;
        wisdom.text = totalWis.ToString();

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
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        UI.cm.charisma = totalCharisma;
        charisma.text = totalCharisma.ToString();
    }
    public void playerName(string n)
    {
        string name = n;
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        UI.cm.name = name;
    }
   
     //DISPLAYING CHARACTER 
      public void displayCharacter(){
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        characterText.text = "Name: " + UI.cm.name + " Race:" + UI.cm.race + " Class:" + UI.cm.uclass + "Allignment: " + UI.cm.allignment + " Strength:" + UI.cm.strength + " Dexterity: " + UI.cm.dexterity + " Constitution: " + UI.cm.constitution + " Intelligence: " + UI.cm.intelligence + " Wisdom: " + UI.cm.wisdom + " Charisma: " + UI.cm.charisma + " Current XP: " + UI.cm.CurrentXP + " Max XP: " + UI.cm.MaxXP + " Current HP: " + UI.cm.Currenthp + " Max HP: " + UI.cm.Maxhp + " Armor Class: " + UI.cm.armorClass + " Speed: " +  UI.cm.speed; 
     
      }
    //IF USER DECIDES TO QUIT RESET
    public void resetIfQuit()
    {
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        UI.cm.name = "John Doe"; 
        UI.cm.uclass = " ";
        UI.cm.allignment = " ";
        UI.cm.race = " ";

        UI.cm.strength = 15;
        UI.cm.dexterity = 15;
        UI.cm.constitution = 15;
        UI.cm.intelligence = 15;
        UI.cm.wisdom = 15;
        UI.cm.charisma = 15;

        UI.cm.CurrentXP = 15;
        UI.cm.MaxXP = 15;
        UI.cm.Currenthp = 15;
        UI.cm.Maxhp = 15;
        UI.cm.armorClass = 15;
        UI.cm.speed = 15;
    }
     
    // DISPLAYING JSON TEXT 
    public void saveToJson(){
        UIManager UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        json = JsonUtility.ToJson(UI.cm);
        Debug.Log(json);
        jsonText.text = json; 
     }
  
    public void Exit()
    {
        Debug.Log("APPLICATION HAS QUIT");
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
