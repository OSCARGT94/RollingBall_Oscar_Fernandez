using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BolaPruebas : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad;
    float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
    }
    void movimiento()
    {
        if (Input.GetKey(KeyCode.W))
        {
            x++;
        }
        rb.velocity = new Vector3(x,y,z) * velocidad;
    }
}
