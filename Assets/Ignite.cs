using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Ignite : MonoBehaviour {

    public AudioClip explosionSound;
    public GameObject explosion;

    private AudioSource audioSource;
    private string buildingTag = "Blowable";

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
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            other.gameObject.GetComponent<Building>().SetOnFire();
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
