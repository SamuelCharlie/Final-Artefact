using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private DestroyWithTag destroyWithTag;
    [SerializeField] private VeloCalc veloCalc;

    public GameObject projectile;
    public Transform point;
    //public int projectileSpeed;
    [SerializeField] private FreeFlyCamera flyCamera;

    void Update()
    {
        if(!flyCamera.locked)
        {
            if (Input.GetMouseButtonDown(0))
            {
                destroyWithTag.DestroyTag("Projectile");
                GameObject force = Instantiate(projectile, point.transform.position, Quaternion.identity);
                force.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * veloCalc.sliderVeloValue;
            }
        }
    }
}
