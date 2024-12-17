#if ENABLE_PLAYFABADMIN_API && !DISABLE_PLAYFAB_STATIC_API
using System;
using Cysharp.Threading.Tasks;
using PlayFab;
using PlayFab.AdminModels;
using PlayFab.Internal;
using PlayFab.SharedModels;

namespace PlayFabAsyncSDKUniTask.Editor
{
	public static class PlayFabAdminAPIAsync
	{
		public static async UniTask<EmptyResponse> AbortTaskInstanceAsync(AbortTaskInstanceRequest request)
		{
			return await MakeApiCallAsync<AbortTaskInstanceRequest, EmptyResponse>("/Admin/AbortTaskInstance", request);
		}

		public static async UniTask<AddLocalizedNewsResult> AddLocalizedNewsAsync(AddLocalizedNewsRequest request)
		{
			return await MakeApiCallAsync<AddLocalizedNewsRequest, AddLocalizedNewsResult>("/Admin/AddLocalizedNews", request);
		}

		public static async UniTask<AddNewsResult> AddNewsAsync(AddNewsRequest request)
		{
			return await MakeApiCallAsync<AddNewsRequest, AddNewsResult>("/Admin/AddNews", request);
		}

		public static async UniTask<AddPlayerTagResult> AddPlayerTagAsync(AddPlayerTagRequest request)
		{
			return await MakeApiCallAsync<AddPlayerTagRequest, AddPlayerTagResult>("/Admin/AddPlayerTag", request);
		}

		public static async UniTask<ModifyUserVirtualCurrencyResult> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request)
		{
			return await MakeApiCallAsync<AddUserVirtualCurrencyRequest, ModifyUserVirtualCurrencyResult>
				("/Admin/AddUserVirtualCurrency", request);
		}

		public static async UniTask<BlankResult> AddVirtualCurrencyTypesAsync(AddVirtualCurrencyTypesRequest request)
		{
			return await MakeApiCallAsync<AddVirtualCurrencyTypesRequest, BlankResult>("/Admin/AddVirtualCurrencyTypes", request);
		}

		public static async UniTask<BanUsersResult> BanUsersAsync(BanUsersRequest request)
		{
			return await MakeApiCallAsync<BanUsersRequest, BanUsersResult>("/Admin/BanUsers", request);
		}

		public static async UniTask<CheckLimitedEditionItemAvailabilityResult> CheckLimitedEditionItemAvailabilityAsync(
			CheckLimitedEditionItemAvailabilityRequest request)
		{
			return await MakeApiCallAsync<CheckLimitedEditionItemAvailabilityRequest, CheckLimitedEditionItemAvailabilityResult>
				("/Admin/CheckLimitedEditionItemAvailability", request);
		}

		public static async UniTask<CreateTaskResult> CreateActionsOnPlayersInSegmentTaskAsync(
			CreateActionsOnPlayerSegmentTaskRequest request)
		{
			return await MakeApiCallAsync<CreateActionsOnPlayerSegmentTaskRequest, CreateTaskResult>
				("/Admin/CreateActionsOnPlayersInSegmentTask", request);
		}

		public static async UniTask<CreateTaskResult> CreateCloudScriptTaskAsync(CreateCloudScriptTaskRequest request)
		{
			return await MakeApiCallAsync<CreateCloudScriptTaskRequest, CreateTaskResult>("/Admin/CreateCloudScriptTask", request);
		}

		public static async UniTask<CreateTaskResult> CreateInsightsScheduledScalingTaskAsync(
			CreateInsightsScheduledScalingTaskRequest request)
		{
			return await MakeApiCallAsync<CreateInsightsScheduledScalingTaskRequest, CreateTaskResult>
				("/Admin/CreateInsightsScheduledScalingTask", request);
		}

		public static async UniTask<EmptyResponse> CreateOpenIdConnectionAsync(CreateOpenIdConnectionRequest request)
		{
			return await MakeApiCallAsync<CreateOpenIdConnectionRequest, EmptyResponse>("/Admin/CreateOpenIdConnection", request);
		}

		public static async UniTask<CreatePlayerSharedSecretResult> CreatePlayerSharedSecretAsync(CreatePlayerSharedSecretRequest request)
		{
			return await MakeApiCallAsync<CreatePlayerSharedSecretRequest, CreatePlayerSharedSecretResult>
				("/Admin/CreatePlayerSharedSecret", request);
		}

