using UnityEngine;
using System.Collections;

public class SoundAble : MonoBehaviour {

    public GameObject micController;

	// Use this for initialization
	void Start () {
        // micController = FindObjectOfType<MicControlC>().gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        float loudness = micController.GetComponent<MicControlC>().loudness;

        transform.localScale = new Vector3(loudness*100,loudness * 100, loudness * 100);
    }
}
