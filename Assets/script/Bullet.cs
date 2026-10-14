using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; 
    private Rigidbody bulletRigidbody; 
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.linearVelocity = transform.forward * speed;
        Destroy(gameObject, 3f); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.Die();
            }
        }
    }
}
