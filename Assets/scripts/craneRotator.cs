using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class craneRotator : MonoBehaviour
{
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxisRaw("Rotate");

    }
}
