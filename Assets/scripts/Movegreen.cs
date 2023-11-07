using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Movegreen : MonoBehaviour
{
    private Rigidbody rb;

    public float speed = 9f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * speed * Time.fixedDeltaTime);
    }
}
