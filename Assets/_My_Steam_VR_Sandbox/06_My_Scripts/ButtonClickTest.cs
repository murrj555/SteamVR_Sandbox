//import statements

using UnityEngine;
using System.Collections;
using UnityEngine.UI; // for UI
using UnityEngine.SceneManagement; // for loading scenes


//
public class ButtonClickTest : MonoBehaviour {

	public void Click_Test(){

		Debug.Log("Clicked Button! :)");
	}

	//load the Game Lose Screen Level
	public void Correct_Awnser(){

		Debug.Log("You Win, Load Win Screen");

		// Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
		//LoadSceneMode.Single = Delete Old Scene Load New Scene
		//LoadSceneMode.Single = Load New Scene On Top of New Scene
        SceneManager.LoadScene ("Win_Screen_JJM", LoadSceneMode.Single);

	}

	//load the Game Lose Screen Level
	public void Wrong_Awnser(){

		Debug.Log("You Lose, Load Lose Screen");
		// Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
		//LoadSceneMode.Single = Delete Old Scene Load New Scene
		//LoadSceneMode.Single = Load New Scene On Top of New Scene
        SceneManager.LoadScene ("Lose_Screen_JJM", LoadSceneMode.Single);
	}

	//replay and load the Stimuli Keyboard and Mouse Level
	public void Replay_Stimuli_Keyboard_Mouse(){

		Debug.Log("Replay Stimuli Keyboard Mouse Level");
		// Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
		//LoadSceneMode.Single = Delete Old Scene Load New Scene
		//LoadSceneMode.Single = Load New Scene On Top of New Scene
        SceneManager.LoadScene ("Stimuli_Keyboard_Mouse_JJM", LoadSceneMode.Single);
	}

	//start the Stimuli Keyboard and Mouse Level
	public void Start_Stimuli_Keyboard_Mouse(){

		Debug.Log("Start Game!");
		// Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
		//LoadSceneMode.Single = Delete Old Scene Load New Scene
		//LoadSceneMode.Single = Load New Scene On Top of New Scene
        SceneManager.LoadScene ("Stimuli_Keyboard_Mouse_JJM", LoadSceneMode.Single);
	}

	//start the Stimuli Keyboard and Mouse Level
	public void Start_Stimuli_Model_3D_Scene_JJM(){

		Debug.Log("Start Stimuli 3D Char Level!");
		// Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
		//LoadSceneMode.Single = Delete Old Scene Load New Scene
		//LoadSceneMode.Single = Load New Scene On Top of New Scene
        SceneManager.LoadScene ("Stimuli_Model_3D_Scene_JJM", LoadSceneMode.Single);
	}

	//quit game
	public void Quit_Stimuli_Keyboard_Mouse(){

		Debug.Log("Quit Game!");
		//quits application
        Application.Quit();
	}

	//submit subject number entry and load start screen
	//I have to have a script that records all the data starting from here. It has to record from scene to scene.
	//Aldi said that we already have a unity project package that does this somewhere. Its is probably in the Memsplosion unity project.
	public void Enter_Subject_Number_Input(){

		Debug.Log("Submit Subject Number Entry and Load Start Screen!");
		// Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
		//LoadSceneMode.Single = Delete Old Scene Load New Scene
		//LoadSceneMode.Single = Load New Scene On Top of New Scene
        SceneManager.LoadScene ("Start_Screen_JJM", LoadSceneMode.Single);
	}



}
