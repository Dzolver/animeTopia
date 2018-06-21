using UnityEngine;
using UnityEngine.UI;

public class ChatInputField : MonoBehaviour {
	public ChatterManager chatManager;
	private InputField inputField;

	private void Start(){
		inputField = GetComponent<InputField>();
		//GameObject thePlayer = GameObject.Find ("characterObject");
		//playerSC playerscript = thePlayer.GetComponent<playerSC> ();
	}
	public void ValueChanged(){
		if (inputField.text.Contains ("\n"))
			chatManager.WriteMessage (inputField);
	}
	private void Update(){
		GameObject thePlayer = GameObject.Find ("characterObject");
		if (inputField.isFocused) {
			thePlayer.GetComponent<playerSC>()._move = false;	
		}
	}
}
