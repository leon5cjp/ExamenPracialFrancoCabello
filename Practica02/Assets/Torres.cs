using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torres : MonoBehaviour
{

    public float distancia;
     private GameObject enemygos;
    public GameObject proyectile;

    private float timeBtwShot;
    public float starTimeBtwShot;
   

    public float visionRadius;

    // Use this for initialization
    void Start()
    {
        timeBtwShot = starTimeBtwShot;
       
    }

    // Update is called once per frame
    void Update()
    {

 enemygos = GameObject.FindGameObjectWithTag("enemys");
        distancia = Vector3.Distance(enemygos.transform.position, transform.position);
        if(distancia < visionRadius) {
          //  enemygos.GetComponent<Enemys>().vida -= 5;
            Debug.Log("hola");
            if (timeBtwShot <= 0)
            {
            //Instantiate(proyectile, transform.position, Quaternion.identity);
            Debug.DrawLine(enemygos.transform.position, transform.position);
                timeBtwShot = starTimeBtwShot;
            }
            else
            {
                timeBtwShot -= Time.deltaTime;
            }
     
    }
        }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRadius);
    }
}
