using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField]
    Transform firingPoint;

    [SerializeField]
    GameObject projectilePrefab;

    [SerializeField]
    float firingSpeed;

    public static PlayerGun Instance;

    private float lastTimeShoot = 0;

    void Awake()
    {
        Instance = GetComponent<PlayerGun>();
    }

    void Update()
    {
        
    }

    public void Shoot()
    {

        if (lastTimeShoot + firingSpeed <= Time.time)
        {
            lastTimeShoot = Time.time;
            Instantiate(projectilePrefab, firingPoint.position, firingPoint.rotation);
        }
    }
}
