using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Movegreen))]

public class GreenNorthRight : MonoBehaviour
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
      
        float carRotation = Mathf.Floor(transform.eulerAngles.y);

        if (transform.localPosition.z < 17.05f && carRotation != 270f)
        {

            if (carRotation >= 269f && carRotation <= 284f)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0, 270f, 0));
                return;
            }


            eulerAngleVelocity = GetComponent<Movegreen>().speed * 8.57f;
            Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, eulerAngleVelocity, 0) * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }
}
