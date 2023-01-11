using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    Rigidbody rigid;
    [SerializeField] private GameObject box;
    [SerializeField] private float spawnBoxTime;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("Spawn", 5f); //5 saniye sonra Spawn methodunu �al��t�r�r.
        InvokeRepeating("SpawnBox", 5f, spawnBoxTime);//ilk olarak 5 saniye sonra SpawnBox methodunu �al��t�r�r ve ard�ndan 2 saniyede bir methodu �al��t�rmaya devam eder.

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }
    void MovePlayer()
    { 
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue*speed*Time.deltaTime, 0, zValue*speed*Time.deltaTime);

    }
    void SpawnBox()
    {
        Vector3 playerPosition = GetComponent<Transform>().position;
        Vector3 spawnPosition = new Vector3((float)playerPosition.x, (float)playerPosition.y+10, (float)playerPosition.z);
        GameObject boxClone= Instantiate(box,spawnPosition,Quaternion.identity);
        Destroy(boxClone,8f);
    }
}
