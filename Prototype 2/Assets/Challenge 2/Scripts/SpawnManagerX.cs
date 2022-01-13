using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float spawnInterval = 1;
    private float startDelay = 1.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        //запускапю функцию ниже
        Invoke("SpawnRandomBall", startDelay);
    }



    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        spawnInterval = Random.Range(1, 5);
        int nomBall = Random.Range(0, ballPrefabs.Length);
        // задаю диапазон для создания шариков
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // создаю шарики в заданом диапазоне
        Instantiate(ballPrefabs[nomBall], spawnPos, ballPrefabs[0].transform.rotation);
        //перезапускаю сам себя через определенное время
        Invoke("Start", spawnInterval);
    }

}
