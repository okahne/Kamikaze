using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {

    void Awake()
    {
        // tell the manager that this building exist for tracking purposes
        FindObjectOfType<GameManager>().GetComponent<GameManager>().NewBuilding();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
