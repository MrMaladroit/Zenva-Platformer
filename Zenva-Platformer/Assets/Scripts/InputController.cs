using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField]
    private float walkSpeed = 5;
    [SerializeField]
    private float jumpSpeed;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        WalkHandler();

        if (Input.GetButtonDown("Jump"))
        {
            JumpHandler();
        }
    }

    private void JumpHandler()
    {

    }

    private void WalkHandler()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis * walkSpeed * Time.deltaTime, 0, vAxis * walkSpeed * Time.deltaTime);

        Vector3 newPos = transform.position += movement;

        rb.MovePosition(newPos);
    }
}