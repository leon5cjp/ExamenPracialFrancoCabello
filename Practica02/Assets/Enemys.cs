using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour {
    public float vida;
    public float speed;
    public string nombreWaipoints;
    private Waipoints Wpoints;

    
  
    private int waipointsIndex;

	// Use this for initialization
	void Start () {
        Wpoints = GameObject.Find(nombreWaipoints).GetComponent<Waipoints>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waipointsIndex].position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position,Wpoints.waypoints[waipointsIndex].position) < 0.01f)
        {
        if(waipointsIndex < Wpoints.waypoints.Length - 1)
            {
   waipointsIndex++;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