		public static async UniTask<CreatePlayerStatisticDefinitionResult> CreatePlayerStatisticDefinitionAsync(
			CreatePlayerStatisticDefinitionRequest request)
		{
			return await MakeApiCallAsync<CreatePlayerStatisticDefinitionRequest, CreatePlayerStatisticDefinitionResult>
				("/Admin/CreatePlayerStatisticDefinition", request);
		}

		public static async UniTask<CreateSegmentResponse> CreateSegmentAsync(CreateSegmentRequest request)
		{
			return await MakeApiCallAsync<CreateSegmentRequest, CreateSegmentResponse>("/Admin/CreateSegment", request);
		}

		public static async UniTask<BlankResult> DeleteContentAsync(DeleteContentRequest request)
		{
			return await MakeApiCallAsync<DeleteContentRequest, BlankResult>("/Admin/DeleteContent", request);
		}

		public static async UniTask<DeleteMasterPlayerAccountResult> DeleteMasterPlayerAccountAsync(
			DeleteMasterPlayerAccountRequest request)
		{
			return await MakeApiCallAsync<DeleteMasterPlayerAccountRequest, DeleteMasterPlayerAccountResult>
				("/Admin/DeleteMasterPlayerAccount", request);
		}

		public static async UniTask<DeleteMasterPlayerEventDataResult> DeleteMasterPlayerEventDataAsync(
			DeleteMasterPlayerEventDataRequest request)
		{
			return await MakeApiCallAsync<DeleteMasterPlayerEventDataRequest, DeleteMasterPlayerEventDataResult>
				("/Admin/DeleteMasterPlayerEventData", request);
		}

		public static async UniTask<DeleteMembershipSubscriptionResult> DeleteMembershipSubscriptionAsync(
			DeleteMembershipSubscriptionRequest request)
		{
			return await MakeApiCallAsync<DeleteMembershipSubscriptionRequest, DeleteMembershipSubscriptionResult>
				("/Admin/DeleteMembershipSubscription", request);
		}

		public static async UniTask<EmptyResponse> DeleteOpenIdConnectionAsync(DeleteOpenIdConnectionRequest request)
		{
			return await MakeApiCallAsync<DeleteOpenIdConnectionRequest, EmptyResponse>("/Admin/DeleteOpenIdConnection", request);
		}

		public static async UniTask<DeletePlayerResult> DeletePlayerAsync(DeletePlayerRequest request)
		{
			return await MakeApiCallAsync<DeletePlayerRequest, DeletePlayerResult>("/Admin/DeletePlayer", request);
		}

		public static async UniTask<DeletePlayerSharedSecretResult> DeletePlayerSharedSecretAsync(DeletePlayerSharedSecretRequest request)
		{
			return await MakeApiCallAsync<DeletePlayerSharedSecretRequest, DeletePlayerSharedSecretResult>
				("/Admin/DeletePlayerSharedSecret", request);
		}

		public static async UniTask<DeleteSegmentsResponse> DeleteSegmentAsync(DeleteSegmentRequest request)
		{
			return await MakeApiCallAsync<DeleteSegmentRequest, DeleteSegmentsResponse>("/Admin/DeleteSegment", request);
		}

		public static async UniTask<DeleteStoreResult> DeleteStoreAsync(DeleteStoreRequest request)
		{
			return await MakeApiCallAsync<DeleteStoreRequest, DeleteStoreResult>("/Admin/DeleteStore", request);
		}

		public static async UniTask<EmptyResponse> DeleteTaskAsync(DeleteTaskRequest request)
		{
			return await MakeApiCallAsync<DeleteTaskRequest, EmptyResponse>("/Admin/DeleteTask", request);
		}

		public static async UniTask<DeleteTitleResult> DeleteTitleAsync(DeleteTitleRequest request)
		{
			return await MakeApiCallAsync<DeleteTitleRequest, DeleteTitleResult>("/Admin/DeleteTitle", request);
		}

		public static async UniTask<DeleteTitleDataOverrideResult> DeleteTitleDataOverrideAsync(DeleteTitleDataOverrideRequest request)
		{
			return await MakeApiCallAsync<DeleteTitleDataOverrideRequest, DeleteTitleDataOverrideResult>
				("/Admin/DeleteTitleDataOverride", request);
		}

