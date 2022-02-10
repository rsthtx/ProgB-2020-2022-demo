using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Rigidbody component = GetComponent<Rigidbody>();
        Vector3 moveForce = new Vector3(horizontal, 0, vertical);
        Debug.Log(moveForce);
        component.AddForce(moveForce);
    }
}
