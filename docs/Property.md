# HubSpot.NET.Model.Property
Defines a property

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UpdatedAt** | **DateTimeOffset** |  | [optional] 
**CreatedAt** | **DateTimeOffset** | When the property was created | [optional] 
**ArchivedAt** | **DateTimeOffset** | When the property was archived. | [optional] 
**Name** | **string** | The internal property name, which must be used when referencing the property via the API. | 
**Label** | **string** | A human-readable property label that will be shown in HubSpot. | 
**Type** | **string** | The property data type. | 
**FieldType** | **string** | Controls how the property appears in HubSpot. | 
**Description** | **string** | A description of the property that will be shown as help text in HubSpot. | 
**GroupName** | **string** | The name of the property group the property belongs to. | 
**Options** | [**List&lt;SchemasOption&gt;**](SchemasOption.md) | A list of valid options for the property. This field is required for enumerated properties, but will be empty for other property types. | 
**CreatedUserId** | **string** | The internal ID of the user who created the property in HubSpot. This field may not exist if the property was created outside of HubSpot. | [optional] 
**UpdatedUserId** | **string** | The internal user ID of the user who updated the property in HubSpot. This field may not exist if the property was updated outside of HubSpot. | [optional] 
**ReferencedObjectType** | **string** | If this property is related to other object(s), they&#39;ll be listed here. | [optional] 
**DisplayOrder** | **int** | The order that this property should be displayed in the HubSpot UI relative to other properties for this object type. Properties are displayed in order starting with the lowest positive integer value. A value of -1 will cause the property to be displayed **after** any positive values. | [optional] 
**Calculated** | **bool** | For default properties, true indicates that the property is calculated by a HubSpot process. It has no effect for custom properties. | [optional] 
**ExternalOptions** | **bool** | For default properties, true indicates that the options are stored externally to the property settings. | [optional] 
**Archived** | **bool** | Whether or not the property is archived. | [optional] 
**HasUniqueValue** | **bool** | Whether or not the property&#39;s value must be unique. Once set, this can&#39;t be changed. | [optional] 
**Hidden** | **bool** |  | [optional] 
**HubspotDefined** | **bool** | This will be true for default object properties built into HubSpot. | [optional] 
**ShowCurrencySymbol** | **bool** | Whether the property will display the currency symbol set in the account settings. | [optional] 
**ModificationMetadata** | [**PropertyModificationMetadata**](PropertyModificationMetadata.md) |  | [optional] 
**FormField** | **bool** | Whether or not the property can be used in a HubSpot form. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

