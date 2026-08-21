using UnityEngine;
using UnityEngine.SceneManagement;
public class MainM : MonoBehaviour
{

    public void Startgame()
    {


        SceneManager.LoadScene("scene01");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
