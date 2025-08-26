using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Wizard : MonoBehaviour
{
    public GameObject fireballPrefab;
    private SpriteRenderer sR;
    private Animator animator;
    private Vector3 lastDirection = Vector3.right;
    private float castingCooldown = 0;

    // Stats
    public WizardStats wizardStats;


    public float mana = 100;
    public float health = 100;
    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
         mana = wizardStats.maxMana;
         health = wizardStats.maxHealth;
    }

    void Update()
    {
        Movement();
        Casting();
    }

    private void Movement()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movement = movement + new Vector3(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement += Vector3.down;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right;
        }

        // Option 1
        if (Input.GetKey(KeyCode.W) ^ Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.A) ^ Input.GetKey(KeyCode.D))
            {
                movement *= 0.7f;
            }
        }

        // Option 2 easy Solution
        movement.Normalize();

        // Option 3 bei Pseudo Controller
        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }

        // Set the Animatior Values
        if (movement.magnitude > 0)
        {
            lastDirection = movement;
            animator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
        }

        // Flip the Player
        if (movement.x > 0)
        {
            sR.flipX = false;
        }
        if (movement.x < 0)
        {
            sR.flipX = true;
        }

        // Actually move the Player
        transform.position += movement * Time.deltaTime * wizardStats.movementSpeed;
    }

    private void Casting()
    {
        if (mana >= wizardStats.maxMana)
        {
            mana = wizardStats.maxMana;
        }
        else
        {
            mana += Time.deltaTime * 5;
        }
        animator.SetBool("attacking", false);
        castingCooldown -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && castingCooldown <= 0 && mana >= 20)
        {
            mana -= 20;
            animator.SetBool("attacking", true);
            castingCooldown = 1;
        }
    }

    public void CreateFireball()
    {
        float x = 1;
        if (sR.flipX)
        {
            x = -1;
        }
        Vector3 position = transform.position + new Vector3(x, 0.8f, 0);
        GameObject obj = Instantiate(fireballPrefab, position, Quaternion.identity);
        obj.GetComponent<Fireball>().direction = lastDirection;
    }
}