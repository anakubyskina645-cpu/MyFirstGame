using UnityEngine;
using UnityEngine.InputSystem;

public class PressCounter : MonoBehaviour
{
    private int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello, Unity!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            count++;
        }
        if (count == 5)
        {
            Debug.Log("Five presses reached!");
        }
    }
}
