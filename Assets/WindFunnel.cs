using UnityEngine;
using System.Collections;

public class WindFunnel : MonoBehaviour {

    public GameObject blowCone;

    [SerializeField]
    float coneRadiusMultiplier = 0.5f;
    [SerializeField]
    float coneLengthMultiplier = 1f;

    private float blowStrength = 0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Alpha1))
        {
            blowStrength = 1f;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            blowStrength = 2f;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            blowStrength = 3f;
        }


        if (Input.GetKey(KeyCode.Space))
        {
            ModifyCone(blowStrength);
            blowCone.SetActive(true);
        }
        else
        {
            blowCone.SetActive(false);
        }
	}

    void ModifyCone(float newBlowStrength)
    {
        Vector3 newScale = new Vector3(newBlowStrength * coneRadiusMultiplier, newBlowStrength * coneRadiusMultiplier, newBlowStrength * coneLengthMultiplier);
        blowCone.transform.localScale = newScale;
    }

}
