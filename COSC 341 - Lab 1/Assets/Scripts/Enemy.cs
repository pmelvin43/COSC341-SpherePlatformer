using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private Rigidbody rigidbodyComponent;

    // Start is called before the first frame update
    void Start() {
        this.rigidbodyComponent = GetComponent<Rigidbody>();

        this.rigidbodyComponent.useGravity = false;
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void FixedUpdate() {
        if (rigidbodyComponent.position.y <= 1.25f) {
            rigidbodyComponent.velocity = new Vector3(rigidbodyComponent.velocity.x, 5f, rigidbodyComponent.velocity.z);
        }

        if (rigidbodyComponent.position.y >= 5f) {
            rigidbodyComponent.velocity = new Vector3(rigidbodyComponent.velocity.x, -5f, rigidbodyComponent.velocity.z);
        }
    }
}
