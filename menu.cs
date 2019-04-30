using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{

AudioSource m_MyAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
Touch touch = Input.GetTouch(0);
Vector2 pos = touch.position;
if ((pos.x >= 0) && (pos.x <= 1000) && (pos.y >= 0) && (pos.y <= 3000)) { //CHANGED 2
m_MyAudioSource = GetComponent<AudioSource>();
m_MyAudioSource.Stop();
var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
vp.Stop();

}
    }
}
