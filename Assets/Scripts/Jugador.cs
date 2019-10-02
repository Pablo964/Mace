using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody body;
    [SerializeField]float velocidadAvance = 200f;
    [SerializeField] float velocidadRotac = 10f;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float avance = Input.GetAxis("Vertical")
            * velocidadAvance * Time.deltaTime;
        float rotacion = Input.GetAxis("Horizontal")
        * velocidadRotac * Time.deltaTime;
        transform.RotateAround(Vector3.up, rotacion);
        transform.position += transform.forward
            * Time.deltaTime * avance;
    }
}
