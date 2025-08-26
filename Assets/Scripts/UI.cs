using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public static int score = 0;
    public TMP_Text manaText;
    public TMP_Text healthText;
    public TMP_Text scoreText;
    public GameObject playerObject;
    private Wizard wizardObject;

    void Update()
    {
        wizardObject = playerObject.GetComponent<Wizard>();
        manaText.text = "Mana: " + (int)wizardObject.mana;
        healthText.text = "Health: " + (int)wizardObject.health;
        scoreText.text = "Score: " + score;
    }

    //
    // Zusätzlicher Code für Veranschaulichung
    //

    private GameObject player;

    void Start()
    {
        // Potentielle möglichkeiten zur Referenz
        player = GameObject.FindGameObjectWithTag("Player");
        player = GameObject.Find("Wizard");

        // Wenn eine Child Parent Beziehung besteht
        manaText = transform.GetChild(0).GetComponent<TMP_Text>();
        healthText = transform.GetChild(1).GetComponent<TMP_Text>();
        scoreText = transform.GetChild(2).GetComponent<TMP_Text>();

        // Wenn statische Variable Wizard.mana
    }

}