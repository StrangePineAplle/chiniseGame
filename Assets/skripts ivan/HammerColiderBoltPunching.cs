using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerColiderBoltPunching : MonoBehaviour
{
    public int ObjectNeedDestruction = 1;

    public void OnTriggerEnter(Collider collision)
    {

        if (ObjectNeedDestruction == 1)
        {
            collision.gameObject.GetComponent<ObjectMove>().zabivanie(); //юнити не нравится что указываем на пустой объект
        }
        else if(ObjectNeedDestruction == 2)
        {
            collision.gameObject.GetComponent<ObjectMove>().BoltCrash();
            collision.gameObject.tag = "Untagged";  //teg error
            ObjectNeedDestruction = 1;
        }
        
    }
}
