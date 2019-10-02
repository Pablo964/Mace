using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] Transform[] puntosDeCamino;
    Vector3 siguientePosicion;
    [SerializeField] float velocidad = 2f;
    float distanciaCambio = 0.2f;
    byte numeroSiguientePosicion;
    void Start()
    {
        siguientePosicion = puntosDeCamino[0].position;
        numeroSiguientePosicion = 0;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            siguientePosicion,
            velocidad * Time.deltaTime);
        if (Vector3.Distance(transform.position,
             siguientePosicion) < distanciaCambio)
        {
            numeroSiguientePosicion++;
            if (numeroSiguientePosicion >= puntosDeCamino.Length)
                numeroSiguientePosicion = 0;
            siguientePosicion = puntosDeCamino[numeroSiguientePosicion].
            position;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("PerderVida");
    }
}


    


