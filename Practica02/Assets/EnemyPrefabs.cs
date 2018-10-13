using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrefabs : MonoBehaviour {
    public GameObject enemyPrefabs;
    public float generadorTimer = 2.75f;


	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateEnemy", 0f, generadorTimer);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void CreateEnemy()
    {
        Instantiate(enemyPrefabs, transform.position, Quaternion.identity);
    }
  
}
