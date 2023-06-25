using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public int MinEnemyCount;
    public int MaxEnemyCount;

    //private List<IEnemy> EnemiesList;
    public List<GameObject> EnemiesObjects;
    private List<Action> _EnemyObservers;

    public void SubscribeObservers(Action enemyObserver)
    {
        _EnemyObservers.Add(enemyObserver);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetNearestEnemy(Transform objectPosition)
    {
        if (EnemiesObjects.Count == 0)
            return null;

        GameObject nearestObject = EnemiesObjects[0];
        var nearestDist = Vector3.Distance(objectPosition.position, nearestObject.transform.position);
        for(int i = 1; i < EnemiesObjects.Count; i++)
        {
            var distance = Vector3.Distance(objectPosition.position, EnemiesObjects[i].transform.position);

            if(nearestDist > distance){
                nearestDist = distance;
                nearestObject = EnemiesObjects[i];
            }

        }

        return nearestObject;
    }

}
