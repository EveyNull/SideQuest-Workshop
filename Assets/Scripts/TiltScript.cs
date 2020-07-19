using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltScript : MonoBehaviour
{
    public float rotationMultiplier = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Quaternion newRot = Quaternion.Euler(new Vector3(horizontal, 0f, vertical) * rotationMultiplier);

        transform.rotation = newRot;
    }
}
