using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HelpTips : MonoBehaviour

{		
		// I have no idea on earth my this works, and also why it needs an empty class???
		[TextArea]
		public string READ_ME;
		public string HELP_URL;
		[HelpURL("http://example.com/docs/MyComponent.html")]

		public class MyComponent
		{

		}


}