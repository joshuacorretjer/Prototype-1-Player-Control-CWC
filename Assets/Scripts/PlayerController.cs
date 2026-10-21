using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] float speed = 15.5f;
    [SerializeField] float horsePower = 1000f;
    //When you want to change the value but you don't want it to be shared with other classes, use serialization
    [SerializeField] float turnSpeed = 45f;
    [SerializeField] float horizontalInput;
    [SerializeField] float verticalInput;
    [SerializeField] Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] float speed;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI gearText;
    [SerializeField] int gearInterval;
    [SerializeField] int gear;

    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (IsOnGround())
        {
            //FixedUpdate - use it when it involves physics
            //LateUpdate - when the object is following something because it wants to know the position first and then update the frame

            //Move vehicle forward

            //This is where we get player input
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            //This is to make the vehicle move
            //Instead of using translate, use add force to make it look better, more realistic
            //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);//transform.Translate(Vector3.forward) = transform.Translate(0, 0, 1);

            playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
            speed = playerRb.velocity.magnitude;
            int mph = (int)(speed * 2.237f);
            speedometerText.text = "Speed: " + mph + " mph";
            if (mph % gearInterval == 0)
            {
                gear = mph / gearInterval;
                gearText.text = "Gear: " + gear;
                //You can also use gearText.SetText("Gear: " + gear);
            }

            //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
            if (verticalInput != 0)
            {
                transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
            }
        }
    }

    private bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if (wheelsOnGround >= 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
