using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siguejugador : MonoBehaviour
{
    private Vector3 Desplazamiento = new Vector3(0.15f, 4.21f, -08.05f);
    public GameObject Jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Jugador.transform.position + Desplazamiento;
    }
}
