using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHotspot : MonoBehaviour
{
    public GameObject DonutInfoSub;  // Reference to the text box for the exhibit
    public string targetTag = "Player"; // Camera Rig or player tag

    void Start()
    {
        // Make sure the Donut Info Sub is hidden at the start
        if (DonutInfoSub != null)
        {
            DonutInfoSub.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger zone is the player
        if (other.CompareTag(targetTag))  // Ensure Camera Rig has tag "Player"
        {
            Debug.Log("Camera Rig entered the Teleport Hotspot! Showing Donut Info Sub.");
            DonutInfoSub.SetActive(true);  // Show the Donut Info Sub text box
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collider that exited is the player
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Camera Rig left the Teleport Hotspot. Hiding Donut Info Sub.");
            DonutInfoSub.SetActive(false);  // Hide the Donut Info Sub text box
        }
    }
}