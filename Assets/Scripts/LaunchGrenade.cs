using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchGrenade : MonoBehaviour
{
    //Variable;
    public Transform spawnPoint;
    public GameObject grenade;

    public float range = 10f;
    public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.G))
            Launch();
    }

    private void Launch()
    {
        // GameObject grenadeInstance = Instantiate(grenade, spawnPoint.position, spawnPoint.rotation);
        // grenadeInstance.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * range, ForceMode.Impulse);

        GameObject grenadeInstance = Instantiate(grenade, spawnPoint.position, grenade.transform.rotation);
        grenadeInstance.transform.rotation = Quaternion.LookRotation(-spawnPoint.forward);
        Rigidbody grenadeRig = grenadeInstance.GetComponent<Rigidbody>();

        grenadeRig.AddForce(spawnPoint.forward * speed, ForceMode.Impulse);
    }
}
