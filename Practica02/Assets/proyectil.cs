using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour {

    public float speed;

    private Transform enemys;
    private Vector2 target;

	// Use this for initialization
	void Start () {
        enemys = GameObject.FindGameObjectWithTag("enemys").transform;

        target = new Vector2(enemys.position.x, enemys.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position =  Vector2.MoveTowards(transform.position,target,speed * Time.deltaTime);
        if(transform.position.x  == target.x && transform.position.y == target.y)
        {
            DesTroyProyectile();
        }
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemys"))
        {
            enemys.GetComponent<Enemys>().vida -= 20;
        }
    }
    void DesTroyProyectile()
    {
        Destroy(gameObject);
    }
}
