using UnityEngine;
using System.Collections;

public class WindPush : MonoBehaviour {

    public GameObject cam;

    private string buildingTag = "Blowable";
    private string meteorTag = "Meteor";
    private WindFunnel windFunnel;
    private float windSpeed;
    

    void Start()
    {
        windFunnel = FindObjectOfType<WindFunnel>();
    }

	// Update is called once per frame
	void Update () {
        windSpeed = windFunnel.GetComponent<WindFunnel>().GetCurrentWindSpeed();
        
    }

    void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == buildingTag || other.gameObject.tag == meteorTag)
        {
            var heading = other.transform.position - transform.position;
            var direction = heading / heading.magnitude;
            other.gameObject.GetComponent<Rigidbody>().AddForce(direction * windSpeed);
        }
        if (other.gameObject.tag == buildingTag && other.gameObject.GetComponent<Building>().isOnFire)
        {

        }
    }
}
