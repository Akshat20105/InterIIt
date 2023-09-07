using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReset : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player enters the Trap zone.");
            Invoke("SceneReset1", 1.5f);
        }
    }
    private void SceneReset1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 
}
