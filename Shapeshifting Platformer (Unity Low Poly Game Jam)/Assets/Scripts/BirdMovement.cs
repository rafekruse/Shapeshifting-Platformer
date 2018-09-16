using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour {
        
    Rigidbody rb;
    private float speed;
    public float turnRate;
    public float liftRate;
    public float acceleration;
    public float Maxspeed;
    public float horizontalDecay;
    public float verticalDecay;
    private float turningValue = 0;
    private float liftingValue = 0;
    private Animation flap;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        speed = rb.velocity.magnitude;
        flap = this.GetComponent<Animation>();
    }
    void OnEnable()
    {
        
        liftingValue = transform.rotation.eulerAngles.x;
        turningValue = transform.rotation.eulerAngles.y;
    }

    //drift back towards center
    void Update()
    {
        //WANT TO ADD BANKING that doesnt interfere with camera
        float placeholderTurn = turnRate * Input.GetAxis("Horizontal") * (speed / Maxspeed);
        float placeholderLift = liftRate * Input.GetAxis("Vertical") * (speed / Maxspeed);

        turningValue += placeholderTurn;
        liftingValue += placeholderLift;

        transform.localRotation = Quaternion.Euler(liftingValue, turningValue, 0);

        if (liftingValue > 0)
        {
            liftingValue -= verticalDecay;
        }
        if (liftingValue < 0)
        {
            liftingValue += verticalDecay;
        }
        if (GetComponent<Rigidbody>().velocity.magnitude > 0)
        {
            flap.Play();
        }

        flap["Flap"].speed = GetComponent<Rigidbody>().velocity.magnitude / Maxspeed;


        if (Input.GetKey(KeyCode.Space))
        {
            speed += acceleration;
        }

        rb.velocity = transform.forward * speed;

        if (Maxspeed <= rb.velocity.magnitude)
        {
            speed = Maxspeed;
            rb.velocity = rb.velocity.normalized * Maxspeed;
        }
    }















    /* Rigidbody rb;
    public float zrotForce = 1;
    public int MaxRot = 90;
    public int MinRot = -90;
    public float rotupForce = 1;
    float speed;
    public float speedForLift;
    public float speedincrease;
    public int Maxspeed;
    public float lift;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        InvokeRepeating("Speed", .1f, .1f);
    }

    void Speed()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Mathf.Repeat(1, Time.time);
            speed += speedincrease;
        }
    }


    void Update()
    {
        float spd = rb.velocity.magnitude;
        rb.AddRelativeForce(0, 0, speed);

        float Horizontal = (Input.GetAxis("Horizontal")) * zrotForce;
        rb.AddRelativeTorque(0, 0, -Horizontal * (spd / 100));
        

        float Vertical = (Input.GetAxis("Vertical")) * rotupForce;
        rb.AddRelativeTorque(-Vertical * (spd / 100), 0, 0);
        #region Speed Min/Max
        if (Maxspeed <= speed)
        {
            speed = Maxspeed;
            rb.velocity = rb.velocity.normalized * Maxspeed;
        }

        #endregion
        if (speed > speedForLift)
        {
            rb.AddForce(0, lift, 0);
        }
        rb.maxAngularVelocity = 1;*/
     




}



