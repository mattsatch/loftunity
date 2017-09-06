using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounder : MonoBehaviour {
    public AudioClip clip;
    const int size = 10;
    public AudioSource[] sources = new AudioSource[size];
	// Use this for initialization
	void Start () {
		for(int i=0; i<size; i++)
        {
            var obj = new GameObject();
            var src = obj.AddComponent<AudioSource>();
            sources[i] = src;
            obj.transform.parent = this.transform;
            obj.transform.localPosition = new Vector3(Random.value, Random.value, Random.value)-Vector3.one*0.5f;
            src.clip = clip;
            src.spatialize = true;
            src.spatialBlend = 1f;
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=0; i<size; i++)
        {
            if (Random.value > 0.99 && !sources[i].isPlaying)
            {
                sources[i].Play();
            }
        }
	}
}
