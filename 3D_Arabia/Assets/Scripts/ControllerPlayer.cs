using StarterAssets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ControllerPlayer : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] Animator anim;

    [SerializeField] bool item1;

    [SerializeField] bool item2;

    [SerializeField] bool item3;

    [SerializeField] bool item4;

    [SerializeField] bool item5;

    [SerializeField] int prueba=3;

  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
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

        }
        
    }


}
