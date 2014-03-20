//~ Generated by SearchRowBasicTemplate.tt
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class ManufacturingOperationTaskSearchRowBasic : ISearchRowBasic, ISupportsCustomFields<SearchColumnCustomField>
	{
        /// <summary>
        /// Gets custom field with the given ID or <c>null</c> if a field with the
        /// given ID was not found.
        /// </summary>
        public T FindCustomField<T>(string fieldId) where T : SearchColumnCustomField
		{
			T match = null;
			if (null != this.customFieldList)
			{
				match = (T)Array.Find(
									this.customFieldList, 
									f => f is T && f.GetInternalId() == fieldId);
			}				
			return match;
		}
			
        /// <summary>
        /// Gets custom field with the given ID or <c>null</c> if a field with the
        /// given ID was not found.
        /// </summary>
        public SearchColumnCustomField FindCustomField(string fieldId)
		{
			SearchColumnCustomField match = null;
			if (null != this.customFieldList)
			{
				match = Array.Find(
									this.customFieldList, 
									f => f.GetInternalId() == fieldId);
			}				
			return match;
		}
	}
}
