using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodiilo : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] int velocidad;
    [SerializeField] Vector3 sentidoGiro;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(sentidoGiro * velocidad, ForceMode.VelocityChange );
    }

    // Update is called once per frame
    void Update()
    {
    }
}
