using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DistanceToCP : MonoBehaviour
{

    public GameObject player;
    public GameObject checkPoint;
    public float distance;
    public TextMeshProUGUI distText;

    // Start is called before the first frame update
    void Start()
    {

    }

    void setCountText()
    {
        distText.text = "Distance to Block: " + distance.ToString("F2");
    }
    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, checkPoint.transform.position);
        setCountText();
    }
}
