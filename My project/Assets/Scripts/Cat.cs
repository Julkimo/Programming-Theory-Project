using UnityEngine;

public class Cat : Animal
{
    private bool canDoubleJump = false;

    //Cat can double jump
    public override void Jump(Rigidbody playerRb)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (!isJumping)
            {
                isJumping = true;
                canDoubleJump = true;
                playerRb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
            }
            else if (canDoubleJump)
            {
                canDoubleJump = false;
                playerRb.AddForce(jumpForce * 0.8f * Vector3.up, ForceMode.Impulse);
            }
        }
    }
}
