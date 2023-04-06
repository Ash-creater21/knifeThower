using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ; 

public class GameManager : MonoBehaviour
{
    public bool isDead; 
    public int score = 0 ; 
    public Text scoreText ; 

    public SceneTransition sc ; 
    // Start is called before the first frame update
   
    public void setScore() 
    {
        score+=1 ; 
    }
    
    private void Update() 
    {
        Debug.Log(score); 
        if(isDead==false)  
        {
            sc.SetScene("GameOver");
        }
        scoreText.text = score.ToString() + "Points" ; 
    }
}
