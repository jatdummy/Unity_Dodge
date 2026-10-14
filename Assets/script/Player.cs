
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Player : MonoBehaviour
{
    private Rigidbody playerRigidbody; 
    public float speed = 8f;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        playerRigidbody.linearVelocity = new Vector3(xSpeed, 0, zSpeed);
    }

    public void Die()
    {
        gameObject.SetActive(false);
        FindFirstObjectByType<GameManager>().OnPlayerDead();
    }
}