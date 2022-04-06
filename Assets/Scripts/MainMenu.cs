using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Canvas menuCanvas;
    [SerializeField] private Canvas creditsCanvas;


    private void Start()
    {
        menuCanvas.gameObject.SetActive(true);
        creditsCanvas.gameObject.SetActive(false);
    }

    public void ShowCredits()
    {
        menuCanvas.gameObject.SetActive(false);
        creditsCanvas.gameObject.SetActive(true);
    }

    public void ShowMenu()
    {
        menuCanvas.gameObject.SetActive(true);
        creditsCanvas.gameObject.SetActive(false);
    }

    public void NextLevelLoad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
