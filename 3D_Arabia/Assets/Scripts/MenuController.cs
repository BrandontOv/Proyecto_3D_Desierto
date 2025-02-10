using StarterAssets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject MenuP;
    [SerializeField] ThirdPersonController thirdPersonController;

    public void conti()
    {
        MenuP.SetActive(false);
        Time.timeScale = 1;


    }

    public void resta()
    {

        SceneManager.LoadScene("lvl1");
    }

    public void next()
    {

        SceneManager.LoadScene("lvl1");
    }

    public void main()
    {

        SceneManager.LoadScene("Menu");
    }

    public void Credits()
    {

        SceneManager.LoadScene("Creditos");
    }



}
