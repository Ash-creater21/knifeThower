using UnityEngine;
using UnityEngine.SceneManagement ; 


public class SceneTransition : MonoBehaviour
{
  public void  SetScene(string sceneName) 
   {
    
    SceneManager.LoadScene(sceneName);
   }
}
