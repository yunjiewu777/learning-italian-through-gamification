using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject bulletPrefab;

    float cooldownTimer = 0;
    public float fireDelay = 0.25f;
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if(Input.GetButton("Fire1") && cooldownTimer <= 0){
            //SHOOT!
            Debug.Log("Pew!");
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * new Vector3(0,0.5f,0);
            Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
        }
    }
}
