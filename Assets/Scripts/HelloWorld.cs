using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour
{
		string currentRoom = "Lobby";
		// Use this for initialization
		void Start ()
		{
				Debug.Log ("Waddup world");
		}
	
		// Update is called once per frame
		void Update ()
		{
				GetComponent<TextMesh> ().text = "Waddup World, Forever";
				if (currentRoom == "Lobby") {
						GetComponent<TextMesh> ().text += "\nYo world, you in da lobby.";
						GetComponent<TextMesh> ().text += "\nPress F ta go to my Hood.";

						if (Input.GetKeyDown (KeyCode.F)) {
								currentRoom = "myHood";
						}
						
				} else if (currentRoom == "myHood") {
						GetComponent<TextMesh> ().text += "\nWelcome to my Hood Homie.";
						GetComponent<TextMesh> ().text += "\nYou gotta pay to spend a day up in my projects!";
						GetComponent<TextMesh> ().text += "\nPress P to go to ProjectsPayPal.";

						if (Input.GetKeyDown (KeyCode.P)) {
								currentRoom = "myProjects";
						}
				} else if (currentRoom == "myProjects") {
						GetComponent<TextMesh> ().text += "\nWelcome to da Projects!";
						GetComponent<TextMesh> ().text += "\nGive me deem ducets.";
						GetComponent<TextMesh> ().text += "\nPress B to come up off that cash.";

						if (Input.GetKeyDown (KeyCode.B)) {
								currentRoom = "myBad";
						}	

				} else if (currentRoom == "myBad") {
						GetComponent<TextMesh> ().text += "\nYo, now I feel bad for robbin you!";
						GetComponent<TextMesh> ().text += "\nHere's some mixtapes to go sell.";
						GetComponent<TextMesh> ().text += "\nPress M to go sell your MixTapes.";
		
						if (Input.GetKeyDown (KeyCode.M)) {
								currentRoom = "myHustle";
						}	
		
				} else if (currentRoom == "myHustle") {
						GetComponent<TextMesh> ().text += "\nWanna here my Rap Demo Homie?";
						GetComponent<TextMesh> ().text += "\nYou Did It! Your Hustlin the streets!";
						GetComponent<TextMesh> ().text += "\nOh Snap, here come 5/0 To Be Continued...";
			
				}
		}		
}
	