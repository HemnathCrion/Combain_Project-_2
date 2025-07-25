using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Cantroller : MonoBehaviour
{
    public float playerSpeed;
    public GameObject player;
    public Camera camera;
    public CharacterController cc;
    public bool isMoving;
    public float sensitivity;
    public float xRotation;
    public float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

            xRotation -= mouseY;
            yRotation += mouseX;

            xRotation = Mathf.Clamp(xRotation, -60f, 60f);

            // Apply rotation to the camera (vertical) and player (horizontal)
            camera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            transform.rotation = Quaternion.Euler(0f, yRotation, 0f);
        }
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        //Vector3 derection = new Vector3(hInput,0,vInput) ;

        //cc.Move(derection * playerSpeed * Time.deltaTime);

        Vector3 forward = transform.forward * vInput;
        Vector3 right = transform.right * hInput;
        cc.SimpleMove(Vector3.Normalize(forward + right) * playerSpeed);



        isMoving = cc.velocity.sqrMagnitude > 0.0f ? true : false;
    }
}
