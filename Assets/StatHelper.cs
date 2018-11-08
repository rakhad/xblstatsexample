using UnityEngine;

using Microsoft.Xbox.Services;
using Microsoft.Xbox.Services.Client;

public class StatHelper : MonoBehaviour
{
    internal XboxLiveUser xboxLiveUser;

    public void FlushStatsUsingStatsManager()
    {
        if (this.xboxLiveUser == null)
        {
            this.xboxLiveUser = SignInManager.Instance.GetPlayer(1);
        }

        XboxLive.Instance.StatsManager.RequestFlushToService(this.xboxLiveUser, true);
    }

    public void FlushStatsUsingStatsManagerComponent()
    {
        if (this.xboxLiveUser == null)
        {
            this.xboxLiveUser = SignInManager.Instance.GetPlayer(1);
        }

        StatsManagerComponent.Instance.RequestFlushToService(this.xboxLiveUser, true);
    }
}
