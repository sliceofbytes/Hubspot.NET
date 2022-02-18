# HubSpot.NET.Model.PerformanceView
An individual time series performance data point.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_403** | **int** | The number of responses that had an http status code of 403. | 
**_404** | **int** | The number of responses that had an http status code of 404. | 
**_500** | **int** | The number of responses that had an http status code of 500. | 
**_504** | **int** | The number of responses that had an http status code of 504. | 
**StartTimestamp** | **long** | The timestamp in milliseconds of the start of this interval. | 
**EndTimestamp** | **long** | The timestamp in milliseconds of the end of this interval. | 
**StartDatetime** | **string** |  | 
**EndDatetime** | **string** |  | 
**TotalRequests** | **int** | The total number of requests received in this period. | 
**CacheHits** | **int** | The total number of requests that were served cached responses. | 
**CacheHitRate** | **decimal** | The percentage of requests that were served cached responses. | 
**TotalRequestTime** | **int** |  | 
**AvgOriginResponseTime** | **int** | The average response time in milliseconds from the origin to the edge. | 
**ResponseTimeMs** | **int** | The average response time in milliseconds. | 
**_100X** | **int** | The number of responses that had an http status code between 1000-1999. | 
**_20X** | **int** | The number of responses that had an http status code between 200-299. | 
**_30X** | **int** | The number of responses that had an http status code between 300-399. | 
**_40X** | **int** | The number of responses that had an http status code between 400-499. | 
**_50X** | **int** | The number of responses that had an http status code between 500-599. | 
**_50th** | **int** | The 50th percentile response time. | 
**_95th** | **int** | The 95th percentile response time. | 
**_99th** | **int** | The 99th percentile response time. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

