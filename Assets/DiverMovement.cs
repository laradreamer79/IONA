using UnityEngine;

public class DiverMovement : MonoBehaviour
{
    public float speed = 3f;
    public float turnSpeed = 120f;
    public float verticalSpeed = 2f;
    public bool canMove = true; // أضف هذا

    void Update()
    {
        if (!canMove) return; // أضف هذا

        float move = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * move * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * turn * turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
            transform.Translate(Vector3.up * verticalSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.down * verticalSpeed * Time.deltaTime);
    }
}