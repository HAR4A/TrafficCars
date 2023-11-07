using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Movegreenminus))]

public class EastGreenRight : MonoBehaviour
{
    private Rigidbody rb;
    private float eulerAngleVelocity;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        leftTurn();
    }

    void leftTurn()
    {
        //-179.471
        float carRotation = Mathf.Floor(transform.eulerAngles.y);

        if (transform.localPosition.x < 4.96f && carRotation != 0f)
        {

            if (carRotation >= -1f && carRotation <= 9f)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0, 0f, 0));
                return;
            }


            eulerAngleVelocity = GetComponent<Movegreenminus>().speed * 8.57f;
            Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, eulerAngleVelocity, 0) * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }
}
