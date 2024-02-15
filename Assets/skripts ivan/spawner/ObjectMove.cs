using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private float speed = -1f;
    [SerializeField] public float speedChange = 0.01f;
    [SerializeField] public int ScoreValue = 1;
    [SerializeField] public int HpValue = 0;


    public GameObject BoltModelDown;
    public GameObject BoltModelUp;
    public GameObject BoltModelBroke;

    void Start()
    {
        speed -= speedChange * Time.time;
    }
    void FixedUpdate()
    {
        transform.Translate(speed * Vector3.right * Time.deltaTime, Space.World);

        
    }

    public void zabivanie()  //zabivanie 
    {
            BoltModelUp.SetActive(false);
            BoltModelDown.SetActive(true);
    }

    public void BoltCrash() //boltCrushing
    {
        BoltModelUp.SetActive(false);
        BoltModelBroke.SetActive(true);
    }

    private void OnTriggerEnter(Collider other) //bolt destruct
    {
        if (other.gameObject.CompareTag("BoltDestruct"))
        {
            Destroy(this.gameObject);
        }
    }

}