using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
vp.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
