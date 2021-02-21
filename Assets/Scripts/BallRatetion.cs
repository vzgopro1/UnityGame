using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRatetion : MonoBehaviour
{

    [SerializeField] GameObject CenterCircle;
    bool direction = false;
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void FixedUpdate()
    {   if (direction == false)
            CenterCircle.transform.Rotate(0, 0, 200 * Time.deltaTime);
        
        else
            CenterCircle.transform.Rotate(0, 0, -200 * Time.deltaTime);
    }

    public void ChangeDirection()
    {
        direction = !direction;
    }
}
