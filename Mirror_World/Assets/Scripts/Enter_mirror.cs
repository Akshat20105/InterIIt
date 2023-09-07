using UnityEngine;
using UnityEngine.UI;
// import textmeshpro
using TMPro;
using UnityEngine.SceneManagement;
 
public class Enter_mirror : MonoBehaviour
{
    
    public GameObject t;
    public TextMeshProUGUI text;
    private bool playerInside = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Player has entered the trigger zone
            playerInside = true;
            // Debug.Log("Player enters the trigger zone.");


        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Check if the object that exited the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Player has exited the trigger zone
            playerInside = false;
            //  Debug.Log("Player exits the trigger zone.");
        }
    }

    void Update()
    {
        // Check if the "M" key is pressed
        if (Input.GetKeyDown(KeyCode.M)&&playerInside)
        {
           
            SceneManager.LoadScene(2);
            // destroy.GameObject();

        }
        if(playerInside) t.SetActive(true);
        else t.SetActive(false); 
    }

     
}
