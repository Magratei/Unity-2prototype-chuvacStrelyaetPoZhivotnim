using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float coolDown;
    private float timeToRespavn = 1;

    // Update is called once per frame
    void Update()
    {
        coolDown += Time.deltaTime;
        //по кулдауну могу пробелом создавать собак
        if (Input.GetKeyDown(KeyCode.Space) && coolDown > timeToRespavn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            coolDown = 0;
        }
        
        
    }
}
