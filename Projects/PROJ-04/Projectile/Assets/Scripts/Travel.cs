using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Travel : MonoBehaviour
{
    
    [Header("Translation")]
    [SerializeField] float moveSpeed = 50f;
    [SerializeField] GameObject path;
    [SerializeField] bool loop = false;
    bool stopped = false;
    int currentVector = 0;
    List<Vector3> vectors;
    void Start(){
        vectors = GetAllWayPointVectors();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move(){
        if(currentVector < vectors.Count && !stopped){    
            Vector3 targetPosition = vectors[currentVector];
            float factor = Math.Abs(Vector3.Distance(targetPosition, transform.position)) / Vector3.Distance(transform.position, new Vector3(0,0,0));
            factor = factor > 20 ? 20 : factor;
            float MovementThisFrame = moveSpeed * factor * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, MovementThisFrame);

            if(Vector3.Distance(transform.position, targetPosition) < 5){
                currentVector++;
            }
        }else{
            if(loop){
                currentVector = 0;
            }else{
                GetComponent<Travel>().enabled = false;
            }
        }
    }

    private List<Vector3> GetAllWayPointVectors(){
        var wayPoints = path.GetComponentsInChildren<WayPoint>();
        return wayPoints.Select(wayPoint => wayPoint.GetPosition()).ToList();
    }
}