		public static async UniTask<ExportMasterPlayerDataResult> ExportMasterPlayerDataAsync(ExportMasterPlayerDataRequest request)
		{
			return await MakeApiCallAsync<ExportMasterPlayerDataRequest, ExportMasterPlayerDataResult>
				("/Admin/ExportMasterPlayerData", request);
		}

		public static async UniTask<ExportPlayersInSegmentResult> ExportPlayersInSegmentAsync(ExportPlayersInSegmentRequest request)
		{
			return await MakeApiCallAsync<ExportPlayersInSegmentRequest, ExportPlayersInSegmentResult>
				("/Admin/ExportPlayersInSegment", request);
		}

		public static async UniTask<GetActionsOnPlayersInSegmentTaskInstanceResult> GetActionsOnPlayersInSegmentTaskInstanceAsync(
			GetTaskInstanceRequest request)
		{
			return await MakeApiCallAsync<GetTaskInstanceRequest, GetActionsOnPlayersInSegmentTaskInstanceResult>
				("/Admin/GetActionsOnPlayersInSegmentTaskInstance", request);
		}

		public static async UniTask<GetAllSegmentsResult> GetAllSegmentsAsync(GetAllSegmentsRequest request)
		{
			return await MakeApiCallAsync<GetAllSegmentsRequest, GetAllSegmentsResult>("/Admin/GetAllSegments", request);
		}

		public static async UniTask<GetCatalogItemsResult> GetCatalogItemsAsync(GetCatalogItemsRequest request)
		{
			return await MakeApiCallAsync<GetCatalogItemsRequest, GetCatalogItemsResult>("/Admin/GetCatalogItems", request);
		}

		public static async UniTask<GetCloudScriptRevisionResult> GetCloudScriptRevisionAsync(GetCloudScriptRevisionRequest request)
		{
			return await MakeApiCallAsync<GetCloudScriptRevisionRequest, GetCloudScriptRevisionResult>
				("/Admin/GetCloudScriptRevision", request);
		}

		public static async UniTask<GetCloudScriptTaskInstanceResult> GetCloudScriptTaskInstanceAsync(GetTaskInstanceRequest request)
		{
			return await MakeApiCallAsync<GetTaskInstanceRequest, GetCloudScriptTaskInstanceResult>
				("/Admin/GetCloudScriptTaskInstance", request);
		}

		public static async UniTask<GetCloudScriptVersionsResult> GetCloudScriptVersionsAsync(GetCloudScriptVersionsRequest request)
		{
			return await MakeApiCallAsync<GetCloudScriptVersionsRequest, GetCloudScriptVersionsResult>
				("/Admin/GetCloudScriptVersions", request);
		}

		public static async UniTask<GetContentListResult> GetContentListAsync(GetContentListRequest request)
		{
			return await MakeApiCallAsync<GetContentListRequest, GetContentListResult>("/Admin/GetContentList", request);
		}

		public static async UniTask<GetContentUploadUrlResult> GetContentUploadUrlAsync(GetContentUploadUrlRequest request)
		{
			return await MakeApiCallAsync<GetContentUploadUrlRequest, GetContentUploadUrlResult>("/Admin/GetContentUploadUrl", request);
		}

		public static async UniTask<GetDataReportResult> GetDataReportAsync(GetDataReportRequest request)
		{
			return await MakeApiCallAsync<GetDataReportRequest, GetDataReportResult>("/Admin/GetDataReport", request);
		}

		public static async UniTask<GetPlayedTitleListResult> GetPlayedTitleListAsync(GetPlayedTitleListRequest request)
		{
			return await MakeApiCallAsync<GetPlayedTitleListRequest, GetPlayedTitleListResult>("/Admin/GetPlayedTitleList", request);
		}

		public static async UniTask<GetPlayerIdFromAuthTokenResult> GetPlayerIdFromAuthTokenAsync(GetPlayerIdFromAuthTokenRequest request)
		{
			return await MakeApiCallAsync<GetPlayerIdFromAuthTokenRequest, GetPlayerIdFromAuthTokenResult>
				("/Admin/GetPlayerIdFromAuthToken", request);
		}

		public static async UniTask<GetPlayerProfileResult> GetPlayerProfileAsync(GetPlayerProfileRequest request)
		{
			return await MakeApiCallAsync<GetPlayerProfileRequest, GetPlayerProfileResult>("/Admin/GetPlayerProfile", request);
		}

		public static async UniTask<GetPlayerSegmentsResult> GetPlayerSegmentsAsync(GetPlayersSegmentsRequest request)
		{
			return await MakeApiCallAsync<GetPlayersSegmentsRequest, GetPlayerSegmentsResult>("/Admin/GetPlayerSegments", request);
		}

