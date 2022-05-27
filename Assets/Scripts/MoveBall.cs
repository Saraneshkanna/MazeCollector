using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{

    private CharacterController Controller;
    public float MoveSpeed = 1.0f;
    public float JumpSpeed = 1.0f;
    public float gravity = -9.81f;
    public float yVelocity;

    private Vector3 PlayerMovementInput;
    public Vector3 Velocity;

    [SerializeField] private Transform cameraTransform;
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource collectSound;
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    private void movePlayer()
    {
        //Vector2 moveVector = transform.TransformDirection(PlayerMovementInput);
        //Controller.Move(moveVector * MoveSpeed * Time.deltaTime);
        //Controller.Move(Velocity * Time.deltaTime);
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        PlayerMovementInput = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * PlayerMovementInput;
        PlayerMovementInput.Normalize();

        //Vector3 velocity = (transform.forward * PlayerMovementInput.y + transform.right * PlayerMovementInput.x) * MoveSpeed + Vector3.up * yVelocity;
        Vector3 velocity = PlayerMovementInput * MoveSpeed + Vector3.up * yVelocity;
        Controller.Move(velocity * Time.deltaTime);

        if(Controller.isGrounded)
        {
            yVelocity = -1f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity += JumpSpeed;
                jumpSound.Play();
            }
        }
        else
        {
            yVelocity += gravity * 2f * Time.deltaTime;

        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Collectible")
        {
            collectSound.Play();
        }
    }
    /*private void OnApplicationFocus(bool focus)
    {
        if(focus)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None; 
        }
    }*/
}
