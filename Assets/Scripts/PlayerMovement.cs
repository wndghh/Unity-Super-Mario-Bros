using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private float inputAxis;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        HorizontalMovement();
    }
    private void HorizontalMovement()
    {
        inputAxis = Input.GetAxis("Horizontal");
    }
}
