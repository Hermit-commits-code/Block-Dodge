using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update

    // I marked this as FixedUpdate because I'm testing the physics.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 200 * Time.deltaTime);
    }
}
