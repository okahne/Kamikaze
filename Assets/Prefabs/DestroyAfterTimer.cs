using UnityEngine;
using System.Collections;

public class DestroyAfterTimer : MonoBehaviour {

    [SerializeField]
    float timeUntilDestruction = 1f;

    private float lifeTime;
	// Use this for initialization
	void Start () {
        lifeTime = 0f; 
	}
	
	// Update is called once per frame
	void Update () {
        lifeTime = lifeTime + Time.deltaTime;
        if (lifeTime>timeUntilDestruction)
        {
            Destroy(gameObject);
        }
	}
}
