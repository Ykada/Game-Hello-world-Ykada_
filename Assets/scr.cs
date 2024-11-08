using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scr : MonoBehaviour
{
    // Start is called before the first frame update
    public Text _fpsText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int fps = (int)(1f / Time.deltaTime);
        _fpsText.text = "FPS: " + fps;
    }
}
