using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObjects/WizardStats")]
public class WizardStats : ScriptableObject
{
   
    public float maxMana = 100; // Beispielwert f�r Mana 
    public float maxHealth = 100; // Beispielwert f�r Gesundheit
    public float movementSpeed = 3;
    public int score = 0;
}
