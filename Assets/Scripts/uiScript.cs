using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class uiScript : MonoBehaviour
{
    public static int score = 0;

    public TMP_Text manaText;

    public TMP_Text healthText;

    public TMP_Text ScoreText;

    private GameObject playerObject;

    public Wizard wizardObject;

    private int i;
    
    void Update() 
    {
        i++;
        // Wizard.mana 
        
        manaText = "Mana: " + (int)wizardObject.mana;
        healthText = "Mana: " + (int)wizardObject.health;
        ScoreText = "Score: " + wizardObject.score;
    }
    void Start()
    {
        // Wizard.mana 
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerObject = GameObject.Find("Wizard");

        manaText = transform.GetChild(0).GetComponent<TMP_Text>();
        healthText = transform.GetChild(1).GetComponent<TMP_Text>();
        ScoreText = transform.GetChild(3).GetComponent<TMP_Text>();
        wizardObject = playerObject.GetComponent<Wizard>();
    }
}
