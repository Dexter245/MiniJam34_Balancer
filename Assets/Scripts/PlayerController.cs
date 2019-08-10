using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool active = false;
    public float torque = 50f;
    public Rigidbody nextRigidbody;

    private Rigidbody rb;
    private Material material;
    private bool activate = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        material = GetComponent<Renderer>().material;
        //change alpha if set as active in editor
        if (active)
            Activate();
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            bool left = Input.GetButton("Left");
            bool right = Input.GetButton("Right");
            if ((Input.GetButtonDown("Left") && right) || (left && Input.GetButtonDown("Right")) )
            {
                Debug.Log("switch");
                Deactivate();
                nextRigidbody.GetComponent<PlayerController>().Activate();
            }
            else if (left)
            {
                rb.AddTorque(Vector3.forward * torque * Time.deltaTime);
            }
            else if (right)
            {
                rb.AddTorque(Vector3.forward * -torque * Time.deltaTime);
            }
        }
        if (activate)
        {
            activate = false;
            active = true;
        }
    }

    void Activate()
    {
        activate = true;
        Color color = material.color;
        color.a = 1f;
        material.color = color;
    }

    void Deactivate()
    {
        active = false;
        Color color = material.color;
        color.a = 0.5f;
        material.color = color;
    }
}
