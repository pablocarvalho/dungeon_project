using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieBehavior : MonoBehaviour, IEnemy
{
    public GameObject playerObject;
    public float MovementSpeed;
    private Transform transformObj;
    private Transform playerTransform;
    private Rigidbody rigidBody;
    private GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        transformObj = transform;
        playerTransform = playerObject.transform;
        rigidBody = playerObject.GetComponent<Rigidbody>();
        gameObject = this.GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        transformObj.LookAt(playerTransform.position);
        transformObj.position += transformObj.forward * Time.deltaTime * MovementSpeed;

    }
}
