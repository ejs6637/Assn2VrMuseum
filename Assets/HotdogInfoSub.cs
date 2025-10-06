using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHotspotHotdog : MonoBehaviour
{
    public GameObject HotdogInfoSub;  // Reference to the text box for the exhibit
    public string targetTag = "Player"; // Camera Rig or player tag

    void Start()
    {
        // Make sure the Hotdog Info Sub is hidden at the start
        if (HotdogInfoSub != null)
        {
            HotdogInfoSub.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger zone is the player
        if (other.CompareTag(targetTag))  // Ensure Camera Rig has tag "Player"
        {
            Debug.Log("Camera Rig entered the Teleport Hotspot! Showing Hotdog Info Sub.");
            HotdogInfoSub.SetActive(true);  // Show the Hotdog Info Sub text box
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collider that exited is the player
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Camera Rig left the Teleport Hotspot. Hiding Hotdog Info Sub.");
            HotdogInfoSub.SetActive(false);  // Hide the Hotdog Info Sub text box
        }
    }
}