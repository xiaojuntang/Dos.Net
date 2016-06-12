﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace Zxxk.Dos.DataModel
{

	/// <summary>
	/// 实体类HomeWork 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TX_HomeWork")]
	[Serializable]
	public partial class HomeWork : Entity 
	{
		#region Model
		private int _HomeWorkID;
		private string _OpenID;
		private DateTime? _CreateDate;
		private string _Comment;
		private string _HomeWorkName;
		private int? _BankID;
		private int? _TeachMaterialID;
		private string _TeachMaterialName;
		private string _QuesTypeIDs;
		private string _QuesTypeNames;
		private string _CategoryNames;
		private int? _Deleted;
		private int? _GradeID;
		private string _GradeName;
		private string _ChapterName;
		private int? _TRType;
		private string _TencentID;
		/// <summary>
		/// 作业ID
		/// </summary>
		public int HomeWorkID
		{
			get{ return _HomeWorkID; }
			set
			{
				this.OnPropertyValueChange(_.HomeWorkID,_HomeWorkID,value);
				this._HomeWorkID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OpenID
		{
			get{ return _OpenID; }
			set
			{
				this.OnPropertyValueChange(_.OpenID,_OpenID,value);
				this._OpenID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDate
		{
			get{ return _CreateDate; }
			set
			{
				this.OnPropertyValueChange(_.CreateDate,_CreateDate,value);
				this._CreateDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Comment
		{
			get{ return _Comment; }
			set
			{
				this.OnPropertyValueChange(_.Comment,_Comment,value);
				this._Comment=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HomeWorkName
		{
			get{ return _HomeWorkName; }
			set
			{
				this.OnPropertyValueChange(_.HomeWorkName,_HomeWorkName,value);
				this._HomeWorkName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BankID
		{
			get{ return _BankID; }
			set
			{
				this.OnPropertyValueChange(_.BankID,_BankID,value);
				this._BankID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TeachMaterialID
		{
			get{ return _TeachMaterialID; }
			set
			{
				this.OnPropertyValueChange(_.TeachMaterialID,_TeachMaterialID,value);
				this._TeachMaterialID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TeachMaterialName
		{
			get{ return _TeachMaterialName; }
			set
			{
				this.OnPropertyValueChange(_.TeachMaterialName,_TeachMaterialName,value);
				this._TeachMaterialName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QuesTypeIDs
		{
			get{ return _QuesTypeIDs; }
			set
			{
				this.OnPropertyValueChange(_.QuesTypeIDs,_QuesTypeIDs,value);
				this._QuesTypeIDs=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QuesTypeNames
		{
			get{ return _QuesTypeNames; }
			set
			{
				this.OnPropertyValueChange(_.QuesTypeNames,_QuesTypeNames,value);
				this._QuesTypeNames=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CategoryNames
		{
			get{ return _CategoryNames; }
			set
			{
				this.OnPropertyValueChange(_.CategoryNames,_CategoryNames,value);
				this._CategoryNames=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Deleted
		{
			get{ return _Deleted; }
			set
			{
				this.OnPropertyValueChange(_.Deleted,_Deleted,value);
				this._Deleted=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GradeID
		{
			get{ return _GradeID; }
			set
			{
				this.OnPropertyValueChange(_.GradeID,_GradeID,value);
				this._GradeID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GradeName
		{
			get{ return _GradeName; }
			set
			{
				this.OnPropertyValueChange(_.GradeName,_GradeName,value);
				this._GradeName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChapterName
		{
			get{ return _ChapterName; }
			set
			{
				this.OnPropertyValueChange(_.ChapterName,_ChapterName,value);
				this._ChapterName=value;
			}
		}
		/// <summary>
		/// 系统类型
		/// </summary>
		public int? TRType
		{
			get{ return _TRType; }
			set
			{
				this.OnPropertyValueChange(_.TRType,_TRType,value);
				this._TRType=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TencentID
		{
			get{ return _TencentID; }
			set
			{
				this.OnPropertyValueChange(_.TencentID,_TencentID,value);
				this._TencentID=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.HomeWorkID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.HomeWorkID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.HomeWorkID,
				_.OpenID,
				_.CreateDate,
				_.Comment,
				_.HomeWorkName,
				_.BankID,
				_.TeachMaterialID,
				_.TeachMaterialName,
				_.QuesTypeIDs,
				_.QuesTypeNames,
				_.CategoryNames,
				_.Deleted,
				_.GradeID,
				_.GradeName,
				_.ChapterName,
				_.TRType,
				_.TencentID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._HomeWorkID,
				this._OpenID,
				this._CreateDate,
				this._Comment,
				this._HomeWorkName,
				this._BankID,
				this._TeachMaterialID,
				this._TeachMaterialName,
				this._QuesTypeIDs,
				this._QuesTypeNames,
				this._CategoryNames,
				this._Deleted,
				this._GradeID,
				this._GradeName,
				this._ChapterName,
				this._TRType,
				this._TencentID};
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","TX_HomeWork");
			/// <summary>
			/// 作业ID
			/// </summary>
			public readonly static Field HomeWorkID = new Field("HomeWorkID","TX_HomeWork","作业ID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OpenID = new Field("OpenID","TX_HomeWork","OpenID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateDate = new Field("CreateDate","TX_HomeWork","CreateDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Comment = new Field("Comment","TX_HomeWork","Comment");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HomeWorkName = new Field("HomeWorkName","TX_HomeWork","HomeWorkName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BankID = new Field("BankID","TX_HomeWork","BankID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TeachMaterialID = new Field("TeachMaterialID","TX_HomeWork","TeachMaterialID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TeachMaterialName = new Field("TeachMaterialName","TX_HomeWork","TeachMaterialName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field QuesTypeIDs = new Field("QuesTypeIDs","TX_HomeWork","QuesTypeIDs");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field QuesTypeNames = new Field("QuesTypeNames","TX_HomeWork","QuesTypeNames");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CategoryNames = new Field("CategoryNames","TX_HomeWork","CategoryNames");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deleted = new Field("Deleted","TX_HomeWork","Deleted");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GradeID = new Field("GradeID","TX_HomeWork","GradeID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GradeName = new Field("GradeName","TX_HomeWork","GradeName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChapterName = new Field("ChapterName","TX_HomeWork","ChapterName");
			/// <summary>
			/// 系统类型
			/// </summary>
			public readonly static Field TRType = new Field("TRType","TX_HomeWork","系统类型");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TencentID = new Field("TencentID","TX_HomeWork","TencentID");
		}
		#endregion


	}
}

