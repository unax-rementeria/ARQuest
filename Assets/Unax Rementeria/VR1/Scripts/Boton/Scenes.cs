using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void LoadSceneFacil()
    {
        SceneManager.LoadScene("Sencillo");
    }

    public void LoadSceneDificl()
    {
        SceneManager.LoadScene("Comlplejo");
    }
    
    public void LoadSceneExtra()
    {
        SceneManager.LoadScene("Extra");
    }
}
