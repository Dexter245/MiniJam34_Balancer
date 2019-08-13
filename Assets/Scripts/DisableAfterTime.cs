using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAfterTime : MonoBehaviour
{
    public float time = 5f;

    private float timeAccum = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeAccum += Time.deltaTime;
        if(timeAccum >= time)
        {
            gameObject.SetActive(false);
            enabled = false;
        }
    }
}
