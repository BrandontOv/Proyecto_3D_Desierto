using Unity.VisualScripting;
using UnityEngine;

public class VampiroDamage : MonoBehaviour
{

    [SerializeField] GameObject Vampiro;
    [SerializeField] GameObject Vampiro1;
    [SerializeField] GameObject Vampiro2;
    [SerializeField] GameObject Vampiro3;
    [SerializeField] GameObject Vampiro4;
    [SerializeField] GameObject Vampiro5;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

 void OnTriggerEnter(Collider other){

    if(other.gameObject.tag=="Enemy"){

        Vampiro1.GetComponent<AgentControlBackend>().arder();
        Debug.Log("Lo intenta llamar");
    }
    if(other.gameObject.tag=="Enemy1"){

        Vampiro2.GetComponent<AgentControlBackend>().arder();
        Debug.Log("Lo intenta llamar");
    }
    if(other.gameObject.tag=="Enemy2"){

        Vampiro3.GetComponent<AgentControlBackend>().arder();
        Debug.Log("Lo intenta llamar");
    }
    if(other.gameObject.tag=="Enemy3"){

        Vampiro4.GetComponent<AgentControlBackend>().arder();
        Debug.Log("Lo intenta llamar4");
    }
    if(other.gameObject.tag=="Enemy"){

        Vampiro5.GetComponent<AgentControlBackend>().arder();
        Debug.Log("Lo intenta llamar5");
    }
 }

}
