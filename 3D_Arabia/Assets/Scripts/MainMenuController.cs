using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){

            SceneManager.LoadScene("Menu");
        }

        
        
    }

    public void Jugar(){

        SceneManager.LoadScene("Lvl1");
    }

    public void creditos(){

        SceneManager.LoadScene("Creditos");
    }

    public void salir(){

        Application.Quit();
    }
    
}
