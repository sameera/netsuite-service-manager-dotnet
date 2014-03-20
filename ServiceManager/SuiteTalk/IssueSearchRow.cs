//~ Generated by SearchRowTemplate.tt
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class IssueSearchRow
	{
		/// <summary>Gets the Search Row Basic value.</summary>
		/// <returns>The ISearchRowBasic assigned to this row.</returns>
		public override ISearchRowBasic GetSearchRowBasic()
		{
			return this.basic;
		}

		/// <summary>
		/// Sets the Search Row Basic value.
		/// </summary>
		/// <param name="basic">The ISearchRowBasic to be assigned to this row.</param>
		public override void SetSearchRowBasic(ISearchRowBasic basic)
		{
			if (basic is IssueSearchRowBasic)
				this.basic = (IssueSearchRowBasic)basic;
			else
				throw new ArgumentException("Value should be of type IssueSearchRowBasic", "basic");
		}
	}
}