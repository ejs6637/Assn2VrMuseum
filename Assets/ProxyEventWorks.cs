using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyEventWorks : MonoBehaviour
{
    public GameObject TextBoxName;  // Reference to the text box for the exhibit
    public string targetTag = "Player"; // Camera Rig or player tag

    void Start()
    {
        // Make sure the Burger Info Sub is hidden at the start
        if (TextBoxName != null)
        {
            TextBoxName.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger zone is the player
        if (other.CompareTag(targetTag))  // Ensure Camera Rig has tag "Player"
        {
            Debug.Log("Camera Rig entered the Teleport Hotspot! Showing Burger Info Sub.");
            TextBoxName.SetActive(true);  // Show the Burger Info Sub text box
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collider that exited is the player
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Camera Rig left the Teleport Hotspot. Hiding Burger Info Sub.");
            TextBoxName.SetActive(false);  // Hide the Burger Info Sub text box
        }
    }
}

