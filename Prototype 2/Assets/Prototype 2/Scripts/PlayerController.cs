using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 20.0f;
    public float zRangeTop = 30.0f;
    public float zRangeBot = -10.0f;
    public GameObject projectilePrefab;
    public GameObject projectileSpawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���� �� ������ ������
        if (Input.GetKeyDown(KeyCode.Space))
        {   //��������� ������ � ����� ������ ������� �� �����������
            Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, projectilePrefab.transform.rotation);
        }

        //���� ����� ������� �� 10 ������ �� ������ �����
        if(transform.position.x < -xRange)
        {
            //������ �� �� ����� ������
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //���� ����� ������� �� 10 ������ �� ������ ����� 
        if (transform.position.x > xRange)
        {
            //������ �� �� ����� ������
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //���� ����� ������� �� 30 ������ �� ������ �����
        if (transform.position.z > zRangeTop)
        {
            //������ �� �� ����� ������
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeTop);
        }

        //���� ����� ������� �� 10 ������ �� ������ ����
        if (transform.position.z < zRangeBot)
        {
            //������ �� �� ����� ������
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeBot);
        }

        //���������� ���������� ��� �������� ���� - �����
        horizontalInput = Input.GetAxis("Horizontal");

        //���������� ���������� ��� �������� ������ - �����
        verticalInput = Input.GetAxis("Vertical");

        //��� ������� a d �������� � �������  
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //��� ������� w s �������� ������ - �����
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
    }
}
