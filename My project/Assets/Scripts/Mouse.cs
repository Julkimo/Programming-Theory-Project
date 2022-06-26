using UnityEngine;

//INHERITANCE
public class Mouse : Animal
{
    //Mouse can dash and move around mid air
    // POLYMORPHISM
    public override void Move(Rigidbody playerRb, Vector3 direction)
    {
        if (playerRb.velocity.magnitude <= maxSpeed)
            playerRb.AddRelativeForce(speed * direction, ForceMode.Force);

        if ( Input.GetKeyDown(KeyCode.LeftShift) )
        {
            playerRb.AddRelativeForce(3 * speed * direction, ForceMode.Impulse);
        }
    }
}
