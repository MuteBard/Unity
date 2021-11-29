using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    RigidBodyManager rigidBodyManager;
    [SerializeField] [Range(0,200)] float speed = 10000f;
    [SerializeField] GameObject target;

    bool isTransitioning = false;
    void Awake()
    {
        speed = 10000 * speed; 
        rigidBodyManager = GetComponent<RigidBodyManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidBodyManager.ClockWiseAlongY(true, speed);
    }
}