		public static async UniTask<GetPlayerSharedSecretsResult> GetPlayerSharedSecretsAsync(GetPlayerSharedSecretsRequest request)
		{
			return await MakeApiCallAsync<GetPlayerSharedSecretsRequest, GetPlayerSharedSecretsResult>
				("/Admin/GetPlayerSharedSecrets", request);
		}

		public static async UniTask<GetPlayersInSegmentResult> GetPlayersInSegmentAsync(GetPlayersInSegmentRequest request)
		{
			return await MakeApiCallAsync<GetPlayersInSegmentRequest, GetPlayersInSegmentResult>("/Admin/GetPlayersInSegment", request);
		}

		public static async UniTask<GetPlayerStatisticDefinitionsResult> GetPlayerStatisticDefinitionsAsync(
			GetPlayerStatisticDefinitionsRequest request)
		{
			return await MakeApiCallAsync<GetPlayerStatisticDefinitionsRequest, GetPlayerStatisticDefinitionsResult>
				("/Admin/GetPlayerStatisticDefinitions", request);
		}

		public static async UniTask<GetPlayerStatisticVersionsResult> GetPlayerStatisticVersionsAsync(
			GetPlayerStatisticVersionsRequest request)
		{
			return await MakeApiCallAsync<GetPlayerStatisticVersionsRequest, GetPlayerStatisticVersionsResult>
				("/Admin/GetPlayerStatisticVersions", request);
		}

		public static async UniTask<GetPlayerTagsResult> GetPlayerTagsAsync(GetPlayerTagsRequest request)
		{
			return await MakeApiCallAsync<GetPlayerTagsRequest, GetPlayerTagsResult>("/Admin/GetPlayerTags", request);
		}

