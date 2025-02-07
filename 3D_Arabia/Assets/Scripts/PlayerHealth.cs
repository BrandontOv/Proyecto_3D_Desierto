using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
     [SerializeField] Slider barravida;

    [SerializeField] float vida = 100;

    [SerializeField] float dps = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
          barravida.value = vida;
    }

    // Update is called once per frame
    void Update()
    {
       barravida.value = vida;
    }

     void OnTriggerEnter(Collider other){


        if(other.gameObject.tag =="Cabeza"){

            Debug.Log("Recibido");
            vida = vida - dps;
            barravida.value = vida;

        }
    } 
}
