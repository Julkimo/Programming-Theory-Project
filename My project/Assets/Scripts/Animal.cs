using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float maxSpeed;
    [SerializeField] protected float jumpForce;

    public bool isJumping = false;
    public Material animalMaterial;

    public virtual void Jump(Rigidbody playerRb)
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            playerRb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
        }
    }

    public virtual void Move(Rigidbody playerRb, Vector3 direction)
    {
        if (playerRb.velocity.magnitude <= maxSpeed && !isJumping)
            playerRb.AddRelativeForce(speed * direction, ForceMode.Force);
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
