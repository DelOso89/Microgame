using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Jugar()
    {
        Nave.Score=0;
        SceneManager.LoadScene("InGame");
    }
}
