using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageReset : MonoBehaviour {
    
    public void Reset()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);

        
    }
}
