using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int helth = 3;
    void Start()
    {
        Debug.Log($"Çהמנמגüו: {helth}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && helth > 1)
        {
            helth -= 1;
            Debug.Log($"Çהמנמגüו: {helth}");
            Destroy(gameObject);
        }else if (other.CompareTag("Player") && helth < 2)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (other.CompareTag("food"))
        {
            helth += 1;
            Debug.Log($"Çהמנמגüו: {helth}");
            Destroy(gameObject);
        }
        
    }
}
