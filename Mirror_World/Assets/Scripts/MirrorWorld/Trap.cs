using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject Mirror2;
    private void Update()
    {
        if(transform.position.y < -2.8)
        {
            Debug.Log("Player completes the Trap.");
           Mirror2.SetActive(true);
        }   
    }
}
