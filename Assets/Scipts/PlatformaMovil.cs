using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformaMovil : MonoBehaviour
{
    [SerializeField] Vector3 movimiento;
    [SerializeField] float velocidad;
    [SerializeField] float timer, restTimer;
    bool sentidoGiro = true;

    float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        movimientoHorizontal();

    }
    void movimientoHorizontal()
    {
        if (timer <= -restTimer)
        {
            timer = restTimer;
        }

        timer -= Time.deltaTime;
        if (timer > 0)
        {
            transform.Translate(movimiento.normalized * velocidad * Time.deltaTime);
            
        }
        else if (timer <= 0)
        {
            transform.Translate(movimiento.normalized * -velocidad * Time.deltaTime);

        }

        





        //if (sentidoGiro)
        //{
        //    transform.Translate(movimiento.normalized * velocidad * Time.deltaTime);
        //    if (transform.position.z <= -15)
        //    {
        //        sentidoGiro = false;
        //    }
        //}
        //else if (!sentidoGiro)
        //{
        //    transform.Translate(movimiento.normalized * -velocidad * Time.deltaTime);
        //    if (transform.position.z >= 15)
        //    {
        //        sentidoGiro=true;
        //    }
        //}

    }
}
