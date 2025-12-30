using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIController : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void FecharJogo()
    {
        Application.Quit();
    }
}
