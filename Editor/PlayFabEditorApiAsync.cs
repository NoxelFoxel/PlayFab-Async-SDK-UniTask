using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using PlayFab.PfEditor;
using PlayFab.PfEditor.EditorModels;

namespace PlayFabAsyncSDKUniTask.Editor
{
	public static class PlayFabEditorApiAsync
	{
		public static async UniTask<RegisterAccountResult> RegisterAccountAsync(RegisterAccountRequest request)
		{
			return await MakeApiCallAsync<RegisterAccountRequest, RegisterAccountResult>
				("/DeveloperTools/User/RegisterAccount", PlayFabEditorHelper.DEV_API_ENDPOINT, request);
		}

		public static async UniTask<LoginResult> LoginAsync(LoginRequest request)
		{
			return await MakeApiCallAsync<LoginRequest, LoginResult>
				("/DeveloperTools/User/Login", PlayFabEditorHelper.DEV_API_ENDPOINT, request);
		}

		public static async UniTask<LoginResult> LoginWithAADAsync(LoginWithAADRequest request)
		{
			return await MakeApiCallAsync<LoginWithAADRequest, LoginResult>
				("/DeveloperTools/User/LoginWithAAD", PlayFabEditorHelper.DEV_API_ENDPOINT, request);
		}

		public static async UniTask<LogoutResult> LogoutAsync(LogoutRequest request)
		{
			return await MakeApiCallAsync<LogoutRequest, LogoutResult>
				("/DeveloperTools/User/Logout", PlayFabEditorHelper.DEV_API_ENDPOINT, request);
		}

		public static async UniTask<GetStudiosResult> GetStudiosAsync(GetStudiosRequest request)
		{
			string token = PlayFabEditorPrefsSO.Instance.DevAccountToken;
			request.DeveloperClientToken = token;

			return await MakeApiCallAsync<GetStudiosRequest, GetStudiosResult>
				("/DeveloperTools/User/GetStudios", PlayFabEditorHelper.DEV_API_ENDPOINT, request);
		}

		public static async UniTask<RegisterAccountResult> CreateTitleAsync(CreateTitleRequest request)
		{
			string token = PlayFabEditorPrefsSO.Instance.DevAccountToken;
			request.DeveloperClientToken = token;

			return await MakeApiCallAsync<CreateTitleRequest, RegisterAccountResult>
				("/DeveloperTools/User/CreateTitle", PlayFabEditorHelper.DEV_API_ENDPOINT, request);
		}

		public static async UniTask<GetTitleDataResult> GetTitleDataAsync()
		{
			string titleId = PlayFabEditorDataService.SharedSettings.TitleId;
			string apiEndpoint = GetApiEndpoint(titleId);

			return await MakeApiCallAsync<GetTitleDataRequest, GetTitleDataResult>
				("/Admin/GetTitleData", apiEndpoint, new GetTitleDataRequest());
		}

		public static async UniTask<SetTitleDataResult> SetTitleDataAsync(Dictionary<string, string> keys)
		{
			string titleId = PlayFabEditorDataService.SharedSettings.TitleId;
			string apiEndpoint = GetApiEndpoint(titleId);

			foreach (KeyValuePair<string, string> pair in keys)
			{
				SetTitleDataRequest req = new() { Key = pair.Key, Value = pair.Value };
				await MakeApiCallAsync<SetTitleDataRequest, SetTitleDataResult>("/Admin/SetTitleData", apiEndpoint, req);
			}

			return new SetTitleDataResult();
		}

		public static async UniTask<GetTitleDataResult> GetTitleInternalDataAsync()
		{
			string titleId = PlayFabEditorDataService.SharedSettings.TitleId;
			string apiEndpoint = GetApiEndpoint(titleId);

			return await MakeApiCallAsync<GetTitleDataRequest, GetTitleDataResult>
				("/Admin/GetTitleInternalData", apiEndpoint, new GetTitleDataRequest());
		}

		public static async UniTask<SetTitleDataResult> SetTitleInternalDataAsync(Dictionary<string, string> keys)
		{
			string titleId = PlayFabEditorDataService.SharedSettings.TitleId;
			string apiEndpoint = GetApiEndpoint(titleId);

			foreach (KeyValuePair<string, string> pair in keys)
			{
				SetTitleDataRequest req = new() { Key = pair.Key, Value = pair.Value };
				await MakeApiCallAsync<SetTitleDataRequest, SetTitleDataResult>("/Admin/SetTitleInternalData", apiEndpoint, req);
			}

			return new SetTitleDataResult();
		}

		public static async UniTask<UpdateCloudScriptResult> UpdateCloudScriptAsync(UpdateCloudScriptRequest request)
		{
			string titleId = PlayFabEditorDataService.SharedSettings.TitleId;
			string apiEndpoint = GetApiEndpoint(titleId);

			return await MakeApiCallAsync<UpdateCloudScriptRequest, UpdateCloudScriptResult>
				("/Admin/UpdateCloudScript", apiEndpoint, request);
		}

		public static async UniTask<GetCloudScriptRevisionResult> GetCloudScriptRevisionAsync(GetCloudScriptRevisionRequest request)
		{
			string titleId = PlayFabEditorDataService.SharedSettings.TitleId;
			string apiEndpoint = GetApiEndpoint(titleId);

			return await MakeApiCallAsync<GetCloudScriptRevisionRequest, GetCloudScriptRevisionResult>
				("/Admin/GetCloudScriptRevision", apiEndpoint, request);
		}


		private static string GetApiEndpoint(string titleId)
		{
			return $"https://{titleId}{PlayFabEditorHelper.TITLE_ENDPOINT}";
		}

		private static async UniTask<TResultType> MakeApiCallAsync<TRequestType, TResultType>(
			string api, string apiEndpoint, TRequestType request) where TResultType : class
		{
			UniTaskCompletionSource<TResultType> tcs = new();

			PlayFabEditorHttp.MakeApiCall<TRequestType, TResultType>
			(
				api, apiEndpoint, request, resultCallback : result => tcs.TrySetResult(result),
				errorCallback : error => tcs.TrySetException(new Exception(error.ErrorMessage))
			);

			try
			{
				return await tcs.Task;
			}
			catch (Exception e)
			{
				UnityEngine.Debug.LogError($"API call failed: {e.Message}");

				throw;
			}
		}
	}
}
