using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed = 80;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontaleInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontaleInput * rotationSpeed * Time.deltaTime);
    }
}
