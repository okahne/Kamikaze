using UnityEngine;
using System.Collections;

public class MeteorSpawner : MonoBehaviour {

    public GameObject meteor;
    private GameObject go;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Random.Range(0f, 1f) > 0.99f)
        {
            Vector3 spawnLocation = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-1f,1f));
            go = Instantiate(meteor, transform.position + spawnLocation, transform.rotation) as GameObject;

            Vector3 randomMovement = new Vector3(-spawnLocation.x, -1, -spawnLocation.z);
            go.GetComponent<Rigidbody>().velocity = randomMovement;
        }
        
        

	}
}