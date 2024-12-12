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

    private float lastTimeShot = 0;

    public static PlayerGun Instance;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = GetComponent<PlayerGun>();
    }

    

    public void Shoot(){
        if (lastTimeShot + firingSpeed <= Time.time){
            lastTimeShot = Time.time;
            Instantiate(projectilePrefab, firingPoint.position, firingPoint.rotation);

        }

    }
}
