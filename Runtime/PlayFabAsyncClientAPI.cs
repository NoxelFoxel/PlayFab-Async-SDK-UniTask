using Cysharp.Threading.Tasks;
using PlayFab;
using PlayFab.ClientModels;

namespace PlayFabAsyncSDKUniTask.Runtime
{
	public static class PlayFabAsyncClientAPI
	{
		public static UniTask<PlayFabAsyncResult<AcceptTradeResponse>> AcceptTradeAsync(AcceptTradeRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<AcceptTradeResponse>> tcs = new();

			PlayFabClientAPI.AcceptTrade
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<AcceptTradeResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<AcceptTradeResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<AddFriendResult>> AddFriendAsync(AddFriendRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<AddFriendResult>> tcs = new();

			PlayFabClientAPI.AddFriend
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<AddFriendResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<AddFriendResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<AddGenericIDResult>> AddGenericIDAsync(AddGenericIDRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<AddGenericIDResult>> tcs = new();

			PlayFabClientAPI.AddGenericID
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<AddGenericIDResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<AddGenericIDResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<AddOrUpdateContactEmailResult>> AddOrUpdateContactEmailAsync(
			AddOrUpdateContactEmailRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<AddOrUpdateContactEmailResult>> tcs = new();

			PlayFabClientAPI.AddOrUpdateContactEmail
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<AddOrUpdateContactEmailResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<AddOrUpdateContactEmailResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<AddSharedGroupMembersResult>> AddSharedGroupMembersAsync(
			AddSharedGroupMembersRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<AddSharedGroupMembersResult>> tcs = new();

			PlayFabClientAPI.AddSharedGroupMembers
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<AddSharedGroupMembersResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<AddSharedGroupMembersResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<AddUsernamePasswordResult>> AddUsernamePasswordAsync(AddUsernamePasswordRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<AddUsernamePasswordResult>> tcs = new();

			PlayFabClientAPI.AddUsernamePassword
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<AddUsernamePasswordResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<AddUsernamePasswordResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrencyAsync(
			AddUserVirtualCurrencyRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ModifyUserVirtualCurrencyResult>> tcs = new();

			PlayFabClientAPI.AddUserVirtualCurrency
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ModifyUserVirtualCurrencyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ModifyUserVirtualCurrencyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<AndroidDevicePushNotificationRegistrationResult>>
			AndroidDevicePushNotificationRegistrationAsync(AndroidDevicePushNotificationRegistrationRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<AndroidDevicePushNotificationRegistrationResult>> tcs = new();

			PlayFabClientAPI.AndroidDevicePushNotificationRegistration
			(
				request,
				result => { tcs.TrySetResult(new PlayFabAsyncResult<AndroidDevicePushNotificationRegistrationResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<AndroidDevicePushNotificationRegistrationResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<AttributeInstallResult>> AttributeInstallAsync(AttributeInstallRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<AttributeInstallResult>> tcs = new();

			PlayFabClientAPI.AttributeInstall
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<AttributeInstallResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<AttributeInstallResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<CancelTradeResponse>> CancelTradeAsync(CancelTradeRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<CancelTradeResponse>> tcs = new();

			PlayFabClientAPI.CancelTrade
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<CancelTradeResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<CancelTradeResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ConfirmPurchaseResult>> ConfirmPurchaseAsync(ConfirmPurchaseRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ConfirmPurchaseResult>> tcs = new();

			PlayFabClientAPI.ConfirmPurchase
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ConfirmPurchaseResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ConfirmPurchaseResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ConsumeItemResult>> ConsumeItemAsync(ConsumeItemRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ConsumeItemResult>> tcs = new();

			PlayFabClientAPI.ConsumeItem
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ConsumeItemResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ConsumeItemResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ConsumeMicrosoftStoreEntitlementsResponse>> ConsumeMicrosoftStoreEntitlementsAsync(
			ConsumeMicrosoftStoreEntitlementsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ConsumeMicrosoftStoreEntitlementsResponse>> tcs = new();

			PlayFabClientAPI.ConsumeMicrosoftStoreEntitlements
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ConsumeMicrosoftStoreEntitlementsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ConsumeMicrosoftStoreEntitlementsResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ConsumePS5EntitlementsResult>> ConsumePS5EntitlementsAsync(
			ConsumePS5EntitlementsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ConsumePS5EntitlementsResult>> tcs = new();

			PlayFabClientAPI.ConsumePS5Entitlements
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ConsumePS5EntitlementsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ConsumePS5EntitlementsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ConsumePSNEntitlementsResult>> ConsumePSNEntitlementsAsync(
			ConsumePSNEntitlementsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ConsumePSNEntitlementsResult>> tcs = new();

			PlayFabClientAPI.ConsumePSNEntitlements
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ConsumePSNEntitlementsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ConsumePSNEntitlementsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ConsumeXboxEntitlementsResult>> ConsumeXboxEntitlementsAsync(
			ConsumeXboxEntitlementsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ConsumeXboxEntitlementsResult>> tcs = new();

			PlayFabClientAPI.ConsumeXboxEntitlements
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ConsumeXboxEntitlementsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ConsumeXboxEntitlementsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<CreateSharedGroupResult>> CreateSharedGroupAsync(CreateSharedGroupRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<CreateSharedGroupResult>> tcs = new();

			PlayFabClientAPI.CreateSharedGroup
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<CreateSharedGroupResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<CreateSharedGroupResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ExecuteCloudScriptResult>> ExecuteCloudScriptAsync(ExecuteCloudScriptRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ExecuteCloudScriptResult>> tcs = new();

			PlayFabClientAPI.ExecuteCloudScript
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ExecuteCloudScriptResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ExecuteCloudScriptResult>(null, error)); }
			);

			return tcs.Task;
		}

		/*
	public static UniTask<PlayFabAsyncResult<TOut>> ExecuteCloudScriptAsync<TOut>(ExecuteCloudScriptRequest request)
	{
		UniTaskCompletionSource<PlayFabAsyncResult<TOut>> tcs = new UniTaskCompletionSource<PlayFabAsyncResult<TOut>>();

		PlayFabClientAPI.ExecuteCloudScript<TOut>(request, result =>
		{
			tcs.TrySetResult(new PlayFabAsyncResult<TOut>(result, null));
		}, error =>
		{
			tcs.TrySetResult(new PlayFabAsyncResult<TOut>(null, error));
		});

		return tcs.UniTask;
	}
	*/
		public static UniTask<PlayFabAsyncResult<GetAccountInfoResult>> GetAccountInfoAsync(GetAccountInfoRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetAccountInfoResult>> tcs = new();

			PlayFabClientAPI.GetAccountInfo
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetAccountInfoResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetAccountInfoResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetAdPlacementsResult>> GetAdPlacementsAsync(GetAdPlacementsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetAdPlacementsResult>> tcs = new();

			PlayFabClientAPI.GetAdPlacements
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetAdPlacementsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetAdPlacementsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ListUsersCharactersResult>> GetAllUsersCharactersAsync(ListUsersCharactersRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ListUsersCharactersResult>> tcs = new();

			PlayFabClientAPI.GetAllUsersCharacters
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ListUsersCharactersResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ListUsersCharactersResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetCatalogItemsResult>> GetCatalogItemsAsync(GetCatalogItemsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetCatalogItemsResult>> tcs = new();

			PlayFabClientAPI.GetCatalogItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetCatalogItemsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetCatalogItemsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetCharacterDataResult>> GetCharacterDataAsync(GetCharacterDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetCharacterDataResult>> tcs = new();

			PlayFabClientAPI.GetCharacterData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetCharacterDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetCharacterDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetCharacterInventoryResult>> GetCharacterInventoryAsync(
			GetCharacterInventoryRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetCharacterInventoryResult>> tcs = new();

			PlayFabClientAPI.GetCharacterInventory
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetCharacterInventoryResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetCharacterInventoryResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetCharacterLeaderboardResult>> GetCharacterLeaderboardAsync(
			GetCharacterLeaderboardRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetCharacterLeaderboardResult>> tcs = new();

			PlayFabClientAPI.GetCharacterLeaderboard
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetCharacterLeaderboardResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetCharacterLeaderboardResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetCharacterDataResult>> GetCharacterReadOnlyDataAsync(GetCharacterDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetCharacterDataResult>> tcs = new();

			PlayFabClientAPI.GetCharacterReadOnlyData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetCharacterDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetCharacterDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetCharacterStatisticsResult>> GetCharacterStatisticsAsync(
			GetCharacterStatisticsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetCharacterStatisticsResult>> tcs = new();

			PlayFabClientAPI.GetCharacterStatistics
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetCharacterStatisticsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetCharacterStatisticsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetContentDownloadUrlResult>> GetContentDownloadUrlAsync(
			GetContentDownloadUrlRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetContentDownloadUrlResult>> tcs = new();

			PlayFabClientAPI.GetContentDownloadUrl
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetContentDownloadUrlResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetContentDownloadUrlResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetLeaderboardResult>> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetLeaderboardResult>> tcs = new();

			PlayFabClientAPI.GetFriendLeaderboard
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetLeaderboardResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetLeaderboardResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetFriendLeaderboardAroundPlayerResult>> GetFriendLeaderboardAroundPlayerAsync(
			GetFriendLeaderboardAroundPlayerRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetFriendLeaderboardAroundPlayerResult>> tcs = new();

			PlayFabClientAPI.GetFriendLeaderboardAroundPlayer
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetFriendLeaderboardAroundPlayerResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetFriendLeaderboardAroundPlayerResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetFriendsListResult>> GetFriendsListAsync(GetFriendsListRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetFriendsListResult>> tcs = new();

			PlayFabClientAPI.GetFriendsList
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetFriendsListResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetFriendsListResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetLeaderboardResult>> GetLeaderboardAsync(GetLeaderboardRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetLeaderboardResult>> tcs = new();

			PlayFabClientAPI.GetLeaderboard
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetLeaderboardResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetLeaderboardResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetLeaderboardAroundCharacterResult>> GetLeaderboardAroundCharacterAsync(
			GetLeaderboardAroundCharacterRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetLeaderboardAroundCharacterResult>> tcs = new();

			PlayFabClientAPI.GetLeaderboardAroundCharacter
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetLeaderboardAroundCharacterResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetLeaderboardAroundCharacterResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetLeaderboardAroundPlayerResult>> GetLeaderboardAroundPlayerAsync(
			GetLeaderboardAroundPlayerRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetLeaderboardAroundPlayerResult>> tcs = new();

			PlayFabClientAPI.GetLeaderboardAroundPlayer
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetLeaderboardAroundPlayerResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetLeaderboardAroundPlayerResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetLeaderboardForUsersCharactersResult>> GetLeaderboardForUserCharactersAsync(
			GetLeaderboardForUsersCharactersRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetLeaderboardForUsersCharactersResult>> tcs = new();

			PlayFabClientAPI.GetLeaderboardForUserCharacters
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetLeaderboardForUsersCharactersResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetLeaderboardForUsersCharactersResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPaymentTokenResult>> GetPaymentTokenAsync(GetPaymentTokenRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPaymentTokenResult>> tcs = new();

			PlayFabClientAPI.GetPaymentToken
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPaymentTokenResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPaymentTokenResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPhotonAuthenticationTokenResult>> GetPhotonAuthenticationTokenAsync(
			GetPhotonAuthenticationTokenRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPhotonAuthenticationTokenResult>> tcs = new();

			PlayFabClientAPI.GetPhotonAuthenticationToken
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPhotonAuthenticationTokenResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPhotonAuthenticationTokenResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayerCombinedInfoResult>> GetPlayerCombinedInfoAsync(
			GetPlayerCombinedInfoRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayerCombinedInfoResult>> tcs = new();

			PlayFabClientAPI.GetPlayerCombinedInfo
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerCombinedInfoResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerCombinedInfoResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayerProfileResult>> GetPlayerProfileAsync(GetPlayerProfileRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayerProfileResult>> tcs = new();

			PlayFabClientAPI.GetPlayerProfile
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerProfileResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerProfileResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayerSegmentsResult>> GetPlayerSegmentsAsync(GetPlayerSegmentsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayerSegmentsResult>> tcs = new();

			PlayFabClientAPI.GetPlayerSegments
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerSegmentsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerSegmentsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayerStatisticsResult>> GetPlayerStatisticsAsync(GetPlayerStatisticsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayerStatisticsResult>> tcs = new();

			PlayFabClientAPI.GetPlayerStatistics
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerStatisticsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerStatisticsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayerStatisticVersionsResult>> GetPlayerStatisticVersionsAsync(
			GetPlayerStatisticVersionsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayerStatisticVersionsResult>> tcs = new();

			PlayFabClientAPI.GetPlayerStatisticVersions
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerStatisticVersionsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerStatisticVersionsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayerTagsResult>> GetPlayerTagsAsync(GetPlayerTagsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayerTagsResult>> tcs = new();

			PlayFabClientAPI.GetPlayerTags
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerTagsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerTagsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayerTradesResponse>> GetPlayerTradesAsync(GetPlayerTradesRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayerTradesResponse>> tcs = new();

			PlayFabClientAPI.GetPlayerTrades
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerTradesResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayerTradesResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromFacebookIDsResult>> GetPlayFabIDsFromFacebookIDsAsync(
			GetPlayFabIDsFromFacebookIDsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromFacebookIDsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromFacebookIDs
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromFacebookIDsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromFacebookIDsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>>
			GetPlayFabIDsFromFacebookInstantGamesIdsAsync(GetPlayFabIDsFromFacebookInstantGamesIdsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromFacebookInstantGamesIds
			(
				request,
				result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromGameCenterIDsResult>> GetPlayFabIDsFromGameCenterIDsAsync(
			GetPlayFabIDsFromGameCenterIDsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromGameCenterIDsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromGameCenterIDs
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromGameCenterIDsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromGameCenterIDsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromGenericIDsResult>> GetPlayFabIDsFromGenericIDsAsync(
			GetPlayFabIDsFromGenericIDsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromGenericIDsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromGenericIDs
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromGenericIDsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromGenericIDsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromGoogleIDsResult>> GetPlayFabIDsFromGoogleIDsAsync(
			GetPlayFabIDsFromGoogleIDsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromGoogleIDsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromGoogleIDs
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromGoogleIDsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromGoogleIDsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult>>
			GetPlayFabIDsFromGooglePlayGamesPlayerIDsAsync(GetPlayFabIDsFromGooglePlayGamesPlayerIDsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromGooglePlayGamesPlayerIDs
			(
				request,
				result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromKongregateIDsResult>> GetPlayFabIDsFromKongregateIDsAsync(
			GetPlayFabIDsFromKongregateIDsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromKongregateIDsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromKongregateIDs
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromKongregateIDsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromKongregateIDsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromNintendoServiceAccountIdsResult>>
			GetPlayFabIDsFromNintendoServiceAccountIdsAsync(GetPlayFabIDsFromNintendoServiceAccountIdsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromNintendoServiceAccountIdsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromNintendoServiceAccountIds
			(
				request,
				result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromNintendoServiceAccountIdsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromNintendoServiceAccountIdsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>>
			GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromNintendoSwitchDeviceIds
			(
				request,
				result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromPSNAccountIDsResult>> GetPlayFabIDsFromPSNAccountIDsAsync(
			GetPlayFabIDsFromPSNAccountIDsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromPSNAccountIDsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromPSNAccountIDs
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromPSNAccountIDsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromPSNAccountIDsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromSteamIDsResult>> GetPlayFabIDsFromSteamIDsAsync(
			GetPlayFabIDsFromSteamIDsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromSteamIDsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromSteamIDs
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromSteamIDsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromSteamIDsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromTwitchIDsResult>> GetPlayFabIDsFromTwitchIDsAsync(
			GetPlayFabIDsFromTwitchIDsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromTwitchIDsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromTwitchIDs
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromTwitchIDsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromTwitchIDsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPlayFabIDsFromXboxLiveIDsResult>> GetPlayFabIDsFromXboxLiveIDsAsync(
			GetPlayFabIDsFromXboxLiveIDsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPlayFabIDsFromXboxLiveIDsResult>> tcs = new();

			PlayFabClientAPI.GetPlayFabIDsFromXboxLiveIDs
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromXboxLiveIDsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPlayFabIDsFromXboxLiveIDsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPublisherDataResult>> GetPublisherDataAsync(GetPublisherDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPublisherDataResult>> tcs = new();

			PlayFabClientAPI.GetPublisherData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPublisherDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPublisherDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetPurchaseResult>> GetPurchaseAsync(GetPurchaseRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetPurchaseResult>> tcs = new();

			PlayFabClientAPI.GetPurchase
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetPurchaseResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetPurchaseResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetSharedGroupDataResult>> GetSharedGroupDataAsync(GetSharedGroupDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetSharedGroupDataResult>> tcs = new();

			PlayFabClientAPI.GetSharedGroupData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetSharedGroupDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetSharedGroupDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetStoreItemsResult>> GetStoreItemsAsync(GetStoreItemsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetStoreItemsResult>> tcs = new();

			PlayFabClientAPI.GetStoreItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetStoreItemsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetStoreItemsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetTimeResult>> GetTimeAsync(GetTimeRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetTimeResult>> tcs = new();

			PlayFabClientAPI.GetTime
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetTimeResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetTimeResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetTitleDataResult>> GetTitleDataAsync(GetTitleDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetTitleDataResult>> tcs = new();

			PlayFabClientAPI.GetTitleData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetTitleDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetTitleDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetTitleNewsResult>> GetTitleNewsAsync(GetTitleNewsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetTitleNewsResult>> tcs = new();

			PlayFabClientAPI.GetTitleNews
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetTitleNewsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetTitleNewsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetTitlePublicKeyResult>> GetTitlePublicKeyAsync(GetTitlePublicKeyRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetTitlePublicKeyResult>> tcs = new();

			PlayFabClientAPI.GetTitlePublicKey
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetTitlePublicKeyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetTitlePublicKeyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetTradeStatusResponse>> GetTradeStatusAsync(GetTradeStatusRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetTradeStatusResponse>> tcs = new();

			PlayFabClientAPI.GetTradeStatus
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetTradeStatusResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetTradeStatusResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetUserDataResult>> GetUserDataAsync(GetUserDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetUserDataResult>> tcs = new();

			PlayFabClientAPI.GetUserData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetUserDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetUserDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetUserInventoryResult>> GetUserInventoryAsync(GetUserInventoryRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetUserInventoryResult>> tcs = new();

			PlayFabClientAPI.GetUserInventory
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetUserInventoryResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetUserInventoryResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetUserDataResult>> GetUserPublisherDataAsync(GetUserDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetUserDataResult>> tcs = new();

			PlayFabClientAPI.GetUserPublisherData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetUserDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetUserDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetUserDataResult>> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetUserDataResult>> tcs = new();

			PlayFabClientAPI.GetUserPublisherReadOnlyData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetUserDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetUserDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetUserDataResult>> GetUserReadOnlyDataAsync(GetUserDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetUserDataResult>> tcs = new();

			PlayFabClientAPI.GetUserReadOnlyData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetUserDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetUserDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GrantCharacterToUserResult>> GrantCharacterToUserAsync(GrantCharacterToUserRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GrantCharacterToUserResult>> tcs = new();

			PlayFabClientAPI.GrantCharacterToUser
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GrantCharacterToUserResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GrantCharacterToUserResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkAndroidDeviceIDResult>> LinkAndroidDeviceIDAsync(LinkAndroidDeviceIDRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkAndroidDeviceIDResult>> tcs = new();

			PlayFabClientAPI.LinkAndroidDeviceID
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkAndroidDeviceIDResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkAndroidDeviceIDResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResult>> LinkAppleAsync(LinkAppleRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResult>> tcs = new();

			PlayFabClientAPI.LinkApple
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkCustomIDResult>> LinkCustomIDAsync(LinkCustomIDRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkCustomIDResult>> tcs = new();

			PlayFabClientAPI.LinkCustomID
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkCustomIDResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkCustomIDResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkFacebookAccountResult>> LinkFacebookAccountAsync(LinkFacebookAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkFacebookAccountResult>> tcs = new();

			PlayFabClientAPI.LinkFacebookAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkFacebookAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkFacebookAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkFacebookInstantGamesIdResult>> LinkFacebookInstantGamesIdAsync(
			LinkFacebookInstantGamesIdRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkFacebookInstantGamesIdResult>> tcs = new();

			PlayFabClientAPI.LinkFacebookInstantGamesId
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkFacebookInstantGamesIdResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkFacebookInstantGamesIdResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkGameCenterAccountResult>> LinkGameCenterAccountAsync(
			LinkGameCenterAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkGameCenterAccountResult>> tcs = new();

			PlayFabClientAPI.LinkGameCenterAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkGameCenterAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkGameCenterAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkGoogleAccountResult>> LinkGoogleAccountAsync(LinkGoogleAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkGoogleAccountResult>> tcs = new();

			PlayFabClientAPI.LinkGoogleAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkGoogleAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkGoogleAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkGooglePlayGamesServicesAccountResult>> LinkGooglePlayGamesServicesAccountAsync(
			LinkGooglePlayGamesServicesAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkGooglePlayGamesServicesAccountResult>> tcs = new();

			PlayFabClientAPI.LinkGooglePlayGamesServicesAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkGooglePlayGamesServicesAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkGooglePlayGamesServicesAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkIOSDeviceIDResult>> LinkIOSDeviceIDAsync(LinkIOSDeviceIDRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkIOSDeviceIDResult>> tcs = new();

			PlayFabClientAPI.LinkIOSDeviceID
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkIOSDeviceIDResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkIOSDeviceIDResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkKongregateAccountResult>> LinkKongregateAsync(LinkKongregateAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkKongregateAccountResult>> tcs = new();

			PlayFabClientAPI.LinkKongregate
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkKongregateAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkKongregateAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResult>> LinkNintendoServiceAccountAsync(LinkNintendoServiceAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResult>> tcs = new();

			PlayFabClientAPI.LinkNintendoServiceAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkNintendoSwitchDeviceIdResult>> LinkNintendoSwitchDeviceIdAsync(
			LinkNintendoSwitchDeviceIdRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkNintendoSwitchDeviceIdResult>> tcs = new();

			PlayFabClientAPI.LinkNintendoSwitchDeviceId
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkNintendoSwitchDeviceIdResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkNintendoSwitchDeviceIdResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResult>> LinkOpenIdConnectAsync(LinkOpenIdConnectRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResult>> tcs = new();

			PlayFabClientAPI.LinkOpenIdConnect
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkPSNAccountResult>> LinkPSNAccountAsync(LinkPSNAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkPSNAccountResult>> tcs = new();

			PlayFabClientAPI.LinkPSNAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkPSNAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkPSNAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkSteamAccountResult>> LinkSteamAccountAsync(LinkSteamAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkSteamAccountResult>> tcs = new();

			PlayFabClientAPI.LinkSteamAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkSteamAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkSteamAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkTwitchAccountResult>> LinkTwitchAsync(LinkTwitchAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkTwitchAccountResult>> tcs = new();

			PlayFabClientAPI.LinkTwitch
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkTwitchAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkTwitchAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LinkXboxAccountResult>> LinkXboxAccountAsync(LinkXboxAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LinkXboxAccountResult>> tcs = new();

			PlayFabClientAPI.LinkXboxAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LinkXboxAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LinkXboxAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithAndroidDeviceIDAsync(LoginWithAndroidDeviceIDRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithAndroidDeviceID
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithAppleAsync(LoginWithAppleRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithApple
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithCustomIDAsync(LoginWithCustomIDRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithCustomID
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithEmailAddressAsync(LoginWithEmailAddressRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithEmailAddress
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithFacebookAsync(LoginWithFacebookRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithFacebook
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithFacebookInstantGamesIdAsync(
			LoginWithFacebookInstantGamesIdRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithFacebookInstantGamesId
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithGameCenterAsync(LoginWithGameCenterRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithGameCenter
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithGoogleAccountAsync(LoginWithGoogleAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithGoogleAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithGooglePlayGamesServicesAsync(
			LoginWithGooglePlayGamesServicesRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithGooglePlayGamesServices
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithIOSDeviceIDAsync(LoginWithIOSDeviceIDRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithIOSDeviceID
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithKongregateAsync(LoginWithKongregateRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithKongregate
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithNintendoServiceAccountAsync(
			LoginWithNintendoServiceAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithNintendoServiceAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithNintendoSwitchDeviceIdAsync(
			LoginWithNintendoSwitchDeviceIdRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithNintendoSwitchDeviceId
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithOpenIdConnectAsync(LoginWithOpenIdConnectRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithOpenIdConnect
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithPlayFabAsync(LoginWithPlayFabRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithPlayFab
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithPSNAsync(LoginWithPSNRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithPSN
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithSteamAsync(LoginWithSteamRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithSteam
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithTwitchAsync(LoginWithTwitchRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithTwitch
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<LoginResult>> LoginWithXboxAsync(LoginWithXboxRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<LoginResult>> tcs = new();

			PlayFabClientAPI.LoginWithXbox
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<LoginResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<OpenTradeResponse>> OpenTradeAsync(OpenTradeRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<OpenTradeResponse>> tcs = new();

			PlayFabClientAPI.OpenTrade
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<OpenTradeResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<OpenTradeResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<PayForPurchaseResult>> PayForPurchaseAsync(PayForPurchaseRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<PayForPurchaseResult>> tcs = new();

			PlayFabClientAPI.PayForPurchase
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<PayForPurchaseResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<PayForPurchaseResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<PurchaseItemResult>> PurchaseItemAsync(PurchaseItemRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<PurchaseItemResult>> tcs = new();

			PlayFabClientAPI.PurchaseItem
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<PurchaseItemResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<PurchaseItemResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RedeemCouponResult>> RedeemCouponAsync(RedeemCouponRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RedeemCouponResult>> tcs = new();

			PlayFabClientAPI.RedeemCoupon
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemCouponResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemCouponResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResponse>> RefreshPSNAuthTokenAsync(RefreshPSNAuthTokenRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResponse>> tcs = new();

			PlayFabClientAPI.RefreshPSNAuthToken
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RegisterForIOSPushNotificationResult>> RegisterForIOSPushNotificationAsync(
			RegisterForIOSPushNotificationRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RegisterForIOSPushNotificationResult>> tcs = new();

			PlayFabClientAPI.RegisterForIOSPushNotification
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RegisterForIOSPushNotificationResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RegisterForIOSPushNotificationResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RegisterPlayFabUserResult>> RegisterPlayFabUserAsync(RegisterPlayFabUserRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RegisterPlayFabUserResult>> tcs = new();

			PlayFabClientAPI.RegisterPlayFabUser
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RegisterPlayFabUserResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RegisterPlayFabUserResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RemoveContactEmailResult>> RemoveContactEmailAsync(RemoveContactEmailRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RemoveContactEmailResult>> tcs = new();

			PlayFabClientAPI.RemoveContactEmail
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RemoveContactEmailResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RemoveContactEmailResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RemoveFriendResult>> RemoveFriendAsync(RemoveFriendRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RemoveFriendResult>> tcs = new();

			PlayFabClientAPI.RemoveFriend
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RemoveFriendResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RemoveFriendResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RemoveGenericIDResult>> RemoveGenericIDAsync(RemoveGenericIDRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RemoveGenericIDResult>> tcs = new();

			PlayFabClientAPI.RemoveGenericID
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RemoveGenericIDResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RemoveGenericIDResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RemoveSharedGroupMembersResult>> RemoveSharedGroupMembersAsync(
			RemoveSharedGroupMembersRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RemoveSharedGroupMembersResult>> tcs = new();

			PlayFabClientAPI.RemoveSharedGroupMembers
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RemoveSharedGroupMembersResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RemoveSharedGroupMembersResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ReportAdActivityResult>> ReportAdActivityAsync(ReportAdActivityRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ReportAdActivityResult>> tcs = new();

			PlayFabClientAPI.ReportAdActivity
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ReportAdActivityResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ReportAdActivityResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResponse>> ReportDeviceInfoAsync(DeviceInfoRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResponse>> tcs = new();

			PlayFabClientAPI.ReportDeviceInfo
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ReportPlayerClientResult>> ReportPlayerAsync(ReportPlayerClientRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ReportPlayerClientResult>> tcs = new();

			PlayFabClientAPI.ReportPlayer
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ReportPlayerClientResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ReportPlayerClientResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RestoreIOSPurchasesResult>> RestoreIOSPurchasesAsync(RestoreIOSPurchasesRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RestoreIOSPurchasesResult>> tcs = new();

			PlayFabClientAPI.RestoreIOSPurchases
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RestoreIOSPurchasesResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RestoreIOSPurchasesResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RewardAdActivityResult>> RewardAdActivityAsync(RewardAdActivityRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RewardAdActivityResult>> tcs = new();

			PlayFabClientAPI.RewardAdActivity
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RewardAdActivityResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RewardAdActivityResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<SendAccountRecoveryEmailResult>> SendAccountRecoveryEmailAsync(
			SendAccountRecoveryEmailRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<SendAccountRecoveryEmailResult>> tcs = new();

			PlayFabClientAPI.SendAccountRecoveryEmail
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<SendAccountRecoveryEmailResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<SendAccountRecoveryEmailResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<SetFriendTagsResult>> SetFriendTagsAsync(SetFriendTagsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<SetFriendTagsResult>> tcs = new();

			PlayFabClientAPI.SetFriendTags
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<SetFriendTagsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<SetFriendTagsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<SetPlayerSecretResult>> SetPlayerSecretAsync(SetPlayerSecretRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<SetPlayerSecretResult>> tcs = new();

			PlayFabClientAPI.SetPlayerSecret
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<SetPlayerSecretResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<SetPlayerSecretResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<StartPurchaseResult>> StartPurchaseAsync(StartPurchaseRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<StartPurchaseResult>> tcs = new();

			PlayFabClientAPI.StartPurchase
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<StartPurchaseResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<StartPurchaseResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrencyAsync(
			SubtractUserVirtualCurrencyRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ModifyUserVirtualCurrencyResult>> tcs = new();

			PlayFabClientAPI.SubtractUserVirtualCurrency
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ModifyUserVirtualCurrencyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ModifyUserVirtualCurrencyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkAndroidDeviceIDResult>> UnlinkAndroidDeviceIDAsync(
			UnlinkAndroidDeviceIDRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkAndroidDeviceIDResult>> tcs = new();

			PlayFabClientAPI.UnlinkAndroidDeviceID
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkAndroidDeviceIDResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkAndroidDeviceIDResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResponse>> UnlinkAppleAsync(UnlinkAppleRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResponse>> tcs = new();

			PlayFabClientAPI.UnlinkApple
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkCustomIDResult>> UnlinkCustomIDAsync(UnlinkCustomIDRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkCustomIDResult>> tcs = new();

			PlayFabClientAPI.UnlinkCustomID
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkCustomIDResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkCustomIDResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkFacebookAccountResult>> UnlinkFacebookAccountAsync(
			UnlinkFacebookAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkFacebookAccountResult>> tcs = new();

			PlayFabClientAPI.UnlinkFacebookAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkFacebookAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkFacebookAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkFacebookInstantGamesIdResult>> UnlinkFacebookInstantGamesIdAsync(
			UnlinkFacebookInstantGamesIdRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkFacebookInstantGamesIdResult>> tcs = new();

			PlayFabClientAPI.UnlinkFacebookInstantGamesId
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkFacebookInstantGamesIdResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkFacebookInstantGamesIdResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkGameCenterAccountResult>> UnlinkGameCenterAccountAsync(
			UnlinkGameCenterAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkGameCenterAccountResult>> tcs = new();

			PlayFabClientAPI.UnlinkGameCenterAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkGameCenterAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkGameCenterAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkGoogleAccountResult>> UnlinkGoogleAccountAsync(UnlinkGoogleAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkGoogleAccountResult>> tcs = new();

			PlayFabClientAPI.UnlinkGoogleAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkGoogleAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkGoogleAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkGooglePlayGamesServicesAccountResult>> UnlinkGooglePlayGamesServicesAccountAsync(
			UnlinkGooglePlayGamesServicesAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkGooglePlayGamesServicesAccountResult>> tcs = new();

			PlayFabClientAPI.UnlinkGooglePlayGamesServicesAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkGooglePlayGamesServicesAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkGooglePlayGamesServicesAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkIOSDeviceIDResult>> UnlinkIOSDeviceIDAsync(UnlinkIOSDeviceIDRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkIOSDeviceIDResult>> tcs = new();

			PlayFabClientAPI.UnlinkIOSDeviceID
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkIOSDeviceIDResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkIOSDeviceIDResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkKongregateAccountResult>> UnlinkKongregateAsync(
			UnlinkKongregateAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkKongregateAccountResult>> tcs = new();

			PlayFabClientAPI.UnlinkKongregate
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkKongregateAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkKongregateAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResponse>> UnlinkNintendoServiceAccountAsync(
			UnlinkNintendoServiceAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResponse>> tcs = new();

			PlayFabClientAPI.UnlinkNintendoServiceAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkNintendoSwitchDeviceIdResult>> UnlinkNintendoSwitchDeviceIdAsync(
			UnlinkNintendoSwitchDeviceIdRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkNintendoSwitchDeviceIdResult>> tcs = new();

			PlayFabClientAPI.UnlinkNintendoSwitchDeviceId
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkNintendoSwitchDeviceIdResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkNintendoSwitchDeviceIdResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResponse>> UnlinkOpenIdConnectAsync(UnlinkOpenIdConnectRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResponse>> tcs = new();

			PlayFabClientAPI.UnlinkOpenIdConnect
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkPSNAccountResult>> UnlinkPSNAccountAsync(UnlinkPSNAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkPSNAccountResult>> tcs = new();

			PlayFabClientAPI.UnlinkPSNAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkPSNAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkPSNAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkSteamAccountResult>> UnlinkSteamAccountAsync(UnlinkSteamAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkSteamAccountResult>> tcs = new();

			PlayFabClientAPI.UnlinkSteamAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkSteamAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkSteamAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkTwitchAccountResult>> UnlinkTwitchAsync(UnlinkTwitchAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkTwitchAccountResult>> tcs = new();

			PlayFabClientAPI.UnlinkTwitch
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkTwitchAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkTwitchAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlinkXboxAccountResult>> UnlinkXboxAccountAsync(UnlinkXboxAccountRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlinkXboxAccountResult>> tcs = new();

			PlayFabClientAPI.UnlinkXboxAccount
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkXboxAccountResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlinkXboxAccountResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlockContainerItemResult>> UnlockContainerInstanceAsync(
			UnlockContainerInstanceRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlockContainerItemResult>> tcs = new();

			PlayFabClientAPI.UnlockContainerInstance
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlockContainerItemResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlockContainerItemResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UnlockContainerItemResult>> UnlockContainerItemAsync(UnlockContainerItemRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UnlockContainerItemResult>> tcs = new();

			PlayFabClientAPI.UnlockContainerItem
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UnlockContainerItemResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UnlockContainerItemResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResponse>> UpdateAvatarUrlAsync(UpdateAvatarUrlRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResponse>> tcs = new();

			PlayFabClientAPI.UpdateAvatarUrl
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UpdateCharacterDataResult>> UpdateCharacterDataAsync(UpdateCharacterDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UpdateCharacterDataResult>> tcs = new();

			PlayFabClientAPI.UpdateCharacterData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateCharacterDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateCharacterDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UpdateCharacterStatisticsResult>> UpdateCharacterStatisticsAsync(
			UpdateCharacterStatisticsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UpdateCharacterStatisticsResult>> tcs = new();

			PlayFabClientAPI.UpdateCharacterStatistics
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateCharacterStatisticsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateCharacterStatisticsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatisticsAsync(
			UpdatePlayerStatisticsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UpdatePlayerStatisticsResult>> tcs = new();

			PlayFabClientAPI.UpdatePlayerStatistics
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UpdatePlayerStatisticsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UpdatePlayerStatisticsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UpdateSharedGroupDataResult>> UpdateSharedGroupDataAsync(
			UpdateSharedGroupDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UpdateSharedGroupDataResult>> tcs = new();

			PlayFabClientAPI.UpdateSharedGroupData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateSharedGroupDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateSharedGroupDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UpdateUserDataResult>> UpdateUserDataAsync(UpdateUserDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UpdateUserDataResult>> tcs = new();

			PlayFabClientAPI.UpdateUserData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateUserDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateUserDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UpdateUserDataResult>> UpdateUserPublisherDataAsync(UpdateUserDataRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UpdateUserDataResult>> tcs = new();

			PlayFabClientAPI.UpdateUserPublisherData
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateUserDataResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateUserDataResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UpdateUserTitleDisplayNameResult>> UpdateUserTitleDisplayNameAsync(
			UpdateUserTitleDisplayNameRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UpdateUserTitleDisplayNameResult>> tcs = new();

			PlayFabClientAPI.UpdateUserTitleDisplayName
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateUserTitleDisplayNameResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateUserTitleDisplayNameResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ValidateAmazonReceiptResult>> ValidateAmazonIAPReceiptAsync(
			ValidateAmazonReceiptRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ValidateAmazonReceiptResult>> tcs = new();

			PlayFabClientAPI.ValidateAmazonIAPReceipt
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ValidateAmazonReceiptResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ValidateAmazonReceiptResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ValidateGooglePlayPurchaseResult>> ValidateGooglePlayPurchaseAsync(
			ValidateGooglePlayPurchaseRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ValidateGooglePlayPurchaseResult>> tcs = new();

			PlayFabClientAPI.ValidateGooglePlayPurchase
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ValidateGooglePlayPurchaseResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ValidateGooglePlayPurchaseResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ValidateIOSReceiptResult>> ValidateIOSReceiptAsync(ValidateIOSReceiptRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ValidateIOSReceiptResult>> tcs = new();

			PlayFabClientAPI.ValidateIOSReceipt
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ValidateIOSReceiptResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ValidateIOSReceiptResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ValidateWindowsReceiptResult>> ValidateWindowsStoreReceiptAsync(
			ValidateWindowsReceiptRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ValidateWindowsReceiptResult>> tcs = new();

			PlayFabClientAPI.ValidateWindowsStoreReceipt
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ValidateWindowsReceiptResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ValidateWindowsReceiptResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<WriteEventResponse>> WriteCharacterEventAsync(WriteClientCharacterEventRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<WriteEventResponse>> tcs = new();

			PlayFabClientAPI.WriteCharacterEvent
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<WriteEventResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<WriteEventResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<WriteEventResponse>> WritePlayerEventAsync(WriteClientPlayerEventRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<WriteEventResponse>> tcs = new();

			PlayFabClientAPI.WritePlayerEvent
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<WriteEventResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<WriteEventResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<WriteEventResponse>> WriteTitleEventAsync(WriteTitleEventRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<WriteEventResponse>> tcs = new();

			PlayFabClientAPI.WriteTitleEvent
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<WriteEventResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<WriteEventResponse>(null, error)); }
			);

			return tcs.Task;
		}
	}
}
