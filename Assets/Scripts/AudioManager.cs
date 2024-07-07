using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----------Audio Sources----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("----------Audio Clip----------")]
    public AudioClip background;    
    //public AudioClip backgroundOverworld;    
    //public AudioClip backgroundCave;    
    public AudioClip enemyDeath;  
    public AudioClip playerAttack1;
    public AudioClip enemyAttack;   
    public AudioClip hit;
    public AudioClip jump;
    //public AudioClip healthPickup;
    public AudioClip correctButton;
    public AudioClip wrongButton;
    public AudioClip klikButton;
    public AudioClip teleport;
    public AudioClip openRock;
    public AudioClip playerRun;
    


    private void Start()
    {
        musicSource.clip = background;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
