using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float rightBound = 20.0f;
    private GameManager gameManager;
    void Start()
    {   //достаю из GameManager скрипта какую то из функций
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {   //если обьект идет на позицию по z дальше указаной 
        if (transform.position.z > topBound)
        {
            Destroy(gameObject); //уничтожить обьект
            gameManager.AddLives(-1);//отнимаю жизнь
        }
        else if (transform.position.z < lowerBound) //если обьект идет на позицию по z дальше указаной
        {
            Destroy(gameObject);//уничтожить обьект
            
        }

        if (transform.position.x > rightBound)
        {
            Destroy(gameObject); //уничтожить обьект
            gameManager.AddLives(-1);//отнимаю жизнь
        }
        else if (transform.position.x < -rightBound) //если обьект идет на позицию по x дальше указаной
        {
            Destroy(gameObject);//уничтожить обьект
            gameManager.AddLives(-1);//отнимаю жизнь++

        }
    }
}
