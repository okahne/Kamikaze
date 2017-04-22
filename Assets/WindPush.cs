using UnityEngine;
using System.Collections;

public class WindPush : MonoBehaviour {

    private string blowableTag = "Blowable";
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
        print("Collision with "+ other.gameObject.name);
        if (other.gameObject.tag == blowableTag)
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * windSpeed);
        }
    }
}
