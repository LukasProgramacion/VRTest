using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Macetas : MonoBehaviour

    
{

    [SerializeField]public bool prueba = false;
    public bool plantaEnMaceta = false;

    [SerializeField]GameObject planta;

    public bool Prueba { get => prueba; set => prueba = value; }

    // Start is called before the first frame update
    void Start()
    {
        planta.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("Planta1"))
        {
            Destroy(other.gameObject);
            planta.SetActive(true);

            plantaEnMaceta = true;

        }


    }
}
