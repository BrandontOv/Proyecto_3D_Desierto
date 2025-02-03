using Unity.VisualScripting;
using UnityEngine;

public class FireControll : MonoBehaviour
{

    [SerializeField] ParticleSystem fire;
    [SerializeField] GameObject chile;

    [SerializeField] GameObject chileUI;
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
            

        }

        }

    }

    public void detener(){

        fire.Stop();
        aliento = false;
        chileUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other){

        if(other.gameObject.tag=="Chile"){

            aliento=true;
        }



    }
}
