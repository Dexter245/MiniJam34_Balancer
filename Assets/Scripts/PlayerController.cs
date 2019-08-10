using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float torque = 50f;

    public HingeJoint arm;
    private Rigidbody rb;
    private Rigidbody armRb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        armRb = arm.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Left"))
        {
            Debug.Log("Left");
            armRb.AddTorque(Vector3.forward * torque * Time.deltaTime);
        }
        if (Input.GetButton("Right"))
        {
            Debug.Log("Right");
            armRb.AddTorque(Vector3.forward * -torque * Time.deltaTime);
        }
    }
}
