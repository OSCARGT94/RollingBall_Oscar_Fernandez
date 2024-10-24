using System.Collections;
using System.Collections.Generic;
using TMPro;
using TreeEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class BolaPruebas : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad, velocidadSalto;
    int puntuacion, vida, vidaInicial = 10;
    Vector3 posInicial;
    [SerializeField] TMP_Text score;
    //[SerializeField] Vector3 moverseW1, moverseS2, moverseA3, moverseD4;
    //float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posInicial = transform.position;
        puntuacion = 0;
        vida = vidaInicial;
        score.SetText("Score: " + puntuacion);
    }

    // Update is called once per frame
    void Update()
    {

        movimiento();
        if (Input.GetKey(KeyCode.Space))
        {
            if (detectarSuelo())
            {
                rb.AddForce(new Vector3(0, 1, 0) * velocidadSalto, ForceMode.Impulse);
            }

        }

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
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Vertical"), y = 0, z = -Input.GetAxisRaw("Horizontal");

        rb.AddForce(new Vector3(x, y, z).normalized * velocidad, ForceMode.Force);

    }
    //private void OnCollisionEnter(Collision collision )
    //{
    //    if (collision.gameObject.tag.Equals("Recogible"))
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Recogible"))
        {
            actualizarHUD();
            Destroy(other.gameObject);
            puntuacion += 10;
            Debug.Log("Tu puntuacion ahora es " + puntuacion);
            vida += 3;
            Debug.Log("Tu vida se suma en 3, tu vida es " + vida);
        }
        if (other.CompareTag("Muerte"))
        {

            transform.position = posInicial;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("objetoda�o"))
        {

            vida -= 1;
            Debug.Log("Golpear el vidon te hace da�o, tu vida es " + vida);
        }

    }
    void actualizarHUD()
    {
        //score.text = "Score: " + puntuacion;
        score.SetText("Score: " + puntuacion);
    }
    private bool detectarSuelo()
    {
        bool suelo = Physics.Raycast(transform.position, new Vector3(0, -1, 0), 0.6f);
        Debug.DrawRay(transform.position, new Vector3(0,-1,0),Color.red, 2f);
        return suelo;

        
    }

}
