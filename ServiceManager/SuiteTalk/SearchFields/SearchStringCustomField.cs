//~ Generated by ISupportSearchValueNTemplate.tt
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class SearchStringCustomField 
		: ISupportSearchValue< String >,  
		  ISupportSearchOperator< com.celigo.net.ServiceManager.SuiteTalk.SearchStringFieldOperator >,
		  IBasicSearchField 
	{ 
		public String GetSearchValue()
		{
			return this.searchValue;
		}
		
				
		public void SetSearchValue(String value)
		{
			this.searchValue = value; 			
		}
		
				
	}
}

