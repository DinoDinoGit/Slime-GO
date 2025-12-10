using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Função pública que pode ser chamada pelo botão
    public void LoadScene(string Game)
    {
        SceneManager.LoadScene(Game);
    }

    // Ou uma versão simples sem parâmetro, se quiser fixar a cena:
    public void LoadNextScene()
    {
        SceneManager.LoadScene("Game");
    }
}
