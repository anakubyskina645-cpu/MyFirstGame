using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryValue : MonoBehaviour
{
    private int count = 0;
    private int coinValue = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            count++;
            if (count == 5)
            {
                int sum = 0;
                for (int i = 1; i <= count; i++)
                {
                    sum += coinValue;
                }
                Debug.Log("Coins: " + count + ", total value: " + sum);
                count = 0;
            }
        }
    }
}
