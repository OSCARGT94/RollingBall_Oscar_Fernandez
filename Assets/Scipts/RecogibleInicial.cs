using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogibleInicial : MonoBehaviour
{
    [SerializeField] Vector3 movimiento, movimiento2;
    [SerializeField] float velocidad, velocidad2;
    [SerializeField] float timer, restTimer;
    [SerializeField] AudioClip sonidocoin;
    [SerializeField] AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotacion();
        oscilar();
    }
    void rotacion()
    {
        transform.Rotate (movimiento * velocidad * Time.deltaTime, Space.World);

    }
    void oscilar()
    {
        if (timer <= -restTimer)
        {
            timer = restTimer;
        }

        timer -= Time.deltaTime;

        if (timer > 0)
        {
            transform.Translate(movimiento2.normalized * velocidad2 * Time.deltaTime, Space.World);

        }
        else if (timer <= 0)
        {
            transform.Translate(movimiento2.normalized * -velocidad2 * Time.deltaTime, Space.World);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioManager.ReproducirSonido(sonidocoin);
        }
    }
    //private void //OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
