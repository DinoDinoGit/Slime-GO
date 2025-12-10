using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBack : MonoBehaviour
{
    public void GoBack()
    {
        // Pega o índice da cena atual
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Verifica se existe uma cena anterior
        if (currentSceneIndex > 0)
        {
            SceneManager.LoadScene(currentSceneIndex - 1);
        }
        else
        {
            Debug.LogWarning("Não há cena anterior para voltar!");
        }
    }
}
