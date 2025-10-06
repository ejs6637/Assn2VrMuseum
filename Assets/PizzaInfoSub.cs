using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHotspotPizza : MonoBehaviour
{
    public GameObject PizzaInfoSub;  // Reference to the text box for the exhibit
    public string targetTag = "Player"; // Camera Rig or player tag

    void Start()
    {
        // Make sure the Pizza Info Sub is hidden at the start
        if (PizzaInfoSub != null)
        {
            PizzaInfoSub.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger zone is the player
        if (other.CompareTag(targetTag))  // Ensure Camera Rig has tag "Player"
        {
            Debug.Log("Camera Rig entered the Teleport Hotspot! Showing Pizza Info Sub.");
            PizzaInfoSub.SetActive(true);  // Show the Pizza Info Sub text box
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collider that exited is the player
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Camera Rig left the Teleport Hotspot. Hiding Pizza Info Sub.");
            PizzaInfoSub.SetActive(false);  // Hide the Pizza Info Sub text box
        }
    }
}