using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class controller : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float inputHorizontal, inputVertical;
   

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame     

    void Update()

    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()

    {

        _rigidbody.AddForce(inputHorizontal, 0, inputVertical, ForceMode.VelocityChange);

    }

}
