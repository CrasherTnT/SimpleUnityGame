using UnityEngine;
using UnityEngine.UI; //To access UI of Unity Engin e.g(Text)

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public string[] wordList = new string[10] {
    "HA","HAHA","HAHAHA","HAHAHAHA","HAHAHAHDICK","HAHAHATDOG","HAHADOG","HAHADICK","HAHALOL","HAHAHALODICK",};
    
	// Update is called once per frame
	void Update () {
        scoreText.text = player.position.z.ToString("0") ;
	}
}
