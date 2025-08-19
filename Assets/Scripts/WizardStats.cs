using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObjects/WizardStats")]
public class WizardStats : ScriptableObject
{
   
    public float mana = 100; // Beispielwert f�r Mana
    public float health = 100; // Beispielwert f�r Gesundheit
    public float maxMana = 100;
    public int score = 0;
}
