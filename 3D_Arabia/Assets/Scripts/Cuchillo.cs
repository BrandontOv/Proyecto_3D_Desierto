using Unity.VisualScripting;
using UnityEngine;

public class Cuchillo : MonoBehaviour




{
    [SerializeField] GameObject Vampi;
    [SerializeField] GameObject Coli;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Enemy")){

        other.gameObject.GetComponent<AgentControlBackend>().damagevamp();
        Debug.Log("daño hecho");

        }
    }
}
