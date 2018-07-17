using UnityEngine;
using System.Collections;

public class LevelMaanager : MonoBehaviour {

public void LoadLevel(string game)
		{
		Debug.Log("Request level:" +game);
		Application.LoadLevel(game);
		}
public void QuitRequest ()
		{
		Debug.Log(" I want to QUIT !! ");
		Application.Quit();
		}
}
