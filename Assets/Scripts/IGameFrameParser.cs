using UnityEngine;
using System.Collections;

public interface IGameFrameParser  {

    GameFrame[] GetGameFramesFromString(string str);
}
