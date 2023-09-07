using UnityEngine;

public class PuzzleScript : MonoBehaviour
{
    public static bool puzzle = false;
    public Transform object1;
    public Transform object2;
    private void FixedUpdate()
    {
        if (object1.position.y < 3 && object2.position.y < 3
            && object1.position.x > -16 && object1.position.x < -15
            && object2.position.x > -16 && object2.position.x < -15)
        {
            puzzle = true;
            Debug.Log("Puzzle solved");
        }
        
    }
}
