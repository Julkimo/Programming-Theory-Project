using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float rotationSpeed;

    // Update is called once per frame
    void LateUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("CamHorizontal");

        player.transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
