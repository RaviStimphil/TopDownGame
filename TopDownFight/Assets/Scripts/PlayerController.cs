using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovementInput();
        HandleRotationInput();
        HandleShootInput();
    }

    void HandleMovementInput (){
        float _horizontal = Input.GetAxis("Horizontal");
        float _verical = Input.GetAxis("Vertical");

        Vector3 _movement = new Vector3(_horizontal, 0, _verical);
        transform.Translate(_movement * movementSpeed * Time.deltaTime, Space.World);
    }

    void HandleRotationInput(){
        RaycastHit _hit;
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(_ray, out _hit)){
            transform.LookAt(new Vector3(_hit.point.x, transform.position.y, _hit.point.z));

        }
    }

    void HandleShootInput(){
        if(Input.GetButton("Fire1")){
            //Shoot
            PlayerGun.Instance.Shoot();
        }
    }
}
