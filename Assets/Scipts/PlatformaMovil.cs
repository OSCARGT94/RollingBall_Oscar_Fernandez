using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformaMovil : MonoBehaviour
{
    [SerializeField] Vector3 movimiento;
    [SerializeField] float velocidad;
    bool sentidoGiro = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sentidoGiro)
        {
            transform.Translate(movimiento.normalized * velocidad * Time.deltaTime);
            if (transform.position.z <= -15)
            {
                sentidoGiro = false;
            }
        }
        else if (!sentidoGiro)
        {
            transform.Translate(movimiento.normalized * -velocidad * Time.deltaTime);
            if (transform.position.z >= 15)
            {
                sentidoGiro=true;
            }
        }
    }
}
