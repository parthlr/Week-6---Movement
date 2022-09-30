using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBallerina : MonoBehaviour
{

    [SerializeField] GameObject agitator;
    [SerializeField] Vector3 rotationDirection;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = agitator.transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = agitator.transform.rotation;
    }
}
