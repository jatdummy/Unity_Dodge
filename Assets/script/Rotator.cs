using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 60f;

    void Start()
    {
        
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }
}