		public static async UniTask<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request)
		{
			return await MakeApiCallAsync<GetPolicyRequest, GetPolicyResponse>("/Admin/GetPolicy", request);
		}

		public static async UniTask<GetPublisherDataResult> GetPublisherDataAsync(GetPublisherDataRequest request)
		{
			return await MakeApiCallAsync<GetPublisherDataRequest, GetPublisherDataResult>("/Admin/GetPublisherData", request);
		}

		public static async UniTask<GetRandomResultTablesResult> GetRandomResultTablesAsync(GetRandomResultTablesRequest request)
		{
			return await MakeApiCallAsync<GetRandomResultTablesRequest, GetRandomResultTablesResult>
				("/Admin/GetRandomResultTables", request);
		}

		public static async UniTask<GetPlayersInSegmentExportResponse> GetSegmentExportAsync(GetPlayersInSegmentExportRequest request)
		{
			return await MakeApiCallAsync<GetPlayersInSegmentExportRequest, GetPlayersInSegmentExportResponse>
				("/Admin/GetSegmentExport", request);
		}

		public static async UniTask<GetSegmentsResponse> GetSegmentsAsync(GetSegmentsRequest request)
		{
			return await MakeApiCallAsync<GetSegmentsRequest, GetSegmentsResponse>("/Admin/GetSegments", request);
		}

		public static async UniTask<GetStoreItemsResult> GetStoreItemsAsync(GetStoreItemsRequest request)
		{
			return await MakeApiCallAsync<GetStoreItemsRequest, GetStoreItemsResult>("/Admin/GetStoreItems", request);
		}

		public static async UniTask<GetTaskInstancesResult> GetTaskInstancesAsync(GetTaskInstancesRequest request)
		{
			return await MakeApiCallAsync<GetTaskInstancesRequest, GetTaskInstancesResult>("/Admin/GetTaskInstances", request);
		}

		public static async UniTask<GetTasksResult> GetTasksAsync(GetTasksRequest request)
		{
			return await MakeApiCallAsync<GetTasksRequest, GetTasksResult>("/Admin/GetTasks", request);
		}

		public static async UniTask<GetTitleDataResult> GetTitleDataAsync(GetTitleDataRequest request)
		{
			return await MakeApiCallAsync<GetTitleDataRequest, GetTitleDataResult>("/Admin/GetTitleData", request);
		}

		public static async UniTask<GetTitleDataResult> GetTitleInternalDataAsync(GetTitleDataRequest request)
		{
			return await MakeApiCallAsync<GetTitleDataRequest, GetTitleDataResult>("/Admin/GetTitleInternalData", request);
		}

		public static async UniTask<LookupUserAccountInfoResult> GetUserAccountInfoAsync(LookupUserAccountInfoRequest request)
		{
			return await MakeApiCallAsync<LookupUserAccountInfoRequest, LookupUserAccountInfoResult>("/Admin/GetUserAccountInfo", request);
		}

		public static async UniTask<GetUserBansResult> GetUserBansAsync(GetUserBansRequest request)
		{
			return await MakeApiCallAsync<GetUserBansRequest, GetUserBansResult>("/Admin/GetUserBans", request);
		}

		public static async UniTask<GetUserDataResult> GetUserDataAsync(GetUserDataRequest request)
		{
			return await MakeApiCallAsync<GetUserDataRequest, GetUserDataResult>("/Admin/GetUserData", request);
		}

		public static async UniTask<GetUserDataResult> GetUserInternalDataAsync(GetUserDataRequest request)
		{
			return await MakeApiCallAsync<GetUserDataRequest, GetUserDataResult>("/Admin/GetUserInternalData", request);
		}

		public static async UniTask<GetUserInventoryResult> GetUserInventoryAsync(GetUserInventoryRequest request)
		{
			return await MakeApiCallAsync<GetUserInventoryRequest, GetUserInventoryResult>("/Admin/GetUserInventory", request);
		}

		public static async UniTask<GetUserDataResult> GetUserPublisherDataAsync(GetUserDataRequest request)
		{
			return await MakeApiCallAsync<GetUserDataRequest, GetUserDataResult>("/Admin/GetUserPublisherData", request);
		}

		public static async UniTask<GetUserDataResult> GetUserPublisherInternalDataAsync(GetUserDataRequest request)
		{
			return await MakeApiCallAsync<GetUserDataRequest, GetUserDataResult>("/Admin/GetUserPublisherInternalData", request);
		}

		public static async UniTask<GetUserDataResult> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request)
		{
			return await MakeApiCallAsync<GetUserDataRequest, GetUserDataResult>("/Admin/GetUserPublisherReadOnlyData", request);
		}

		public static async UniTask<GetUserDataResult> GetUserReadOnlyDataAsync(GetUserDataRequest request)
		{
			return await MakeApiCallAsync<GetUserDataRequest, GetUserDataResult>("/Admin/GetUserReadOnlyData", request);
		}

		public static async UniTask<GrantItemsToUsersResult> GrantItemsToUsersAsync(GrantItemsToUsersRequest request)
		{
			return await MakeApiCallAsync<GrantItemsToUsersRequest, GrantItemsToUsersResult>("/Admin/GrantItemsToUsers", request);
		}

		public static async UniTask<IncrementLimitedEditionItemAvailabilityResult> IncrementLimitedEditionItemAvailabilityAsync(
			IncrementLimitedEditionItemAvailabilityRequest request)
		{
			return await MakeApiCallAsync<IncrementLimitedEditionItemAvailabilityRequest, IncrementLimitedEditionItemAvailabilityResult>
				("/Admin/IncrementLimitedEditionItemAvailability", request);
		}

		public static async UniTask<IncrementPlayerStatisticVersionResult> IncrementPlayerStatisticVersionAsync(
			IncrementPlayerStatisticVersionRequest request)
		{
			return await MakeApiCallAsync<IncrementPlayerStatisticVersionRequest, IncrementPlayerStatisticVersionResult>
				("/Admin/IncrementPlayerStatisticVersion", request);
		}

		public static async UniTask<ListOpenIdConnectionResponse> ListOpenIdConnectionAsync(ListOpenIdConnectionRequest request)
		{
			return await MakeApiCallAsync<ListOpenIdConnectionRequest, ListOpenIdConnectionResponse>
				("/Admin/ListOpenIdConnection", request);
		}

		public static async UniTask<ListVirtualCurrencyTypesResult> ListVirtualCurrencyTypesAsync(ListVirtualCurrencyTypesRequest request)
		{
			return await MakeApiCallAsync<ListVirtualCurrencyTypesRequest, ListVirtualCurrencyTypesResult>
				("/Admin/ListVirtualCurrencyTypes", request);
		}

		public static async UniTask<RefundPurchaseResponse> RefundPurchaseAsync(RefundPurchaseRequest request)
		{
			return await MakeApiCallAsync<RefundPurchaseRequest, RefundPurchaseResponse>("/Admin/RefundPurchase", request);
		}

		public static async UniTask<RemovePlayerTagResult> RemovePlayerTagAsync(RemovePlayerTagRequest request)
		{
			return await MakeApiCallAsync<RemovePlayerTagRequest, RemovePlayerTagResult>("/Admin/RemovePlayerTag", request);
		}

		public static async UniTask<BlankResult> RemoveVirtualCurrencyTypesAsync(RemoveVirtualCurrencyTypesRequest request)
		{
			return await MakeApiCallAsync<RemoveVirtualCurrencyTypesRequest, BlankResult>("/Admin/RemoveVirtualCurrencyTypes", request);
		}

		public static async UniTask<ResetCharacterStatisticsResult> ResetCharacterStatisticsAsync(ResetCharacterStatisticsRequest request)
		{
			return await MakeApiCallAsync<ResetCharacterStatisticsRequest, ResetCharacterStatisticsResult>
				("/Admin/ResetCharacterStatistics", request);
		}

		public static async UniTask<ResetPasswordResult> ResetPasswordAsync(ResetPasswordRequest request)
		{
			return await MakeApiCallAsync<ResetPasswordRequest, ResetPasswordResult>("/Admin/ResetPassword", request);
		}

		public static async UniTask<ResetUserStatisticsResult> ResetUserStatisticsAsync(ResetUserStatisticsRequest request)
		{
			return await MakeApiCallAsync<ResetUserStatisticsRequest, ResetUserStatisticsResult>("/Admin/ResetUserStatistics", request);
		}

		public static async UniTask<ResolvePurchaseDisputeResponse> ResolvePurchaseDisputeAsync(ResolvePurchaseDisputeRequest request)
		{
			return await MakeApiCallAsync<ResolvePurchaseDisputeRequest, ResolvePurchaseDisputeResponse>
				("/Admin/ResolvePurchaseDispute", request);
		}

		public static async UniTask<RevokeAllBansForUserResult> RevokeAllBansForUserAsync(RevokeAllBansForUserRequest request)
		{
			return await MakeApiCallAsync<RevokeAllBansForUserRequest, RevokeAllBansForUserResult>("/Admin/RevokeAllBansForUser", request);
		}

		public static async UniTask<RevokeBansResult> RevokeBansAsync(RevokeBansRequest request)
		{
			return await MakeApiCallAsync<RevokeBansRequest, RevokeBansResult>("/Admin/RevokeBans", request);
		}

		public static async UniTask<RevokeInventoryResult> RevokeInventoryItemAsync(RevokeInventoryItemRequest request)
		{
			return await MakeApiCallAsync<RevokeInventoryItemRequest, RevokeInventoryResult>("/Admin/RevokeInventoryItem", request);
		}

		public static async UniTask<RevokeInventoryItemsResult> RevokeInventoryItemsAsync(RevokeInventoryItemsRequest request)
		{
			return await MakeApiCallAsync<RevokeInventoryItemsRequest, RevokeInventoryItemsResult>("/Admin/RevokeInventoryItems", request);
		}

		public static async UniTask<RunTaskResult> RunTaskAsync(RunTaskRequest request)
		{
			return await MakeApiCallAsync<RunTaskRequest, RunTaskResult>("/Admin/RunTask", request);
		}

		public static async UniTask<SendAccountRecoveryEmailResult> SendAccountRecoveryEmailAsync(SendAccountRecoveryEmailRequest request)
		{
			return await MakeApiCallAsync<SendAccountRecoveryEmailRequest, SendAccountRecoveryEmailResult>
				("/Admin/SendAccountRecoveryEmail", request);
		}

		public static async UniTask<UpdateCatalogItemsResult> SetCatalogItemsAsync(UpdateCatalogItemsRequest request)
		{
			return await MakeApiCallAsync<UpdateCatalogItemsRequest, UpdateCatalogItemsResult>("/Admin/SetCatalogItems", request);
		}

		public static async UniTask<SetMembershipOverrideResult> SetMembershipOverrideAsync(SetMembershipOverrideRequest request)
		{
			return await MakeApiCallAsync<SetMembershipOverrideRequest, SetMembershipOverrideResult>
				("/Admin/SetMembershipOverride", request);
		}

		public static async UniTask<SetPlayerSecretResult> SetPlayerSecretAsync(SetPlayerSecretRequest request)
		{
			return await MakeApiCallAsync<SetPlayerSecretRequest, SetPlayerSecretResult>("/Admin/SetPlayerSecret", request);
		}

		public static async UniTask<SetPublishedRevisionResult> SetPublishedRevisionAsync(SetPublishedRevisionRequest request)
		{
			return await MakeApiCallAsync<SetPublishedRevisionRequest, SetPublishedRevisionResult>("/Admin/SetPublishedRevision", request);
		}

		public static async UniTask<SetPublisherDataResult> SetPublisherDataAsync(SetPublisherDataRequest request)
		{
			return await MakeApiCallAsync<SetPublisherDataRequest, SetPublisherDataResult>("/Admin/SetPublisherData", request);
		}

		public static async UniTask<UpdateStoreItemsResult> SetStoreItemsAsync(UpdateStoreItemsRequest request)
		{
			return await MakeApiCallAsync<UpdateStoreItemsRequest, UpdateStoreItemsResult>("/Admin/SetStoreItems", request);
		}

		public static async UniTask<SetTitleDataResult> SetTitleDataAsync(SetTitleDataRequest request)
		{
			return await MakeApiCallAsync<SetTitleDataRequest, SetTitleDataResult>("/Admin/SetTitleData", request);
		}

		public static async UniTask<SetTitleDataAndOverridesResult> SetTitleDataAndOverridesAsync(SetTitleDataAndOverridesRequest request)
		{
			return await MakeApiCallAsync<SetTitleDataAndOverridesRequest, SetTitleDataAndOverridesResult>
				("/Admin/SetTitleDataAndOverrides", request);
		}

		public static async UniTask<SetTitleDataResult> SetTitleInternalDataAsync(SetTitleDataRequest request)
		{
			return await MakeApiCallAsync<SetTitleDataRequest, SetTitleDataResult>("/Admin/SetTitleInternalData", request);
		}

		public static async UniTask<SetupPushNotificationResult> SetupPushNotificationAsync(SetupPushNotificationRequest request)
		{
			return await MakeApiCallAsync<SetupPushNotificationRequest, SetupPushNotificationResult>
				("/Admin/SetupPushNotification", request);
		}

		public static async UniTask<ModifyUserVirtualCurrencyResult> SubtractUserVirtualCurrencyAsync(
			SubtractUserVirtualCurrencyRequest request)
		{
			return await MakeApiCallAsync<SubtractUserVirtualCurrencyRequest, ModifyUserVirtualCurrencyResult>
				("/Admin/SubtractUserVirtualCurrency", request);
		}

		public static async UniTask<UpdateBansResult> UpdateBansAsync(UpdateBansRequest request)
		{
			return await MakeApiCallAsync<UpdateBansRequest, UpdateBansResult>("/Admin/UpdateBans", request);
		}

		public static async UniTask<UpdateCatalogItemsResult> UpdateCatalogItemsAsync(UpdateCatalogItemsRequest request)
		{
			return await MakeApiCallAsync<UpdateCatalogItemsRequest, UpdateCatalogItemsResult>("/Admin/UpdateCatalogItems", request);
		}

		public static async UniTask<UpdateCloudScriptResult> UpdateCloudScriptAsync(UpdateCloudScriptRequest request)
		{
			return await MakeApiCallAsync<UpdateCloudScriptRequest, UpdateCloudScriptResult>("/Admin/UpdateCloudScript", request);
		}

		public static async UniTask<EmptyResponse> UpdateOpenIdConnectionAsync(UpdateOpenIdConnectionRequest request)
		{
			return await MakeApiCallAsync<UpdateOpenIdConnectionRequest, EmptyResponse>("/Admin/UpdateOpenIdConnection", request);
		}

		public static async UniTask<UpdatePlayerSharedSecretResult> UpdatePlayerSharedSecretAsync(UpdatePlayerSharedSecretRequest request)
		{
			return await MakeApiCallAsync<UpdatePlayerSharedSecretRequest, UpdatePlayerSharedSecretResult>
				("/Admin/UpdatePlayerSharedSecret", request);
		}

		public static async UniTask<UpdatePlayerStatisticDefinitionResult> UpdatePlayerStatisticDefinitionAsync(
			UpdatePlayerStatisticDefinitionRequest request)
		{
			return await MakeApiCallAsync<UpdatePlayerStatisticDefinitionRequest, UpdatePlayerStatisticDefinitionResult>
				("/Admin/UpdatePlayerStatisticDefinition", request);
		}

		public static async UniTask<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request)
		{
			return await MakeApiCallAsync<UpdatePolicyRequest, UpdatePolicyResponse>("/Admin/UpdatePolicy", request);
		}

		public static async UniTask<UpdateRandomResultTablesResult> UpdateRandomResultTablesAsync(UpdateRandomResultTablesRequest request)
		{
			return await MakeApiCallAsync<UpdateRandomResultTablesRequest, UpdateRandomResultTablesResult>
				("/Admin/UpdateRandomResultTables", request);
		}

		public static async UniTask<UpdateSegmentResponse> UpdateSegmentAsync(UpdateSegmentRequest request)
		{
			return await MakeApiCallAsync<UpdateSegmentRequest, UpdateSegmentResponse>("/Admin/UpdateSegment", request);
		}

		public static async UniTask<UpdateStoreItemsResult> UpdateStoreItemsAsync(UpdateStoreItemsRequest request)
		{
			return await MakeApiCallAsync<UpdateStoreItemsRequest, UpdateStoreItemsResult>("/Admin/UpdateStoreItems", request);
		}

		public static async UniTask<EmptyResponse> UpdateTaskAsync(UpdateTaskRequest request)
		{
			return await MakeApiCallAsync<UpdateTaskRequest, EmptyResponse>("/Admin/UpdateTask", request);
		}

		public static async UniTask<UpdateUserDataResult> UpdateUserDataAsync(UpdateUserDataRequest request)
		{
			return await MakeApiCallAsync<UpdateUserDataRequest, UpdateUserDataResult>("/Admin/UpdateUserData", request);
		}

		public static async UniTask<UpdateUserDataResult> UpdateUserInternalDataAsync(UpdateUserInternalDataRequest request)
		{
			return await MakeApiCallAsync<UpdateUserInternalDataRequest, UpdateUserDataResult>("/Admin/UpdateUserInternalData", request);
		}

		public static async UniTask<UpdateUserDataResult> UpdateUserPublisherDataAsync(UpdateUserDataRequest request)
		{
			return await MakeApiCallAsync<UpdateUserDataRequest, UpdateUserDataResult>("/Admin/UpdateUserPublisherData", request);
		}

		public static async UniTask<UpdateUserDataResult> UpdateUserPublisherInternalDataAsync(UpdateUserInternalDataRequest request)
		{
			return await MakeApiCallAsync<UpdateUserInternalDataRequest, UpdateUserDataResult>
				("/Admin/UpdateUserPublisherInternalData", request);
		}

		public static async UniTask<UpdateUserDataResult> UpdateUserPublisherReadOnlyDataAsync(UpdateUserDataRequest request)
		{
			return await MakeApiCallAsync<UpdateUserDataRequest, UpdateUserDataResult>("/Admin/UpdateUserPublisherReadOnlyData", request);
		}

		public static async UniTask<UpdateUserDataResult> UpdateUserReadOnlyDataAsync(UpdateUserDataRequest request)
		{
			return await MakeApiCallAsync<UpdateUserDataRequest, UpdateUserDataResult>("/Admin/UpdateUserReadOnlyData", request);
		}

		public static async UniTask<UpdateUserTitleDisplayNameResult> UpdateUserTitleDisplayNameAsync(
			UpdateUserTitleDisplayNameRequest request)
		{
			return await MakeApiCallAsync<UpdateUserTitleDisplayNameRequest, UpdateUserTitleDisplayNameResult>
				("/Admin/UpdateUserTitleDisplayName", request);
		}


		private static async UniTask<TResultType> MakeApiCallAsync<TRequestType, TResultType>(string apiEndpoint, TRequestType request)
			where TRequestType : PlayFabRequestCommon where TResultType : PlayFabResultCommon
		{
			var tcs = new UniTaskCompletionSource<TResultType>();

			PlayFabHttp.MakeApiCall<TResultType>
			(
				apiEndpoint, request, AuthType.DevSecretKey, resultCallback : result => tcs.TrySetResult(result),
				errorCallback : error => tcs.TrySetException(new Exception(error.ErrorMessage)), customData : null, extraHeaders : null,
				authenticationContext : request.AuthenticationContext ?? PlayFabSettings.staticPlayer,
				apiSettings : PlayFabSettings.staticSettings, instanceApi : null
			);

			try
			{
				return await tcs.Task;
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError($"API call to {apiEndpoint} failed: {ex.Message}");

				throw;
			}
		}
	}
}
#endif
