using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;

    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
    

    // Start is called before the first frame update
    void Start() {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Space)) {
            jumpKeyWasPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }

    // FixedUpdate is called once every physics update 
    private void FixedUpdate() {

        rigidbodyComponent.velocity = new Vector3(horizontalInput * 2.5f, rigidbodyComponent.velocity.y, rigidbodyComponent.velocity.z);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0) {
            return;
        }

        if (jumpKeyWasPressed) {
            rigidbodyComponent.AddForce(Vector3.up * 7, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }

    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == 8) {
            Destroy(other.gameObject);
            PointsDisplay.addPoint();
        }

        if (other.gameObject.layer == 9) {
            PointsDisplay.minusPoint();
        }
    }

}
