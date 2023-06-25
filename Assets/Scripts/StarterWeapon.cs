using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterWeapon : MonoBehaviour, IWeapon
{
    public Transform BulletSpawnPoint;
    public float FireRate;
    public int BulletSpeed;
    public GameObject BulletPrefab;
    private TargetingController targetingController;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0.0f, FireRate);
        targetingController = GetComponentInParent<TargetingController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        if(targetingController.TargetedObject != null)
        {
            var direction = Quaternion.LookRotation(targetingController.TargetedObject.transform.position);
            var bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, direction);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;
        }
       
    }
}
