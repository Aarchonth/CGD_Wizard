using Unity.VisualScripting;
using UnityEngine;

public class Fireball_Red : MonoBehaviour
{
    public Vector3 direction = Vector3.right; // Standard: nach rechts

    private void Start()
    {
        Destroy(gameObject, 2);
    }

    void Update()
    {
        transform.position += direction * Time.deltaTime * 5;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "Wizard")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}