using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCont : MonoBehaviour
{

    public float power = 1;
    public Rigidbody rigidbody;
    private int timer = 300;
    private int addTimer = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        if(timer == 600 || timer == 0)
        {
            addTimer *= -1;
        } 
        timer += addTimer;

        if (rigidbody.position.x < 0)
        {
            rigidbody.AddForce(new Vector3(1, 0, 0) * power);
        }else if(rigidbody.position.x > 0)
        {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }
        else { }

    }
}
