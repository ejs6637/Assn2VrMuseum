using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHotspotFries : MonoBehaviour
{
    public GameObject FriesInfoSub;  // Reference to the text box for the exhibit
    public string targetTag = "Player"; // Camera Rig or player tag

    void Start()
    {
        // Make sure the Fries Info Sub is hidden at the start
        if (FriesInfoSub != null)
        {
            FriesInfoSub.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger zone is the player
        if (other.CompareTag(targetTag))  // Ensure Camera Rig has tag "Player"
        {
            Debug.Log("Camera Rig entered the Teleport Hotspot! Showing Fries Info Sub.");
            FriesInfoSub.SetActive(true);  // Show the Fries Info Sub text box
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collider that exited is the player
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Camera Rig left the Teleport Hotspot. Hiding Fries Info Sub.");
            FriesInfoSub.SetActive(false);  // Hide the Fries Info Sub text box
        }
    }
}