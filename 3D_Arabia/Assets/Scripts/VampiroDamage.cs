using Unity.VisualScripting;
using UnityEngine;

public class VampiroDamage : MonoBehaviour
{

    [SerializeField] GameObject Vampiro;

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

        Vampiro.GetComponent<AgentControlBackend>().arder();
    }
 }

}
