using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controljugador : MonoBehaviour
{
    private float velocidad = 20.0f;
    float velocidadGiro = 45;
    private float controlHorizontal;
    float controlAvance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //leer sistema de estrada
        controlHorizontal = Input.GetAxis("Horizontal");
        controlAvance =  Input.GetAxis("Vertical");
        // Mover la truck hacia adelante 
        //transform.Translate(0, 0, 0.27f);

        //Este es el contro de avance, sobre el eje de la Z
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * controlAvance);
        //transform.Translate(Vector3.right * Time.deltaTime * velocidadGiro * controlHorizontal);
        //Control de giro sobre el eje de la Y
        transform.Rotate(Vector3.up, Time.deltaTime * velocidadGiro * controlHorizontal);
    }
}
