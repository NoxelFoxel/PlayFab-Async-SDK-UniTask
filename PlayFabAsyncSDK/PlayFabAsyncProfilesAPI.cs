using Cysharp.Threading.Tasks;
using PlayFab;
using PlayFab.ProfilesModels;

namespace Code.PlayFabAsyncSDK
{
	public class PlayFabAsyncProfilesAPI
	{
		public static UniTask<PlayFabAsyncResult<GetGlobalPolicyResponse>> GetGlobalPolicyAsync(GetGlobalPolicyRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetGlobalPolicyResponse>> tcs = new();

			PlayFabProfilesAPI.GetGlobalPolicy
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetGlobalPolicyResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetGlobalPolicyResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetEntityProfileResponse>> GetProfileAsync(GetEntityProfileRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetEntityProfileResponse>> tcs = new();

			PlayFabProfilesAPI.GetProfile
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetEntityProfileResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetEntityProfileResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetEntityProfilesResponse>> GetProfilesAsync(GetEntityProfilesRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetEntityProfilesResponse>> tcs = new();

			PlayFabProfilesAPI.GetProfiles
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetEntityProfilesResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetEntityProfilesResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse>>
			GetTitlePlayersFromMasterPlayerAccountIdsAsync(GetTitlePlayersFromMasterPlayerAccountIdsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse>> tcs = new();

			PlayFabProfilesAPI.GetTitlePlayersFromMasterPlayerAccountIds
			(
				request,
				result => { tcs.TrySetResult(new PlayFabAsyncResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetTitlePlayersFromProviderIDsResponse>> GetTitlePlayersFromXboxLiveIDsAsync(
			GetTitlePlayersFromXboxLiveIDsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetTitlePlayersFromProviderIDsResponse>> tcs = new();

			PlayFabProfilesAPI.GetTitlePlayersFromXboxLiveIDs
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetTitlePlayersFromProviderIDsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetTitlePlayersFromProviderIDsResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<SetGlobalPolicyResponse>> SetGlobalPolicyAsync(SetGlobalPolicyRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<SetGlobalPolicyResponse>> tcs = new();

			PlayFabProfilesAPI.SetGlobalPolicy
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<SetGlobalPolicyResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<SetGlobalPolicyResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<SetProfileLanguageResponse>> SetProfileLanguageAsync(SetProfileLanguageRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<SetProfileLanguageResponse>> tcs = new();

			PlayFabProfilesAPI.SetProfileLanguage
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<SetProfileLanguageResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<SetProfileLanguageResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<SetEntityProfilePolicyResponse>> SetProfilePolicyAsync(
			SetEntityProfilePolicyRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<SetEntityProfilePolicyResponse>> tcs = new();

			PlayFabProfilesAPI.SetProfilePolicy
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<SetEntityProfilePolicyResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<SetEntityProfilePolicyResponse>(null, error)); }
			);

			return tcs.Task;
		}
	}
}
