using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    private float currentAmountOfBuildings = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}


    public void NewBuilding()
    {
        currentAmountOfBuildings++;
    }

    public void DestroyBuilding()
    {
        currentAmountOfBuildings--;
    }
    public float GetCurrentPoints()
    {
        return currentAmountOfBuildings;
    }

}
