using UnityEngine;
using System.Collections;
using System;

public class GamePlaybackController : MonoBehaviour, IPlaybackController
{
    private IGameFrameParser _frameParser;
    private GameFrame[] _frames;
    private int _currFrameIndex;
    private float _secondsPerFrame;
    private float _secondsThisFrame;
    private PlaybackMode _playbackMode = PlaybackMode.Stopped;

    public GameFrame CurrentGameFrame { get; private set; }
    public float PlaybackFPS { get; private set; }

    private enum PlaybackMode
    {
        Playing = 0,
        Paused = 1,
        Rewinding = 2,
        Stopped = 3
    }

	private void Start ()
    {
        _secondsPerFrame = 1 / PlaybackFPS;
        _frameParser = new GameFrameJSONParser();
        _frames = _frameParser.GetGameFramesFromString("");
	}
	
	private void Update ()
    {
        switch (_playbackMode)
        {
            case PlaybackMode.Playing: 
                _secondsThisFrame += Time.deltaTime;
                if (_secondsThisFrame > _secondsPerFrame)
                {
                    PlayNextFrame();
                }
                break;
            case PlaybackMode.Rewinding:
                _secondsThisFrame += Time.deltaTime;
                if (_secondsThisFrame > _secondsPerFrame)
                {
                    PlayPreviousFrame();
                }
                break;
        }
	}

    public void Play()
    {
        throw new NotImplementedException();
    }

    public void Pause()
    {
        throw new NotImplementedException();
    }

    public void Rewind()
    {
        throw new NotImplementedException();
    }

    public void Forward()
    {
        throw new NotImplementedException();
    }

    private void PlayNextFrame()
    {
        _secondsThisFrame = 0;
        _currFrameIndex++;
    }

    private void PlayPreviousFrame()
    {
        _secondsThisFrame = 0;
        _currFrameIndex--;
    }
}
