using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreTracker : MonoBehaviour {

    public Camera cam;

    private Text textField;
    private string currentScore = "0";
    private GameManager gameManager;

    void Awake()
    {
        textField = GetComponent<Text>();
        gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
    }

    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }

        if (cam != null)
        {
            // Tie this to the camera, and do not keep the local orientation.
            transform.SetParent(cam.GetComponent<Transform>(), true);
        }
    }

    // Update is called once per frame
    void Update () {
        currentScore = gameManager.GetComponent<GameManager>().GetCurrentPoints().ToString();
        textField.text = "Score: " + currentScore;
	}
}
