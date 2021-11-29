using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyManager : MonoBehaviour
{
    Rigidbody rigidBody;
    [SerializeField] float speedMuliplier = 1f;
    Vector3 initialPosition;
    bool isTransitioning = false;
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    void Update(){
    }

    public void IncreaseVelocity(float speed){
        rigidBody.velocity = rigidBody.velocity * speed;
    }

    // https://homeweb.csulb.edu/~pnguyen/cecs475/pdf/cecs475lec5.pdf
    public void ClockWiseAlongX(bool moveRight, float speed){
        Vector3 rotation = moveRight ? new Vector3(1, 0, 0) : new Vector3(-1, 0, 0);
        ClockWise(rotation * speed * speedMuliplier * Time.deltaTime);
    }

    public void ClockWiseAlongY(bool moveRight, float speed){
        Vector3 rotation = moveRight ? new Vector3(0, 1, 0)  : new Vector3(0, -1, 0);
        ClockWise(rotation * speed * speedMuliplier * Time.deltaTime);
    }

    public void ClockWiseAlongZ(bool moveRight, float speed){
        Vector3 rotation = moveRight ? new Vector3(0, 0, 1) : new Vector3(0, 0, -1);
        ClockWise(rotation * speed * speedMuliplier * Time.deltaTime);
    }

    public void ForwardAlongX(bool moveForward, float speed){
        Vector3 position = moveForward ? new Vector3(1, 0, 0) : new Vector3(-1, 0, 0);
        ForwardAlong(position * speed * speedMuliplier * Time.deltaTime);
    }

    public void ForwardAlongY(bool moveForward, float speed){
        Vector3 position = moveForward ? new Vector3(0, 1, 0) : new Vector3(0, -1, 0);
        ForwardAlong(position * speed * speedMuliplier * Time.deltaTime);
    }

    public void ForwardAlongZ(bool moveForward, float speed){
        Vector3 position = moveForward ? new Vector3(0, 0, 1) : new Vector3(0, 0, -1);
        ForwardAlong(position * speed * speedMuliplier * Time.deltaTime);
    }

    private void ClockWise(Vector3 rotation){
        if(!isTransitioning){
            rigidBody.freezeRotation = true;
            transform.Rotate(rotation);
            rigidBody.freezeRotation = false;
        }
    }

    private void ForwardAlong(Vector3 position){
        if(!isTransitioning){
            rigidBody.freezeRotation = true;
            rigidBody.AddRelativeForce(position);
            rigidBody.freezeRotation = false;
        }
    }
    public void TurnAroundX(float degrees, float speed){
        Vector3 to = new Vector3(Math.Abs(degrees), 0, 0);
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
    }

    public void TurnAroundY(float degrees, float speed){
        Vector3 to = new Vector3(0, Math.Abs(degrees), 0);
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
    }

    public void TurnAroundZ(float degrees, float speed){
        Vector3 to = new Vector3(0, 0, Math.Abs(degrees));
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
    }
    public void startTransition(){
        isTransitioning = true;
    }

    public void stopTransition(){
        isTransitioning = false;
    }

    public void SinusoidalX(float speed, float distance){
        float value = (float) Math.Sin(Time.time * speed) * distance;
        Vector3 position = new Vector3(transform.position.x + value, transform.position.y, transform.position.z);
        transform.position = position;
    }

    public void SinusoidalY(float speed, float distance){
        float value = (float) Math.Sin(Time.time * speed) * distance;
        Vector3 position = new Vector3(transform.position.x, transform.position.y + value, transform.position.z);
        transform.position = position;
    }

    public void SinusoidalZ(float speed, float distance){
        float value = (float) Math.Sin(Time.time * speed) * distance;
        Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z + value);
        transform.position = position;   
    }   
}
