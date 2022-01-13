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
    {   //������ �� GameManager ������� ����� �� �� �������
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {   //���� ������ ���� �� ������� �� z ������ �������� 
        if (transform.position.z > topBound)
        {
            Destroy(gameObject); //���������� ������
            gameManager.AddLives(-1);//������� �����
        }
        else if (transform.position.z < lowerBound) //���� ������ ���� �� ������� �� z ������ ��������
        {
            Destroy(gameObject);//���������� ������
            
        }

        if (transform.position.x > rightBound)
        {
            Destroy(gameObject); //���������� ������
            gameManager.AddLives(-1);//������� �����
        }
        else if (transform.position.x < -rightBound) //���� ������ ���� �� ������� �� x ������ ��������
        {
            Destroy(gameObject);//���������� ������
            gameManager.AddLives(-1);//������� �����++

        }
    }
}
