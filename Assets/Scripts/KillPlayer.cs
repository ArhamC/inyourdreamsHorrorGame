using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    // This method is called when another collider enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered the kill zone."); // Debug log to confirm collision detection

            // Get the player's SC_FPSController component and call Respawn()
            SC_FPSController playerController = other.GetComponent<SC_FPSController>();
            if (playerController != null)
            {
                playerController.Respawn();
            }
        }
    }
}
