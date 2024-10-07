using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BolaPruebas : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad, velocidadSalto;
    //[SerializeField] Vector3 moverseW1, moverseS2, moverseA3, moverseD4;
    //float x, y, z;
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
        //------xxxxxxxxxxxxxxxxxxxxxx------------
        //Vector3.forward...etc.

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(moverseW1.normalized * velocidad * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(moverseA3.normalized * velocidad * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(moverseS2.normalized * velocidad * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(moverseD4.normalized * velocidad * Time.deltaTime);
        //}

        //------xxxxxxxxxxxxxxxxxxxxxxxxx------------
        float  x = Input.GetAxisRaw("Vertical"), y , z = -Input.GetAxisRaw("Horizontal");

        rb.AddForce(new Vector3(x, 0,z ).normalized * velocidad, ForceMode.Force );

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 1, 0) * velocidadSalto, ForceMode.Impulse);
        }


        //------xxxxxxxxxxxxxxxxxxxxxxxxx------------

        //if (Input.GetKey(KeyCode.W))
        //{
        //    x++;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    z++;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    x--;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    z--;
        //}
        //rb.velocity = new Vector3(x,y,z) * velocidad;

        //------xxxxxxxxxxxxxxxxxxxxxxxx------------

    }
    //private void OnCollisionEnter(Collision collision )
    //{
    //    if (collision.gameObject.tag.Equals("Recogible"))
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}
   
}
