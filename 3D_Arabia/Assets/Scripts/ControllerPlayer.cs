using StarterAssets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllerPlayer : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] Animator anim;

    [SerializeField] GameObject item1T;
    [SerializeField] GameObject item2T;
    [SerializeField] GameObject item3T;
    [SerializeField] GameObject item4T;
    [SerializeField] GameObject item5T;
    [SerializeField] GameObject pausa;

    [SerializeField] ThirdPersonController thirdPersonController;
    

    [SerializeField] bool item1;

    [SerializeField] bool item2;

    [SerializeField] bool item3;

    [SerializeField] bool item4;

    [SerializeField] bool item5;

    [SerializeField] int prueba=3;

  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
       thirdPersonController = GetComponent<ThirdPersonController>();
       Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(prueba==5){

            item1 = true;
            item2 = true;
            item3 = true;
            item4 = true;
            item5 = true;
        }

        if(item1&& item2&& item3&&item4&&item5){

            anim.SetBool("Win",true);

            Player.GetOrAddComponent<ThirdPersonController>().MoveSpeed =0;

            Invoke("Credit",3);

        }

        if(Input.GetKeyDown(KeyCode.Escape)){

            pausa.SetActive(true);
            Time.timeScale = 0;
            thirdPersonController.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    
        
    }

    void OnTriggerEnter(Collider other){


        if(other.gameObject.tag =="Lechu"){

            Debug.Log("item1 listo");
            Destroy(item1T);
            item1 = true;

        }

        if(other.gameObject.tag =="Car"){

            Debug.Log("item2 listo");
           Destroy(item2T);
            item2 = true;
        }

        if(other.gameObject.tag =="Tortilla"){

            Debug.Log("item3 listo");
           Destroy(item3T);
            item3 = true;

        }

        if(other.gameObject.tag =="Salsa"){

            Debug.Log("item4 listo");
           Destroy(item4T);
            item4 = true;
        }

        if(other.gameObject.tag =="Tomate"){

            Debug.Log("item5 listo");
           Destroy(item5T);
           item5 = true;

        }
    } 

    void Credit(){

        SceneManager.LoadScene("Creditos");
        Debug.Log("Se cargaron los creditos");
    }
}
