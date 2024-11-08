using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuntosFinales : MonoBehaviour
{
    [SerializeField] TMP_Text score, Lavida, tiempo;
    int puntoFinal, vidaFinales;
    string tiempoFinal;
    // Start is called before the first frame update
    void Start()
    {
        tiempoFinal = BolaPruebas.Tempo;
        puntoFinal = BolaPruebas.puntuacion; 
        vidaFinales = BolaPruebas.vida;

        score.SetText("Puntuacion: " + puntoFinal);
        Lavida.SetText("Vidas: " + vidaFinales);
        tiempo.SetText(tiempoFinal);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
