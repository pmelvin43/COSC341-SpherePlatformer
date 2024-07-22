using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsDisplay : MonoBehaviour {
    // Start is called before the first frame update

    public static int points = 0;
    public Text pointsText;

    void Start() {

    }

    // Update is called once per frame
    void Update() {

        pointsText.text = "POINTS: " + points;

    }

    public static void addPoint() {
        points++;
    }

    public static void minusPoint() {
        points--;
    }

}
