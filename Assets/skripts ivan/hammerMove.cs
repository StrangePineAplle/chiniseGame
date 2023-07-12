using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerMove : MonoBehaviour
{
    [SerializeField] bool IsHammerDown = false;
    private Quaternion RotationXDown = Quaternion.AngleAxis(90, new Vector3(1,0,0));
    private Quaternion RotationXUp = Quaternion.AngleAxis(0, new Vector3(1, 0, 0));




    void Update()
    {
        if (Input.GetMouseButtonDown(0) && IsHammerDown == false)
        {
            IsHammerDown = true;
            this.transform.rotation = RotationXDown;
        }

        if (Input.GetMouseButtonDown(1) && IsHammerDown==true)
        {
            IsHammerDown = false;
            this.transform.rotation = RotationXUp;
        }

    }



}
