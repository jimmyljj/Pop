using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed;
    private Rigidbody rb;
    public Camera _camera;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        HandleMovementInput();
        HandleRotationInput();
        HandleShootInput();
    }

    void HandleMovementInput()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");
        Vector3 _movement = new Vector3(_horizontal, 0, _vertical);
        transform.Translate(_movement * movementSpeed * Time.deltaTime, Space.World);
    }

    void HandleRotationInput ()
    {
        RaycastHit _hit;
        Ray _ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray, out _hit))
        {
            Vector3 positition = new Vector3(_hit.point.x, transform.position.y, _hit.point.z);
            transform.LookAt(positition);
            Debug.Log(positition);
        }
    }

    void HandleShootInput ()
    {
        if (Input.GetButton("Fire1"))
        {
            //Shoot
            PlayerGun.Instance.Shoot();
        }
    }

}
