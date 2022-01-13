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
        //если мы нажали пробел
        if (Input.GetKeyDown(KeyCode.Space))
        {   //дублируем прифаб в место нашего обьекта не поворачивая
            Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, projectilePrefab.transform.rotation);
        }

        //если игрок заходин на 10 единиц от центра влево
        if(transform.position.x < -xRange)
        {
            //дальше он не может пройти
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //если игрок заходин на 10 единиц от центра влево 
        if (transform.position.x > xRange)
        {
            //дальше он не может пройти
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //если игрок заходин на 30 единиц от центра вверх
        if (transform.position.z > zRangeTop)
        {
            //дальше он не может пройти
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeTop);
        }

        //если игрок заходин на 10 единиц от центра вниз
        if (transform.position.z < zRangeBot)
        {
            //дальше он не может пройти
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeBot);
        }

        //присваиваю переменной акс движения лево - право
        horizontalInput = Input.GetAxis("Horizontal");

        //присваиваю переменной акс движения вперед - назад
        verticalInput = Input.GetAxis("Vertical");

        //при нажатии a d двигаюсь в сторону  
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //при нажатии w s двигаюсь вперед - назад
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
    }
}
