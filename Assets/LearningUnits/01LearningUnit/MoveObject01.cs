using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject01 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        // My position equals my position PLUS 
	    // where I want to be by the end of this frame...
        transform.position = transform.position + moveDirection;

        // Changed Vector3.zero to moveDirection
        // Adding Vector3.zero doesn't change the direction, but moveDirection would set the position to the current position + the moveDirection value
    }
}
