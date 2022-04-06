using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Canvas winMenu;
    [SerializeField] private Canvas loseMenu;

    [SerializeField] private float maxTimerValue = 30;
    private float timerValue;

    private int menuBuildIndex = 0;

    private void Start()
    {
        winMenu.gameObject.SetActive(false);
        loseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
        timerValue = maxTimerValue;
    }

    private void Update()
    {
        timerValue -= Time.deltaTime;
        if (timerValue <= 0)
        {
            timerValue = maxTimerValue;
            Time.timeScale = 0;
            ActivateLoseMenu();
        }

    }

    public void ActivateWinMenu()
    {
        winMenu.gameObject.SetActive(true);
    }

    public void ActivateLoseMenu()
    {
        loseMenu.gameObject.SetActive(true);
        winMenu.gameObject.SetActive(false);
    }

    public void NextLevelLoad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CurrentLevelLoad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuLoad()
    {
        SceneManager.LoadScene(menuBuildIndex);
    }

}
