using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHotspotEclair : MonoBehaviour
{
    public GameObject EclairInfoSub;  // Reference to the text box for the exhibit
    public string targetTag = "Player"; // Camera Rig or player tag

    void Start()
    {
        // Make sure the Eclair Info Sub is hidden at the start
        if (EclairInfoSub != null)
        {
            EclairInfoSub.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger zone is the player
        if (other.CompareTag(targetTag))  // Ensure Camera Rig has tag "Player"
        {
            Debug.Log("Camera Rig entered the Teleport Hotspot! Showing Eclair Info Sub.");
            EclairInfoSub.SetActive(true);  // Show the Eclair Info Sub text box
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collider that exited is the player
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Camera Rig left the Teleport Hotspot. Hiding Eclair Info Sub.");
            EclairInfoSub.SetActive(false);  // Hide the EclairE Info Sub text box
        }
    }
}