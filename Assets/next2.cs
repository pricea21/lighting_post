using UnityEngine;
using UnityEngine.SceneManagement;

public class next2 : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}