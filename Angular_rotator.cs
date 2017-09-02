using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angular_rotator : MonoBehaviour {
    public Rigidbody rb;
    public float tumble;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
