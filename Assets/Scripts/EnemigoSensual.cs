using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class EnemigoSensual : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;        // Referencia al objeto que el enemigo debe seguir (ej. el jugador)
    public float speed = 5f;        // Velocidad del enemigo al moverse hacia el objetivo
    [SerializeField] GameObject prueba;
    [SerializeField] bool funciona;
    
    void Update()
    {
        // Comprueba que el objetivo existe
        if (prueba != null)
        {
            funciona = true;
            // Calcula la dirección hacia el objetivo
            Vector3 direction = target.position - transform.position;
            direction.Normalize();  // Normaliza la dirección para que tenga una magnitud de 1

            // Mueve el enemigo hacia el objetivo
            transform.position += direction * speed * Time.deltaTime;

            // Opcional: rota el enemigo para que mire hacia el objetivo
            transform.LookAt(target);
        }
        else
        {
            funciona=false;
        }
    }
}
