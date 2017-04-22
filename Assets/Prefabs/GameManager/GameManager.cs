using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    private float currentScore = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void AddPoints(float additionalPoints)
    {
        currentScore += additionalPoints;
    }
    public float GetCurrentPoints()
    {
        return currentScore;
    }

}
