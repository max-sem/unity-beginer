using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    public float jumpVelocity = 10f;

    public float distanceToGround = 0.1f;
    public LayerMask GroundLayer;

    private float vInput;
    private float hInput;
    private Rigidbody _rb;

    private CapsuleCollider _col;

  
    private void Start()
    {
        _rb  = this.GetComponent<Rigidbody>();
        _col = this.GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        //this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);

        hInput = Input.GetAxis("Horizontal") * rotateSpeed;
        //this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);

        if (IsGrounded() && (Input.GetKeyDown(KeyCode.Q)))
        {            
            _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
        }
                

    }
    private void FixedUpdate()
    {        
        Vector3 rotation = Vector3.up * hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        _rb.MovePosition(this.transform.position  + this.transform.forward * vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);        
    }

    private bool IsGrounded() 
    {
        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z );
        bool grounded = Physics.CheckCapsule(_col.bounds.center, capsuleBottom, distanceToGround, GroundLayer, QueryTriggerInteraction.Ignore);
        return grounded;
    }

}