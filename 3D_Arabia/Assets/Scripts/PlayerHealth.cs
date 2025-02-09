using StarterAssets;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
     [SerializeField] Slider barravida;

    [SerializeField] float vida = 100;

    [SerializeField] float dps = 10;

    [SerializeField] Animator anim;

    [SerializeField] GameObject Personaje;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
          barravida.value = vida;
    }

    // Update is called once per frame
    void Update()
    {
       barravida.value = vida;

       if(vida <= 0){

        Invoke("Muerte",0);
       }
    }

     void OnTriggerEnter(Collider other){


        if(other.gameObject.tag =="Cabeza"){

            Debug.Log("Recibido");
            vida = vida - dps;
            barravida.value = vida;

        }
    } 

    void Muerte(){

        Invoke("stop",2);
        anim.SetTrigger("Murision");
        Personaje.GetComponent<ThirdPersonController>().MoveSpeed =0;
        
    }

    void stop(){

        SceneManager.LoadScene("Creditos");
    }
}
