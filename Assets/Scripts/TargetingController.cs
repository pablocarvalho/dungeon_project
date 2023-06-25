using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingController : MonoBehaviour
{
    public EnemyManager enemyManager;

    private GameObject targetedObject;
    public GameObject TargetedObject { 
        get { 
            return targetedObject; 
        }
    }


    public int lockChangeSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("UpdateTargetedObject", 0.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //improve this
        UpdateTargetedObject();

    }

    void UpdateTargetedObject()
    {
        targetedObject = enemyManager.GetNearestEnemy(transform);
        transform.LookAt(targetedObject.transform);
    }
}
