using UnityEngine;
using System.Collections;

public class Program : MonoBehaviour {

	public GameObject ActorPanel;
	public GameObject ChuckPanel;

	public void ActorPanel_Show () {
		ActorPanel.SetActive (true);
	}
	public void ActorPanel_Hide () {
		ActorPanel.SetActive (false);
	}
	public void ActorPanel_Toggle () {
		if (ActorPanel.activeSelf)
			ActorPanel.SetActive (false);
		else
			ActorPanel.SetActive (true);
	}

	public void ChuckPanel_Show () {
		ChuckPanel.SetActive (true);
	}
	public void ChuckPanel_Hide () {
		ChuckPanel.SetActive (false);
	}
	public void ChuckPanel_Toggle () {
		if (ChuckPanel.activeSelf)
			ChuckPanel.SetActive (false);
		else
			ChuckPanel.SetActive (true);
	}

	// Use this for initialization
	void Start () {
		ActorPanel_Hide ();
		ChuckPanel_Hide ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			Application.Quit(); 
		}
	}
}
