using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void AbrirCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}