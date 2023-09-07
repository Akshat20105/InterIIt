using UnityEngine;
using System.Collections;

public class render_mirrors : MonoBehaviour
{
    public GameObject objectToToggle;
    public GameObject text;
    
    // private bool playerInside = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Player has entered the trigger zone
            objectToToggle.SetActive(true);
            text.SetActive(true);
            Debug.Log("Player entered the trigger zone.");
            StartCoroutine(WaitForFourSeconds());
    }

    IEnumerator WaitForFourSeconds()
    {
        // Wait for 4 seconds
        yield return new WaitForSeconds(4f);
        text.SetActive(false);
        // This code will run after waiting for 4 seconds
        Debug.Log("Waited for 4 seconds.");
    }
    }



}
