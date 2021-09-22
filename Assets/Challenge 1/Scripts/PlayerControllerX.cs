using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
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
        controlHorizontal = Input.GetAxis("Horizontal");
        controlAvance =  Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * controlAvance);
        transform.Rotate(Vector3.up, Time.deltaTime * velocidadGiro * controlHorizontal);
    }
}
