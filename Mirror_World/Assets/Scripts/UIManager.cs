using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("StartGame");
       SceneManager.LoadScene("SampleScene");
    }


    public void QuitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }
}
