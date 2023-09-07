using UnityEngine;

public class Enter_mirror : MonoBehaviour
{
    public GameObject[] real;
    public GameObject[] mirror;


    private bool areObjectsActive = true;
    private bool playerInside = false;

    void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Player has entered the trigger zone
            playerInside = true;
            Debug.Log("Player enters the trigger zone.");
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the object that exited the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Player has exited the trigger zone
            playerInside = false;
             Debug.Log("Player exits the trigger zone.");
        }
    }

    void Update()
    {
        // Check if the "M" key is pressed
        if (Input.GetKeyDown(KeyCode.M)&&playerInside)
        {
            ToggleObjects();
        }
    }

    public void ToggleObjects()
    {
        areObjectsActive = !areObjectsActive;

        foreach (GameObject obj in real)
        {
            obj.SetActive(areObjectsActive);
        }
        foreach (GameObject obj in mirror)
        {
            obj.SetActive(!areObjectsActive);
        }
    }
}
