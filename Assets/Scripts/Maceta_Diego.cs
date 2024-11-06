using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maceta_Diego : MonoBehaviour
{
    [SerializeField] private GameObject[] plantaMaceta;
    [SerializeField] private float vida;


    void Start()
    {
        for (int i = 0; i < plantaMaceta.Length; i++)
        {

            plantaMaceta[i].SetActive(false);

        }

       
    }
       
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlantaA"))
        {
            Destroy(other.gameObject);
            plantaMaceta[Random.Range(0,3)].SetActive(true);
        }
         
    }
}
