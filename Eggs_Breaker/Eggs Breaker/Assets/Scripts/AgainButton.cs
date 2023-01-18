using UnityEngine;
using UnityEngine.SceneManagement;

public class AgainButton : MonoBehaviour
{
    public void LoadPreviousScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex - 1);
    }
}

