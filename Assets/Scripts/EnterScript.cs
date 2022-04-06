using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterScript : MonoBehaviour
{
    [SerializeField] private Canvas winMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            winMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
