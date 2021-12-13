using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float dashSpeed;
    Rigidbody rig;
    bool isDashing;

    public GameObject dashEffect;

    [SerializeField]
    Transform EjectEffect;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        isDashing = true;
    }
    private void FixedUpdate()
    {
        if (isDashing)
        {
            Dashing();
        }
        else
        {
            rig.velocity = Vector3.zero;
        }

    }

    private void Dashing()
    {
        rig.velocity = Vector3.zero;
        rig.AddForce(transform.forward * dashSpeed, ForceMode.Force);
        isDashing = false;

        CancelInvoke("ResetSpeed");
        
        Invoke("ResetSpeed", 0.5f);

        /*GameObject effect = Instantiate(dashEffect, Camera.main.transform.position, dashEffect.transform.rotation);
        effect.transform.parent = Camera.main.transform;
        effect.transform.LookAt(transform);*/

        GameObject effect = Instantiate(dashEffect, EjectEffect.position, EjectEffect.rotation);
        effect.transform.parent = Camera.main.transform;
        effect.transform.LookAt(transform);
    }

    private void ResetSpeed()
    {
        rig.velocity = Vector3.zero;

    }
}
