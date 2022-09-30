using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWashingMachine : MonoBehaviour
{

    [SerializeField] float torque;
    //[SerializeField] Vector3 rotateDirection;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddTorque(transform.up * torque, ForceMode.Force);
        //transform.Rotate(rotateDirection, Space.World);
    }
}
