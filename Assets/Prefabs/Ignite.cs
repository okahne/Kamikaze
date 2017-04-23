using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Ignite : MonoBehaviour {

    public AudioClip explosionSound;
    public GameObject explosion;

    private AudioSource audioSource;
    private string buildingTag = "Building";

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(buildingTag))
        {
            other.gameObject.GetComponent<Building>().SetOnFire();
            Instantiate(explosion, transform.position,transform.rotation);
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
