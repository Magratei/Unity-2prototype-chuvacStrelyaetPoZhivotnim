using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPozX = 20;
    private float spawnPozY = 0;
    private float spawnPozZ1 = 30;
    private float spawnPozZ2 = -10;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private Vector3 rotationPr = new Vector3(0, 90, 0);
    void Start()
    {   //начинаю повторять функцию указаную в скобках через 2 секунды каждые полторы секунды
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {  

    }
    //создаю функцию для генерации животных
    void SpawnRandomAnimalTop()
    {
        //обьявляю переменную с рандомный положение икса для спавна
        Vector3 spawnPoz = new Vector3(Random.Range(spawnPozX, -spawnPozX), spawnPozY, spawnPozZ1);
        //в переменную генерируем случайное число от 0 до числа длинны масива
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //создаем копию префаба из масива префабов в случайном диапазоне икса заданом переменной повернутыми как и было
        Instantiate(animalPrefabs[animalIndex], spawnPoz, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalLeft()
    {
        //обьявляю переменную с рандомный положение икса для спавна
        Vector3 spawnPoz = new Vector3(-spawnPozX, spawnPozY, Random.Range(spawnPozZ1, spawnPozZ2));
        //в переменную генерируем случайное число от 0 до числа длинны масива
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //создаем копию префаба из масива префабов в случайном диапазоне икса заданом переменной повернутыми на 90 градусов
        Instantiate(animalPrefabs[animalIndex], spawnPoz, Quaternion.Euler(rotationPr));
    }
    void SpawnRandomAnimalRight()
    {
        //обьявляю переменную с рандомный положение икса для спавна
        Vector3 spawnPoz = new Vector3(spawnPozX, spawnPozY, Random.Range(spawnPozZ1, spawnPozZ2));
        //в переменную генерируем случайное число от 0 до числа длинны масива
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //создаем копию префаба из масива префабов в случайном диапазоне икса заданом переменной повернутыми на 90 градусов
        Instantiate(animalPrefabs[animalIndex], spawnPoz, Quaternion.Euler(-rotationPr));
    }
}
