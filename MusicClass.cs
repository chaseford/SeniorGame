using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicClass : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }

    public void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "YouWin")

        {
            StopMusic();
            if (!_audioSource.isPlaying)
            {
                _audioSource.Play();
            }
        }

       if(sceneName == "You Lose")

        {
            StopMusic();

            if(!_audioSource.isPlaying)
            {
                _audioSource.Play();
            }
        }

    }

}
