using Unity.VisualScripting;
using UnityEngine;

public class FireControll : MonoBehaviour
{

    [SerializeField] ParticleSystem fire;
    [SerializeField] GameObject chile;

    [SerializeField] GameObject chileUI;

    [SerializeField] Collider machete;

    [SerializeField] GameObject areafuego;
    public bool aliento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fire.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(aliento == true){

            chileUI.SetActive(true);

            if(Input.GetMouseButtonDown(1)){

            
            fire.Play();
            Invoke("detener",4);
            areafuego.SetActive(true);
            

        }

        }

    }

    public void detener(){

        fire.Stop();
        aliento = false;
        chileUI.SetActive(false);
        areafuego.SetActive(false);
    }

    void OnTriggerEnter(Collider other){

        if(other.gameObject.tag=="Chile" && !aliento){

            aliento=true;
        }


    }

    public void act(){

        machete.enabled =true;


    }

    public void desact(){

        machete.enabled = false;
    }
}
