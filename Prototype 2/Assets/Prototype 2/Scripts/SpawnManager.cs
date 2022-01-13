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
    {   //������� ��������� ������� �������� � ������� ����� 2 ������� ������ ������� �������
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {  

    }
    //������ ������� ��� ��������� ��������
    void SpawnRandomAnimalTop()
    {
        //�������� ���������� � ��������� ��������� ���� ��� ������
        Vector3 spawnPoz = new Vector3(Random.Range(spawnPozX, -spawnPozX), spawnPozY, spawnPozZ1);
        //� ���������� ���������� ��������� ����� �� 0 �� ����� ������ ������
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //������� ����� ������� �� ������ �������� � ��������� ��������� ���� ������� ���������� ����������� ��� � ����
        Instantiate(animalPrefabs[animalIndex], spawnPoz, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalLeft()
    {
        //�������� ���������� � ��������� ��������� ���� ��� ������
        Vector3 spawnPoz = new Vector3(-spawnPozX, spawnPozY, Random.Range(spawnPozZ1, spawnPozZ2));
        //� ���������� ���������� ��������� ����� �� 0 �� ����� ������ ������
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //������� ����� ������� �� ������ �������� � ��������� ��������� ���� ������� ���������� ����������� �� 90 ��������
        Instantiate(animalPrefabs[animalIndex], spawnPoz, Quaternion.Euler(rotationPr));
    }
    void SpawnRandomAnimalRight()
    {
        //�������� ���������� � ��������� ��������� ���� ��� ������
        Vector3 spawnPoz = new Vector3(spawnPozX, spawnPozY, Random.Range(spawnPozZ1, spawnPozZ2));
        //� ���������� ���������� ��������� ����� �� 0 �� ����� ������ ������
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //������� ����� ������� �� ������ �������� � ��������� ��������� ���� ������� ���������� ����������� �� 90 ��������
        Instantiate(animalPrefabs[animalIndex], spawnPoz, Quaternion.Euler(-rotationPr));
    }
}
