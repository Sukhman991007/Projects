#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CBDS
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Sukhman_Lidder_ConsultantsdB")]
	public partial class CBDSDataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public CBDSDataClassDataContext() : 
				base(global::CBDS.Properties.Settings.Default.Setting, mappingSource)
		{
			OnCreated();
		}
		
		public CBDSDataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CBDSDataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CBDSDataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CBDSDataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Sproc_FindNextMedicalCentreNo")]
		public ISingleResult<Sproc_FindNextMedicalCentreNoResult> Sproc_FindNextMedicalCentreNo()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Sproc_FindNextMedicalCentreNoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Sproc_FindMedicalGroup")]
		public ISingleResult<Sproc_FindMedicalGroupResult> Sproc_FindMedicalGroup([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(3)")] string ssl_MedicalGroupCode)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ssl_MedicalGroupCode);
			return ((ISingleResult<Sproc_FindMedicalGroupResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sproc_P2428097_tblPracticeGpNo_GetDaysPerWeek")]
		public ISingleResult<sproc_P2428097_tblPracticeGpNo_GetDaysPerWeekResult> sproc_P2428097_tblPracticeGpNo_GetDaysPerWeek([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> ssl_PracticeGpNO)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ssl_PracticeGpNO);
			return ((ISingleResult<sproc_P2428097_tblPracticeGpNo_GetDaysPerWeekResult>)(result.ReturnValue));
		}
	}
	
	public partial class Sproc_FindNextMedicalCentreNoResult
	{
		
		private int _ssl_MedicalCentreNo;
		
		public Sproc_FindNextMedicalCentreNoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ssl_MedicalCentreNo", DbType="Int NOT NULL")]
		public int ssl_MedicalCentreNo
		{
			get
			{
				return this._ssl_MedicalCentreNo;
			}
			set
			{
				if ((this._ssl_MedicalCentreNo != value))
				{
					this._ssl_MedicalCentreNo = value;
				}
			}
		}
	}
	
	public partial class Sproc_FindMedicalGroupResult
	{
		
		private string _ssl_Name;
		
		public Sproc_FindMedicalGroupResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ssl_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string ssl_Name
		{
			get
			{
				return this._ssl_Name;
			}
			set
			{
				if ((this._ssl_Name != value))
				{
					this._ssl_Name = value;
				}
			}
		}
	}
	
	public partial class sproc_P2428097_tblPracticeGpNo_GetDaysPerWeekResult
	{
		
		private System.Nullable<byte> _ssl_DaysPerWeek;
		
		public sproc_P2428097_tblPracticeGpNo_GetDaysPerWeekResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ssl_DaysPerWeek", DbType="TinyInt")]
		public System.Nullable<byte> ssl_DaysPerWeek
		{
			get
			{
				return this._ssl_DaysPerWeek;
			}
			set
			{
				if ((this._ssl_DaysPerWeek != value))
				{
					this._ssl_DaysPerWeek = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
