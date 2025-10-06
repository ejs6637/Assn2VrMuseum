using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHotspotChicken : MonoBehaviour
{
    public GameObject ChickenInfoSub;  // Reference to the text box for the exhibit
    public string targetTag = "Player"; // Camera Rig or player tag

    void Start()
    {
        // Make sure the Chicken Info Sub is hidden at the start
        if (ChickenInfoSub != null)
        {
            ChickenInfoSub.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger zone is the player
        if (other.CompareTag(targetTag))  // Ensure Camera Rig has tag "Player"
        {
            Debug.Log("Camera Rig entered the Teleport Hotspot! Showing Chicken Info Sub.");
            ChickenInfoSub.SetActive(true);  // Show the Chicken Info Sub text box
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collider that exited is the player
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Camera Rig left the Teleport Hotspot. Hiding Chicken Info Sub.");
            ChickenInfoSub.SetActive(false);  // Hide the Chicken Info Sub text box
        }
    }
}