
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Wizard : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public float moveSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = Vector3.zero;

        //float f = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W))
        {
            velocity.y += 2;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.y -= 2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x += 2;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x -= 2;
        }
        if (velocity != Vector3.zero)
        {
            velocity = velocity.normalized * moveSpeed;
        }
        transform.position += velocity * Time.deltaTime;
    }
}
