using UnityEngine;
using UnityEngine.InputSystem;

public class TwoKeyCounter : MonoBehaviour
{
    private int count = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            count++;
            Debug.Log("Count: " + count);
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            count--;
            Debug.Log("Count: " + count);
        }
        if (count == 5)
        {
            count = 0;
            Debug.Log("Max reached!");
        }
        if (count < 0)
        {
            count = 0;
            Debug.Log("Negative!");
        }
    }
}
