using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 7f;
    public float grav = 9.81f;
    public float jumpSpeed = 3f;
    public float dirY;


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);


        if(Input.GetButtonDown("Jump"))
        {
            dirY = jumpSpeed;
        }

        dirY -= grav * Time.deltaTime;

        direction.y = dirY;

        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}