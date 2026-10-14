
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Player : MonoBehaviour
{

    [SerializeField] private ParticleSystem damageEffect;
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
        ParticleSystem particle = new ParticleSystem();
        
    }

    public void Die()
    {
        gameObject.SetActive(false);
        DIeEffect();
        FindFirstObjectByType<GameManager>().OnPlayerDead();
    }

    public void DIeEffect()
    {
        ParticleSystem particle = Instantiate(damageEffect);
        particle.transform.position = gameObject.transform.position;
    }

}