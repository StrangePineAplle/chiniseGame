using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject SpawnObject;
    [SerializeField] const int numberOfSpawningObjects = 2;
    public GameObject[] SpawnObjectList=new GameObject[numberOfSpawningObjects];
    public float CoolDown = 1f;
    [SerializeField] public float CoolDownChange = 0.01f;

    private int NumberOfSpawnObject = 0;
    private int RandomNumber;
    [SerializeField] int[] SpawnChanses = {75,25};

    [SerializeField] private bool GameIsPlaying = false;
    /*
  index of objects 
  0 - bolt
  1 - box
   */

    void Awake()
    {
        Time.timeScale = 1.0f;
        StartCoroutine(SpawnCD());  //переписать под запуск сцены
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
   
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(CoolDown);
        RandomNumber = Random.Range(0, 100);

        if (RandomNumber <=SpawnChanses[0] ) NumberOfSpawnObject = 0; //bolt spawn 75%
        else if(RandomNumber > (100 - SpawnChanses[1]) ) NumberOfSpawnObject= 1; //box spawn 25%

        Instantiate(SpawnObjectList[NumberOfSpawnObject], SpawnPos.position, Quaternion.identity);  //сделать ЕЩЁ рандомнее
        Repeat();
    }
    private void FixedUpdate()
    {
        if (CoolDown > 0.4)
        {
            CoolDown -= CoolDownChange * Time.deltaTime;
        }
    }
}

