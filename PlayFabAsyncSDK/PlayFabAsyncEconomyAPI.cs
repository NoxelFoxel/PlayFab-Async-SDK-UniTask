using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using PlayFab;
using PlayFab.EconomyModels;

namespace Code.PlayFabAsyncSDK
{
	public class PlayFabAsyncEconomyAPI
	{
		public static UniTask<PlayFabAsyncResult<AddInventoryItemsResponse>> AddInventoryItemsAsync(
			AddInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<AddInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.AddInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<AddInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<AddInventoryItemsResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<CreateDraftItemResponse>> CreateDraftItemAsync(
			CreateDraftItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<CreateDraftItemResponse>> tcs = new();

			PlayFabEconomyAPI.CreateDraftItem
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<CreateDraftItemResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<CreateDraftItemResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<CreateUploadUrlsResponse>> CreateUploadUrlsAsync(
			CreateUploadUrlsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<CreateUploadUrlsResponse>> tcs = new();

			PlayFabEconomyAPI.CreateUploadUrls
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<CreateUploadUrlsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<CreateUploadUrlsResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<DeleteEntityItemReviewsResponse>> DeleteEntityItemReviewsAsync(
			DeleteEntityItemReviewsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<DeleteEntityItemReviewsResponse>> tcs = new();

			PlayFabEconomyAPI.DeleteEntityItemReviews
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<DeleteEntityItemReviewsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<DeleteEntityItemReviewsResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<DeleteInventoryCollectionResponse>> DeleteInventoryCollectionAsync(
			DeleteInventoryCollectionRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<DeleteInventoryCollectionResponse>> tcs = new();

			PlayFabEconomyAPI.DeleteInventoryCollection
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<DeleteInventoryCollectionResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<DeleteInventoryCollectionResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<DeleteInventoryItemsResponse>> DeleteInventoryItemsAsync(
			DeleteInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<DeleteInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.DeleteInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<DeleteInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<DeleteInventoryItemsResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<DeleteItemResponse>> DeleteItemAsync(DeleteItemRequest request, object customData = null,
																					  Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<DeleteItemResponse>> tcs = new();

			PlayFabEconomyAPI.DeleteItem
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<DeleteItemResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<DeleteItemResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ExecuteInventoryOperationsResponse>> ExecuteInventoryOperationsAsync(
			ExecuteInventoryOperationsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ExecuteInventoryOperationsResponse>> tcs = new();

			PlayFabEconomyAPI.ExecuteInventoryOperations
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ExecuteInventoryOperationsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ExecuteInventoryOperationsResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetCatalogConfigResponse>> GetCatalogConfigAsync(
			GetCatalogConfigRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetCatalogConfigResponse>> tcs = new();

			PlayFabEconomyAPI.GetCatalogConfig
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetCatalogConfigResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetCatalogConfigResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetDraftItemResponse>> GetDraftItemAsync(
			GetDraftItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetDraftItemResponse>> tcs = new();

			PlayFabEconomyAPI.GetDraftItem
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetDraftItemResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetDraftItemResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetDraftItemsResponse>> GetDraftItemsAsync(
			GetDraftItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetDraftItemsResponse>> tcs = new();

			PlayFabEconomyAPI.GetDraftItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetDraftItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetDraftItemsResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetEntityDraftItemsResponse>> GetEntityDraftItemsAsync(
			GetEntityDraftItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetEntityDraftItemsResponse>> tcs = new();

			PlayFabEconomyAPI.GetEntityDraftItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetEntityDraftItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetEntityDraftItemsResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetEntityItemReviewResponse>> GetEntityItemReviewAsync(
			GetEntityItemReviewRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetEntityItemReviewResponse>> tcs = new();

			PlayFabEconomyAPI.GetEntityItemReview
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetEntityItemReviewResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetEntityItemReviewResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetInventoryCollectionIdsResponse>> GetInventoryCollectionIdsAsync(
			GetInventoryCollectionIdsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetInventoryCollectionIdsResponse>> tcs = new();

			PlayFabEconomyAPI.GetInventoryCollectionIds
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetInventoryCollectionIdsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetInventoryCollectionIdsResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetInventoryItemsResponse>> GetInventoryItemsAsync(
			GetInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.GetInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetInventoryItemsResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetItemResponse>> GetItemAsync(GetItemRequest request, object customData = null,
																				Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetItemResponse>> tcs = new();

			PlayFabEconomyAPI.GetItem
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetItemContainersResponse>> GetItemContainersAsync(
			GetItemContainersRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetItemContainersResponse>> tcs = new();

			PlayFabEconomyAPI.GetItemContainers
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemContainersResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemContainersResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetItemModerationStateResponse>> GetItemModerationStateAsync(
			GetItemModerationStateRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetItemModerationStateResponse>> tcs = new();

			PlayFabEconomyAPI.GetItemModerationState
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemModerationStateResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemModerationStateResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetItemPublishStatusResponse>> GetItemPublishStatusAsync(
			GetItemPublishStatusRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetItemPublishStatusResponse>> tcs = new();

			PlayFabEconomyAPI.GetItemPublishStatus
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemPublishStatusResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemPublishStatusResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetItemReviewsResponse>> GetItemReviewsAsync(
			GetItemReviewsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetItemReviewsResponse>> tcs = new();

			PlayFabEconomyAPI.GetItemReviews
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemReviewsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemReviewsResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetItemReviewSummaryResponse>> GetItemReviewSummaryAsync(
			GetItemReviewSummaryRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetItemReviewSummaryResponse>> tcs = new();

			PlayFabEconomyAPI.GetItemReviewSummary
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemReviewSummaryResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemReviewSummaryResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetItemsResponse>> GetItemsAsync(GetItemsRequest request, object customData = null,
																				  Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetItemsResponse>> tcs = new();

			PlayFabEconomyAPI.GetItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetItemsResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetMicrosoftStoreAccessTokensResponse>> GetMicrosoftStoreAccessTokensAsync(
			GetMicrosoftStoreAccessTokensRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetMicrosoftStoreAccessTokensResponse>> tcs = new();

			PlayFabEconomyAPI.GetMicrosoftStoreAccessTokens
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetMicrosoftStoreAccessTokensResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetMicrosoftStoreAccessTokensResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetTransactionHistoryResponse>> GetTransactionHistoryAsync(
			GetTransactionHistoryRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetTransactionHistoryResponse>> tcs = new();

			PlayFabEconomyAPI.GetTransactionHistory
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetTransactionHistoryResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetTransactionHistoryResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<PublishDraftItemResponse>> PublishDraftItemAsync(
			PublishDraftItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<PublishDraftItemResponse>> tcs = new();

			PlayFabEconomyAPI.PublishDraftItem
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<PublishDraftItemResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<PublishDraftItemResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<PurchaseInventoryItemsResponse>> PurchaseInventoryItemsAsync(
			PurchaseInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<PurchaseInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.PurchaseInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<PurchaseInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<PurchaseInventoryItemsResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RedeemAppleAppStoreInventoryItemsResponse>> RedeemAppleAppStoreInventoryItemsAsync(
			RedeemAppleAppStoreInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RedeemAppleAppStoreInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.RedeemAppleAppStoreInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemAppleAppStoreInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemAppleAppStoreInventoryItemsResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RedeemGooglePlayInventoryItemsResponse>> RedeemGooglePlayInventoryItemsAsync(
			RedeemGooglePlayInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RedeemGooglePlayInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.RedeemGooglePlayInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemGooglePlayInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemGooglePlayInventoryItemsResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RedeemMicrosoftStoreInventoryItemsResponse>> RedeemMicrosoftStoreInventoryItemsAsync(
			RedeemMicrosoftStoreInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RedeemMicrosoftStoreInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.RedeemMicrosoftStoreInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemMicrosoftStoreInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemMicrosoftStoreInventoryItemsResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RedeemNintendoEShopInventoryItemsResponse>> RedeemNintendoEShopInventoryItemsAsync(
			RedeemNintendoEShopInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RedeemNintendoEShopInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.RedeemNintendoEShopInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemNintendoEShopInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemNintendoEShopInventoryItemsResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RedeemPlayStationStoreInventoryItemsResponse>> RedeemPlayStationStoreInventoryItemsAsync(
			RedeemPlayStationStoreInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RedeemPlayStationStoreInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.RedeemPlayStationStoreInventoryItems
			(
				request,
				result => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemPlayStationStoreInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemPlayStationStoreInventoryItemsResponse>(null, error)); },
				customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<RedeemSteamInventoryItemsResponse>> RedeemSteamInventoryItemsAsync(
			RedeemSteamInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<RedeemSteamInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.RedeemSteamInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemSteamInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<RedeemSteamInventoryItemsResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ReportItemResponse>> ReportItemAsync(ReportItemRequest request, object customData = null,
																					  Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ReportItemResponse>> tcs = new();

			PlayFabEconomyAPI.ReportItem
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ReportItemResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ReportItemResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ReportItemReviewResponse>> ReportItemReviewAsync(
			ReportItemReviewRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ReportItemReviewResponse>> tcs = new();

			PlayFabEconomyAPI.ReportItemReview
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ReportItemReviewResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ReportItemReviewResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ReviewItemResponse>> ReviewItemAsync(ReviewItemRequest request, object customData = null,
																					  Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ReviewItemResponse>> tcs = new();

			PlayFabEconomyAPI.ReviewItem
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ReviewItemResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ReviewItemResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<SearchItemsResponse>> SearchItemsAsync(
			SearchItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<SearchItemsResponse>> tcs = new();

			PlayFabEconomyAPI.SearchItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<SearchItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<SearchItemsResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<SetItemModerationStateResponse>> SetItemModerationStateAsync(
			SetItemModerationStateRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<SetItemModerationStateResponse>> tcs = new();

			PlayFabEconomyAPI.SetItemModerationState
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<SetItemModerationStateResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<SetItemModerationStateResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<SubmitItemReviewVoteResponse>> SubmitItemReviewVoteAsync(
			SubmitItemReviewVoteRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<SubmitItemReviewVoteResponse>> tcs = new();

			PlayFabEconomyAPI.SubmitItemReviewVote
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<SubmitItemReviewVoteResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<SubmitItemReviewVoteResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<SubtractInventoryItemsResponse>> SubtractInventoryItemsAsync(
			SubtractInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<SubtractInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.SubtractInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<SubtractInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<SubtractInventoryItemsResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<TakedownItemReviewsResponse>> TakedownItemReviewsAsync(
			TakedownItemReviewsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<TakedownItemReviewsResponse>> tcs = new();

			PlayFabEconomyAPI.TakedownItemReviews
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<TakedownItemReviewsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<TakedownItemReviewsResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<TransferInventoryItemsResponse>> TransferInventoryItemsAsync(
			TransferInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<TransferInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.TransferInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<TransferInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<TransferInventoryItemsResponse>(null, error)); }, customData,
				extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UpdateCatalogConfigResponse>> UpdateCatalogConfigAsync(
			UpdateCatalogConfigRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UpdateCatalogConfigResponse>> tcs = new();

			PlayFabEconomyAPI.UpdateCatalogConfig
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateCatalogConfigResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateCatalogConfigResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UpdateDraftItemResponse>> UpdateDraftItemAsync(
			UpdateDraftItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UpdateDraftItemResponse>> tcs = new();

			PlayFabEconomyAPI.UpdateDraftItem
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateDraftItemResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateDraftItemResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<UpdateInventoryItemsResponse>> UpdateInventoryItemsAsync(
			UpdateInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<UpdateInventoryItemsResponse>> tcs = new();

			PlayFabEconomyAPI.UpdateInventoryItems
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateInventoryItemsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<UpdateInventoryItemsResponse>(null, error)); }, customData, extraHeaders
			);

			return tcs.Task;
		}
	}
}
