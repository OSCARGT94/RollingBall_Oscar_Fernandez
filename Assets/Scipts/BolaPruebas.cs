using System.Collections;
using System.Collections.Generic;
using TMPro;
using TreeEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BolaPruebas : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad, velocidadSalto;
    public static int puntuacion, vida, vidaInicial = 3;
    public static string Tempo;
    Vector3 posInicial, StarOriginal;
    [SerializeField] TMP_Text score, Lavida, tiempoCorre;
    [SerializeField] GameObject marcadorPosInicial;
    bool inicio = false;
    public static float relojuego = 0;
    //[SerializeField] Vector3 moverseW1, moverseS2, moverseA3, moverseD4;
    //float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
       
        

        StarOriginal = marcadorPosInicial.transform.position;
        transform.position = StarOriginal;


        posInicial = StarOriginal;

        rb = GetComponent<Rigidbody>();

        puntuacion = 0;
        vida = vidaInicial;
        score.SetText("Score: " + puntuacion);
        Lavida.SetText("Vida: " + vida);
    }

    // Update is called once per frame
    void Update()
    {
        //Empezarinicio();
        findeljuego();
        //movimiento();
        if (Input.GetKey(KeyCode.Space))
        {
            if (detectarSuelo())
            {
                rb.AddForce(new Vector3(0, 1, 0) * velocidadSalto, ForceMode.Impulse);
            }

        }
        Tempo = temporizador(0, 0);
        
    }
    public string temporizador(int min, int sec)
    {
        relojuego += Time.deltaTime;
        int minutes = Mathf.FloorToInt(relojuego / 60);
        int seconds = Mathf.FloorToInt(relojuego % 60);
        tiempoCorre.SetText(minutes + ":" + seconds);
        string TIEMPOFINAL = minutes + ":" + seconds;
        return TIEMPOFINAL;
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
            puntuacion += 10;
            Destroy(other.gameObject);
            Debug.Log("Tu puntuacion ahora es " + puntuacion);
            if (vida <= 2)
            {
                vida += 1;
            }
            Debug.Log("Tu vida se suma en 3, tu vida es " + vida);
            actualizarHUD();
        }
        if (other.CompareTag("Muerte"))
        {
            vida -= 1;
            actualizarHUD();
            transform.position = posInicial;
        }
        if (other.CompareTag("checkopint"))
        {

            posInicial = transform.position;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("objetodaño"))
        {

            vida -= 1;
            Debug.Log("Golpear el vidon te hace daño, tu vida es " + vida);
        }

    }
    void actualizarHUD()
    {
        //score.text = "Score: " + puntuacion;
        score.SetText("Score: " + puntuacion);

        Lavida.SetText("Vida: " + vida);
    }
    private bool detectarSuelo()
    {
        bool suelo = Physics.Raycast(transform.position, new Vector3(0, -1, 0), 0.6f);
        Debug.DrawRay(transform.position, new Vector3(0,-1,0),Color.red, 2f);
        return suelo;

        
    }
    void findeljuego()
    {
        if (vida <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
    void Empezarinicio()
    {
        if (inicio == false)
        {
            inicio = true;
            transform.position = StarOriginal;
        }
    }

}
