using UnityEngine;

public class SetParent : MonoBehaviour
{
    public GameObject newParent;

    // Call this method to change the parent of the GameObject to the new empty GameObject
    public void ChangeGameObjectParent()
    {
        if (newParent != null)
        {
            // Change the parent of this GameObject to the newParent
            transform.parent = newParent.transform;
        }
        else
        {
            Debug.LogError("New parent is not assigned.");
        }
    }
}
