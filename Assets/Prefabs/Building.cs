using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {

    
    public float hitPoints = 100f;
    public bool isOnFire = false;
    public float lastFireDamage;

    void Awake()
    {
        // tell the manager that this building exist for tracking purposes
        FindObjectOfType<GameManager>().GetComponent<GameManager>().NewBuilding();
    }
	// Use this for initialization
	void Start () {
        lastFireDamage = Time.time;
    }
	
	// Update is called once per frame
	void Update () {

        if (isOnFire && lastFireDamage > 1f)
        {
            hitPoints--;
            lastFireDamage = 0f;
        }
        else
        {
            lastFireDamage = lastFireDamage + Time.deltaTime;
        }
        if (hitPoints <= 0)
        {
            FindObjectOfType<GameManager>().GetComponent<GameManager>().DestroyBuilding();
            Destroy(gameObject);
        }
	}

    public void SetOnFire()
    {
        isOnFire = true;
    }
}
