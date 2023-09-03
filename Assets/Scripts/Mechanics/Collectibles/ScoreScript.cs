using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public static int scoreval = 0;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    private void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreval;
    }
}
