using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float gravityMultiplier = 5f;
    private Animal animal;
    private Material material;

    private void Start()
    {
        animal = GetComponent<Animal>();
        material = GetComponent<Renderer>().material;
        material.color = animal.animalMaterial.color;
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMultiplier;
    }

    private void Update()
    {
        HandleInput();
        HandleFormChange();
    }

    private void HandleInput()
    {
        //Input
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 movingDirection = (Vector3.forward * verticalInput + Vector3.right * horizontalInput).normalized;

        //Jumping
        animal.Jump(playerRb);

        //Movement
        animal.Move(playerRb, movingDirection);
    }

    private void HandleFormChange()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangeForm(1);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangeForm(2);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            ChangeForm(3);
        if (Input.GetKeyDown(KeyCode.Alpha4))
            ChangeForm(4);
    }

    /// <summary>
    /// Changes the color and the Animal class to match current choice of animal.
    /// For the animalNumber: 1 = Dog,  2 = Cat, 3 = Mouse, 4 = Base form
    /// </summary>

    private void ChangeForm(int animalNumber)
    {
        switch (animalNumber)
        {
            case 1: animal = GetComponent<Dog>(); break;
            case 2: animal = GetComponent<Cat>(); break;
            case 3: animal = GetComponent<Mouse>(); break;
            case 4: animal = GetComponent<Animal>(); break;
        }

        material = GetComponent<Renderer>().material;
        material.color = animal.animalMaterial.color;
    }

}
