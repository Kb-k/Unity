/// <summary>
/// Provides controls for playback of frame data.
/// </summary>
public interface IPlaybackController {

    void Play();

    void Pause();

    void Rewind();

    void Forward();
}
