using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject Mirror2;
    public GameObject text;
    private void Update()
    {
        if(transform.position.y < -2.8)
        {
            Debug.Log("Player completes the Trap.");
           Mirror2.SetActive(true);
           text.SetActive(true);
           StartCoroutine(WaitForFourSeconds());
        }   
    }
    IEnumerator WaitForFourSeconds()
    {
        // Wait for 4 seconds
        yield return new WaitForSeconds(4f);
        text.SetActive(false);
        // This code will run after waiting for 4 seconds
        // Debug.Log("Waited for 4 seconds.");
    }
}
