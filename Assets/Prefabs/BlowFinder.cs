using UnityEngine;
using System.Collections;

public class BlowFinder : MonoBehaviour {

    AudioSource src;
    bool runOnce;

    // Use this for initialization
    void Start () {
	
        runOnce = true;
	}
	
	// Update is called once per frame
	void Update () {


        while (runOnce)
        {
            runOnce = true;
            src = GetComponent<AudioSource>();

            float[] samples = new float[src.clip.samples * src.clip.channels];
            src.clip.GetData(samples, 0);
            //print(samples);
            /*int i = 0;
            while (i < samples.Length)
            {
                samples[i] = samples[i] * 0.5F;
                ++i;
            }
            src.clip.SetData(samples, 0);*/
        }

    }
}
