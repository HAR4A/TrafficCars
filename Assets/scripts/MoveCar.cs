using UnityEngine;

[RequireComponent (typeof (Rigidbody))]

public class MoveCar : MonoBehaviour
{
    
    private Rigidbody rb;

    public float speed = 9f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position - transform.forward * speed * Time.fixedDeltaTime);
    }
}
