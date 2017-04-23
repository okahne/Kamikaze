using UnityEngine;
using System.Collections;

public class WindFunnel : MonoBehaviour {

    public GameObject blowCone;
    private MicControlC micControlC;

    [SerializeField]
    float coneRadiusMultiplier;
    [SerializeField]
    float coneLengthMultiplier;

    const int blowAbleAmounts = 32;
    private float blowStrength;
    private float[] windArray = new float[blowAbleAmounts];
    int frame = 0;

    // Use this for initialization
    void Start () {

        micControlC = FindObjectOfType<MicControlC>().GetComponent<MicControlC>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        UpdateBlowStrength();
        ModifyCone(blowStrength);
    }

    private void UpdateBlowStrength()
    {
        var newLoudness = micControlC.loudness;
        windArray[frame] = newLoudness;
        frame = ++frame % blowAbleAmounts;
        blowStrength = 0;
        foreach (var item in windArray)
        {
            blowStrength += item / blowAbleAmounts;
        }
    }

    public float GetCurrentWindSpeed()
    {
        // TODO Need to tweak
        return blowStrength * coneLengthMultiplier * 5;
    }

    void ModifyCone(float newBlowStrength)
    {
        Vector3 newScale = new Vector3(newBlowStrength * coneRadiusMultiplier, newBlowStrength * coneRadiusMultiplier, newBlowStrength  * coneLengthMultiplier);
        blowCone.transform.localScale = newScale;
    }

}
