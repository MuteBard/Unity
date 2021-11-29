using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlyingTanker : MonoBehaviour
{
    RigidBodyManager rigidBodyManager;
    [SerializeField] [Range(0,10)] float speed = .2f;
    [SerializeField] GameObject projectile, gun;
    [SerializeField] [Range(0,20)] float distance = 10f; 
    [SerializeField] bool shoot = true;

    void Awake()
    {
        rigidBodyManager = GetComponent<RigidBodyManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.Z)){
            StartCoroutine(Fire());
        }else{
            Move();
        }
    }

    private IEnumerator Fire(){
        if(shoot){
            shoot = false;
            rigidBodyManager.SinusoidalY(0, distance);
            GameObject newProjectile = Instantiate(projectile, gun.transform.position, transform.rotation) as GameObject;
            yield return new WaitForSeconds(.1f);
            rigidBodyManager.SinusoidalY(speed, distance);
            shoot = true;
        }
    }
        private void Move(){
        rigidBodyManager.SinusoidalY(speed, distance);
    }
}