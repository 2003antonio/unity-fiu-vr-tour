using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class MetaXRVideoControls : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public Slider volumeSlider;
    public Slider scrubSlider; // optional: hook to video time
    public Toggle playToggle;

    public void PlayVideo()
    {
        if (videoPlayer != null)
            videoPlayer.Play();
    }

    public void PauseVideo()
    {
        if (videoPlayer != null)
            videoPlayer.Pause();
    }

    public void TogglePlayPause(bool isPlaying)
    {
        if (videoPlayer == null) return;

        if (isPlaying) videoPlayer.Play();
        else videoPlayer.Pause();
    }

    public void SkipForward()
    {
        if (videoPlayer != null && videoPlayer.canSetTime)
            videoPlayer.time += 10.0f; // Cast as float to avoid CS1503
    }

    public void SkipBackward()
    {
        if (videoPlayer != null && videoPlayer.canSetTime)
            videoPlayer.time = Mathf.Max((float)(videoPlayer.time - 10.0f), 0f); // cast to float here
    }

    public void SetVolume(float value)
    {
        if (videoPlayer != null)
            videoPlayer.SetDirectAudioVolume(0, Mathf.Clamp01(value));
    }

    public void SyncSliderToTime()
    {
        if (videoPlayer != null && scrubSlider != null && videoPlayer.length > 0)
            scrubSlider.value = (float)(videoPlayer.time / videoPlayer.length);
    }

    public void ScrubToTime(float sliderValue)
    {
        if (videoPlayer != null && videoPlayer.length > 0)
            videoPlayer.time = sliderValue * videoPlayer.length;
    }
}
