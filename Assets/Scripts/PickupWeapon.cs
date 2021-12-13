using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupWeapon : MonoBehaviour
{
    public float distance = 10f;
    public Transform equipPosition;
    GameObject currentWeapon;

    bool canGrab;

    void Start()
    {
        
    }

    void Update()
    {
        CheckGrab();

        if (canGrab)
        {
            if (Input.GetKeyDown(KeyCode.E))
                PickUp();
        }
        
    }

    private void CheckGrab()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position,transform.forward,out hit, distance))
        {
            if (hit.transform.tag == "CanGrab")
            {
                Debug.Log("I can grab it!");
                currentWeapon = hit.transform.gameObject;
                canGrab = true;
            }
        }
        else
            canGrab = false;
    }

    private void PickUp()
    {
        currentWeapon.transform.position = equipPosition.position;
        currentWeapon.transform.parent = equipPosition;
        currentWeapon.transform.localEulerAngles = new Vector3(0f, 180f, 180f);
        currentWeapon.GetComponent<Rigidbody>().isKinematic = true;

        Debug.Log("Picked it up");
    }
}
