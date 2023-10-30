using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject TMPgoRef =  GameObject.Find("Bombe");
        TextMeshProUGUI r = TMPgoRef.GetComponent<TextMeshProUGUI>();

        r.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
