using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObjects/WizardStats")]
public class WizardStats : ScriptableObject
{
   
    public float mana = 100; // Beispielwert für Mana
    public float health = 100; // Beispielwert für Gesundheit
    public float maxMana = 100;
    public int score = 0;
}
