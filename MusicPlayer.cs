using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
public static MusicPlayer instance = null; 
	
	void Start () 
	{
	if(instance != null)
	{
	Destroy (gameObject);
	print ("music player self destructs");
	}
	else
	{
	instance = this;
	GameObject.DontDestroyOnLoad(gameObject);
	}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
