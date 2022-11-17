
using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public Rigidbody SHAR;

    public float speed = 30f;
    public float jumpf = 30f;

    private bool _isGrounded;




    void Update()
    {
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");
    
    SHAR.AddForce(new Vector3(-verticalInput,0,horizontalInput)*speed*Time.deltaTime);


    if (Input.GetAxis("Jump") > 0)
    {
    if (_isGrounded)
    {    
    SHAR.AddForce(Vector3.up * jumpf*Time.deltaTime, ForceMode.Impulse);
    }
    }
    }
    void FixedUpdate()
    {

    }

    private void OnCollisionExit(Collision collision)
    {
        IsGroundedUpate(collision, false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }


    private void IsGroundedUpate(Collision collision, bool value)
    {
        
        if (collision.gameObject.tag == ("Ground"))
        {
            _isGrounded = value;
        }
    }
    
}
