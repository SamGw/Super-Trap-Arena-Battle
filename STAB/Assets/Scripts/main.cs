using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    public static int numberOfPlayers  ;
    public void scene_change()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void back_scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void choose_player1()
    {
        numberOfPlayers = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void choose_player2()
    {
        numberOfPlayers = 2;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void choose_player3()
    {
        numberOfPlayers = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void choose_player4()
    {
        numberOfPlayers = 4;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void exit_game()
    {
        Application.Quit();
    }
}
