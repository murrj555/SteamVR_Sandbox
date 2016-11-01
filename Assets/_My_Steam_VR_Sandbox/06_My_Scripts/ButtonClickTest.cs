//import statements

using UnityEngine;
using System.Collections;
using UnityEngine.UI; // for UI
using UnityEngine.SceneManagement; // for loading scenes


public class ButtonClickTest : MonoBehaviour {

    //toogle boolean
    public Toggle isVR;

    public InputField playerInputField;
    public int count = 10;

    public void Click_Test(){

		Debug.Log("Clicked Button! :)");
	}

    //load the Game Lose Screen Level
    public void Record_Player_Number()
    {

        Debug.Log("You Win, Load Win Screen");

        // Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
        //LoadSceneMode.Single = Delete Old Scene Load New Scene
        //LoadSceneMode.Single = Load New Scene On Top of New Scene
        PersistentDataWriter.PDWriter.playerNumber = +1;


    }

    //load the Game Lose Screen Level
    public void Correct_Awnser(){

		Debug.Log("You Win, Load Win Screen");

		// Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
		//LoadSceneMode.Single = Delete Old Scene Load New Scene
		//LoadSceneMode.Single = Load New Scene On Top of New Scene
        SceneManager.LoadScene ("Win_Screen_JJM", LoadSceneMode.Single);

	}

    public void Pause_Options()
    {

        Debug.Log("Pressed Options Button.");

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

    //pass trial
    public void Pass_Trial_Keyboard_Mouse()
    {
        Debug.Log("Pass Trial!");
    }

    //go to Tutorial Keyboard Mouse Level
    public void ActiveToggle()
    {
        Debug.Log("Pressed Submit Button, Load Active Toggle");

        if (isVR.isOn)
        {
            Debug.Log("Toggled is true!");

            //when pressed submit button should change to load VR level not the 3D version
            SceneManager.LoadScene("03_Start_Screen_VR_JJM", LoadSceneMode.Single);

            //add VR Version String entry here, if true say VR Version, if not 3D Version
            PersistentDataWriter.PDWriter.version = "VR Version!";

        }
        else
        {
            Debug.Log("Toggled is false!");
            SceneManager.LoadScene("03_How_To_Play_The_Game_Keyboard_Mouse_JJM", LoadSceneMode.Single);
            
            //if false print 3D Version to String
            PersistentDataWriter.PDWriter.version = "3D Version!";
        }

    }

    //go to Tutorial Keyboard Mouse Level
    public void OnSubmitButton()
    {
        ActiveToggle();
    }

    //pass trial
    public void Next_Go_To_Tell_Me_How_To_Play_Game_Mouse_Keyboard()
    {
       
        Debug.Log("Pressed Next on How to Play The Game Level!");
        
    }

    //pass trial
    public void Next_Go_To_How_To_Play_Game_Mouse_Keyboard()
    {
        Debug.Log("Pressed Next on How to Play The Game Level!");
        SceneManager.LoadScene("03_How_To_Play_The_Game_Keyboard_Mouse_JJM", LoadSceneMode.Single);

    }

    //submit subject number entry and load start screen
    //I have to have a script that records all the data starting from here. It has to record from scene to scene.
    //Aldi said that we already have a unity project package that does this somewhere. Its is probably in the Memsplosion unity project.
    public void Start_Screen(){

        /*Add simple if statement here. "if clicked vr version and press submit, load VR Room scale level next"*/

        Debug.Log("Submit Subject Number Entry and Load Start Screen!");
		// Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
		//LoadSceneMode.Single = Delete Old Scene Load New Scene
		//LoadSceneMode.Single = Load New Scene On Top of New Scene
        SceneManager.LoadScene ("02_Input_Subject_Splash_Screen_JJM", LoadSceneMode.Single);
	}

    public void Input_Player()
    {


        playerInputField.text = "Enter Text Here..." + count.ToString();
    }


}
