using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class AgentControlBackend : MonoBehaviour
{
    NavMeshAgent agent; 
    [SerializeField] GameObject[] path; 
    int goal = 0;

    [Header("Detection")]
    [SerializeField] GameObject player;
    [SerializeField] float visionArea = 5;
    [SerializeField] float visionAtaque =2;

    [SerializeField] GameObject Vampiro;

    [SerializeField] Animator anim;

    [SerializeField] GameObject cabeza;

    [SerializeField] ParticleSystem quemado;

    [SerializeField] GameObject Aguacate;
    float distance;
    float ataque;
    bool follow = false;
    bool Siguiendo = false; 

    public int vida = 4;


    bool ardido = false; 

    bool morto = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
      
        agent.destination = path[goal].transform.position;

        quemado.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(vida >0){

        

        distance = Vector3.Distance(transform.position, 
                            player.transform.position);

        if (distance <= visionArea){
            agent.destination = player.transform.position;
            follow = true; 
            Siguiendo = true;
        } else {
            agent.destination = path[goal].transform.position;
            follow = false;
            Siguiendo = false;
            
        }

        if(distance<= visionAtaque){
             //transform.LookAt(player.transform.position);
            anim.SetBool("Cabeza", true);
            Vampiro.GetComponent<NavMeshAgent>().speed = 0.2f;
            
            
        }
        else{
            anim.SetBool("Cabeza", false);
            Vampiro.GetComponent<NavMeshAgent>().speed = 3.5f;

        }

        if (agent.remainingDistance < 1 && !follow){
            goal++;
            if (goal == path.Length){
                goal = 0; 
            }
            agent.destination = path[goal].transform.position;
        }

        if(Siguiendo == true){

            anim.SetBool("Siguiendo", true);
        }

        else{

            anim.SetBool("Siguiendo", false);
        }
    }

    if(vida <=0 && !morto)
    {
        morto = true;
        anim.SetTrigger("Muerte");
        Invoke("destru",5);
    }
}
public void damagevamp () {

vida --;
Debug.Log("recibedaño");

}
public void destru(){
    Invoke("curar",0);
    Destroy(gameObject);
    Debug.Log("se deberia destruir");
}

public void desactivar(){

    cabeza.SetActive(false);
}

public void curar(){

    Instantiate(Aguacate, transform.position, transform.rotation);
}

public void arder(){

    Invoke("curar",0);
    quemado.Play();
    Debug.Log("Se quema");
    vida =0;
    anim.SetTrigger("Muerte");
    Invoke("destru",5);
    Vampiro.GetComponent<NavMeshAgent>().speed = 0;
    
}

 void OnTriggerEnter(Collider other){

    if(other.gameObject.tag=="Fireball" && !ardido){
        ardido = true; 
        Debug.Log("Me Quemo");
        Invoke("arder",0);
    }
 }

}
