using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGameSceneScript : MonoBehaviour
{
    [SerializeField] private Canvas mainCanvas; 

    private void Start()
    {
        mainCanvas.gameObject.SetActive(true);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }


}
