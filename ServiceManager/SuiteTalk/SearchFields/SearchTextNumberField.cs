//~ Generated by ISupportSearchValueNTemplate.tt
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class SearchTextNumberField 
		: ISupportSearchValue< String >,  
		  ISupportSearchOperator< com.celigo.net.ServiceManager.SuiteTalk.SearchTextNumberFieldOperator >, 
		  ISupportSearchValue2< String >,
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
		
				
		public String GetSearchValue2()
		{
			return this.searchValue2;
		}
		
		public void SetSearchValue2(String value)
		{
			this.searchValue2 = value;			
		}		
	}
}

