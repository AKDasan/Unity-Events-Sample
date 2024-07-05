using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    public UnityEvent leverTrigger;

    private bool isPlayerNearby;

    [SerializeField] TextMeshProUGUI infoMessage;

    private void Awake()
    {
        isPlayerNearby = false;
        infoMessage.enabled = false;
    }

    private void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.F))
        {
            leverTrigger.Invoke();
        }
    }

    // !!! Player'a player tag'i vermeyi unutma!!!!

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerNearby = true;
            infoMessage.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerNearby = false;
            infoMessage.enabled = false;
        }       
    }
}
