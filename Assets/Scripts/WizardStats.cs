using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObjects/WizardStats")]
public class WizardStats : ScriptableObject
{
   
    public float maxMana = 100; // Beispielwert für Mana 
    public float maxHealth = 100; // Beispielwert für Gesundheit
    public float movementSpeed = 3;
    public int score = 0;
}
