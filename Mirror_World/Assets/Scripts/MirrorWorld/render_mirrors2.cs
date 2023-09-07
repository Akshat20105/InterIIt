using TMPro;
using UnityEngine;

public class render_mirrors2 : MonoBehaviour
{
    public GameObject objectToToggle;
    public GameObject text;


    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Player has entered the trigger zone
            objectToToggle.SetActive(false);
            text.SetActive(true);
            Debug.Log("Player entered mirror world");
        }
    }

}
