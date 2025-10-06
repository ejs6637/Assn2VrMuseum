using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHotspotSushi : MonoBehaviour
{
    public GameObject SushiInfoSub;  // Reference to the text box for the exhibit
    public string targetTag = "Player"; // Camera Rig or player tag

    void Start()
    {
        // Make sure the Sushi Info Sub is hidden at the start
        if (SushiInfoSub != null)
        {
            SushiInfoSub.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger zone is the player
        if (other.CompareTag(targetTag))  // Ensure Camera Rig has tag "Player"
        {
            Debug.Log("Camera Rig entered the Teleport Hotspot! Showing Sushi Info Sub.");
            SushiInfoSub.SetActive(true);  // Show the Sushi Info Sub text box
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collider that exited is the player
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Camera Rig left the Teleport Hotspot. Hiding Sushi Info Sub.");
            SushiInfoSub.SetActive(false);  // Hide the Sushi Info Sub text box
        }
    }
}