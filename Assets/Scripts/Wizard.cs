using UnityEngine;

public class Wizard : MonoBehaviour
{
    public GameObject FireballPrefab;
    public float moveSpeed = 2f;
    public WizardStats wizardStats;
    
    

    private Vector3 lastDirection = Vector3.right; // Start: nach rechts
    internal string score;

    void Update()
    {
       // if(Wizard != null)
        Movement();
        Casting();
    }

    private void Movement()
    {
        Vector3 velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            velocity.y += 1;
        if (Input.GetKey(KeyCode.S))
            velocity.y -= 1;
        if (Input.GetKey(KeyCode.D))
            velocity.x += 1;
        if (Input.GetKey(KeyCode.A))
            velocity.x -= 1;

        if (velocity != Vector3.zero)
        {
            lastDirection = velocity.normalized; // Richtung merken
            velocity = velocity.normalized * moveSpeed;
        }

        transform.position += velocity * Time.deltaTime;
    }

    private void Casting()
    {
        if (wizardStats.mana >= wizardStats.maxMana)
        {
            wizardStats.mana = wizardStats.maxMana;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn-Position: etwas vor dem Wizard in Laufrichtung
            Vector3 spawnPos = transform.position + lastDirection * 0.9f;
            GameObject fireball = Instantiate(FireballPrefab, spawnPos, Quaternion.identity);

            Fireball_Red fbScript = fireball.GetComponent<Fireball_Red>();
            if (fbScript != null)
            {
                fbScript.direction = lastDirection;
            }
        }
    }
}

