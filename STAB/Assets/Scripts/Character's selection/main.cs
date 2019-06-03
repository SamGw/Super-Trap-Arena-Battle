using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    public static int numberOfPlayers  ;
    public static string SceneName;
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

    public void replay()
    {
        SceneManager.LoadScene((1));
    }

    public void menu()
    {
        SceneManager.LoadScene((0));
    }

    public AudioMixer audio;
    public void VolumeSlider(float volume)
    {
        audio.SetFloat("volume", volume);
        
    }

    public void Simplet()
    {
        SceneName = "Brawl Scene";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Volcano()
    {
        SceneName = "Volcano";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Tetris()
    {
        SceneName = "Tetris Scene";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
