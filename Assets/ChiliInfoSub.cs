using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHotspotChili : MonoBehaviour
{
    public GameObject ChiliInfoSub;  // Reference to the text box for the exhibit
    public string targetTag = "Player"; // Camera Rig or player tag

    void Start()
    {
        // Make sure the Chili Info Sub is hidden at the start
        if (ChiliInfoSub != null)
        {
            ChiliInfoSub.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger zone is the player
        if (other.CompareTag(targetTag))  // Ensure Camera Rig has tag "Player"
        {
            Debug.Log("Camera Rig entered the Teleport Hotspot! Showing Chili Info Sub.");
            ChiliInfoSub.SetActive(true);  // Show the Chili Info Sub text box
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collider that exited is the player
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Camera Rig left the Teleport Hotspot. Hiding Chili Info Sub.");
            ChiliInfoSub.SetActive(false);  // Hide the Chili Info Sub text box
        }
    }
}