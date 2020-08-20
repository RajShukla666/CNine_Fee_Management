﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNINE_Fee_Management
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="cNine_Student_Detail")]
	public partial class MyDB_SDDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLKG(LKG instance);
    partial void UpdateLKG(LKG instance);
    partial void DeleteLKG(LKG instance);
    #endregion
		
		public MyDB_SDDataContext() : 
				base(global::CNINE_Fee_Management.Properties.Settings.Default.cNine_Student_DetailConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDB_SDDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDB_SDDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDB_SDDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDB_SDDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LKG> LKGs
		{
			get
			{
				return this.GetTable<LKG>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.lk_insertLKG")]
		public int lk_insertLKG([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string fatherName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string motherName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(4)")] string srNo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DateOfBirth", DbType="VarChar(12)")] string dateOfBirth, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DateOfAdmission", DbType="VarChar(12)")] string dateOfAdmission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="class", DbType="VarChar(3)")] string @class, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1)")] string section, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string contactNo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string address, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string adharNo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(5)")] string cast, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string religion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string preSchool)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, fatherName, motherName, srNo, dateOfBirth, dateOfAdmission, @class, section, contactNo, address, adharNo, cast, religion, preSchool);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.lk_updateLKG")]
		public int lk_updateLKG([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string fatherName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string motherName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(4)")] string srNo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DateOfBirth", DbType="VarChar(12)")] string dateOfBirth, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DateOfAdmission", DbType="VarChar(12)")] string dateOfAdmission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="class", DbType="VarChar(3)")] string @class, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1)")] string section, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string contactNo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string address, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string adharNo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(5)")] string cast, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string religion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string preSchool, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LKG_ID", DbType="Int")] System.Nullable<int> lKG_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, fatherName, motherName, srNo, dateOfBirth, dateOfAdmission, @class, section, contactNo, address, adharNo, cast, religion, preSchool, lKG_ID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.lk_deleteLKG")]
		public int lk_deleteLKG([global::System.Data.Linq.Mapping.ParameterAttribute(Name="LKG_ID", DbType="Int")] System.Nullable<int> lKG_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), lKG_ID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.lk_getLKG")]
		public ISingleResult<lk_getLKGResult> lk_getLKG()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<lk_getLKGResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.lk_searchLKG")]
		public ISingleResult<lk_searchLKGResult> lk_searchLKG([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string data)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), data);
			return ((ISingleResult<lk_searchLKGResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LKG")]
	public partial class LKG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _lk_id;
		
		private string _lk_name;
		
		private string _lk_fatherName;
		
		private string _lk_motherNmae;
		
		private string _lk_SrNo;
		
		private string _lk_DOB;
		
		private string _lk_DOA;
		
		private string _lk_class;
		
		private string _lk_section;
		
		private string _lk_contactNo;
		
		private string _lk_address;
		
		private string _lk_adharNo;
		
		private string _lk_cast;
		
		private string _lk_religion;
		
		private string _lk_preSchool;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onlk_idChanging(int value);
    partial void Onlk_idChanged();
    partial void Onlk_nameChanging(string value);
    partial void Onlk_nameChanged();
    partial void Onlk_fatherNameChanging(string value);
    partial void Onlk_fatherNameChanged();
    partial void Onlk_motherNmaeChanging(string value);
    partial void Onlk_motherNmaeChanged();
    partial void Onlk_SrNoChanging(string value);
    partial void Onlk_SrNoChanged();
    partial void Onlk_DOBChanging(string value);
    partial void Onlk_DOBChanged();
    partial void Onlk_DOAChanging(string value);
    partial void Onlk_DOAChanged();
    partial void Onlk_classChanging(string value);
    partial void Onlk_classChanged();
    partial void Onlk_sectionChanging(string value);
    partial void Onlk_sectionChanged();
    partial void Onlk_contactNoChanging(string value);
    partial void Onlk_contactNoChanged();
    partial void Onlk_addressChanging(string value);
    partial void Onlk_addressChanged();
    partial void Onlk_adharNoChanging(string value);
    partial void Onlk_adharNoChanged();
    partial void Onlk_castChanging(string value);
    partial void Onlk_castChanged();
    partial void Onlk_religionChanging(string value);
    partial void Onlk_religionChanged();
    partial void Onlk_preSchoolChanging(string value);
    partial void Onlk_preSchoolChanged();
    #endregion
		
		public LKG()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int lk_id
		{
			get
			{
				return this._lk_id;
			}
			set
			{
				if ((this._lk_id != value))
				{
					this.Onlk_idChanging(value);
					this.SendPropertyChanging();
					this._lk_id = value;
					this.SendPropertyChanged("lk_id");
					this.Onlk_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lk_name
		{
			get
			{
				return this._lk_name;
			}
			set
			{
				if ((this._lk_name != value))
				{
					this.Onlk_nameChanging(value);
					this.SendPropertyChanging();
					this._lk_name = value;
					this.SendPropertyChanged("lk_name");
					this.Onlk_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_fatherName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lk_fatherName
		{
			get
			{
				return this._lk_fatherName;
			}
			set
			{
				if ((this._lk_fatherName != value))
				{
					this.Onlk_fatherNameChanging(value);
					this.SendPropertyChanging();
					this._lk_fatherName = value;
					this.SendPropertyChanged("lk_fatherName");
					this.Onlk_fatherNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_motherNmae", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lk_motherNmae
		{
			get
			{
				return this._lk_motherNmae;
			}
			set
			{
				if ((this._lk_motherNmae != value))
				{
					this.Onlk_motherNmaeChanging(value);
					this.SendPropertyChanging();
					this._lk_motherNmae = value;
					this.SendPropertyChanged("lk_motherNmae");
					this.Onlk_motherNmaeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_SrNo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lk_SrNo
		{
			get
			{
				return this._lk_SrNo;
			}
			set
			{
				if ((this._lk_SrNo != value))
				{
					this.Onlk_SrNoChanging(value);
					this.SendPropertyChanging();
					this._lk_SrNo = value;
					this.SendPropertyChanged("lk_SrNo");
					this.Onlk_SrNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_DOB", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string lk_DOB
		{
			get
			{
				return this._lk_DOB;
			}
			set
			{
				if ((this._lk_DOB != value))
				{
					this.Onlk_DOBChanging(value);
					this.SendPropertyChanging();
					this._lk_DOB = value;
					this.SendPropertyChanged("lk_DOB");
					this.Onlk_DOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_DOA", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string lk_DOA
		{
			get
			{
				return this._lk_DOA;
			}
			set
			{
				if ((this._lk_DOA != value))
				{
					this.Onlk_DOAChanging(value);
					this.SendPropertyChanging();
					this._lk_DOA = value;
					this.SendPropertyChanged("lk_DOA");
					this.Onlk_DOAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_class", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string lk_class
		{
			get
			{
				return this._lk_class;
			}
			set
			{
				if ((this._lk_class != value))
				{
					this.Onlk_classChanging(value);
					this.SendPropertyChanging();
					this._lk_class = value;
					this.SendPropertyChanged("lk_class");
					this.Onlk_classChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_section", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string lk_section
		{
			get
			{
				return this._lk_section;
			}
			set
			{
				if ((this._lk_section != value))
				{
					this.Onlk_sectionChanging(value);
					this.SendPropertyChanging();
					this._lk_section = value;
					this.SendPropertyChanged("lk_section");
					this.Onlk_sectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_contactNo", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string lk_contactNo
		{
			get
			{
				return this._lk_contactNo;
			}
			set
			{
				if ((this._lk_contactNo != value))
				{
					this.Onlk_contactNoChanging(value);
					this.SendPropertyChanging();
					this._lk_contactNo = value;
					this.SendPropertyChanged("lk_contactNo");
					this.Onlk_contactNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lk_address
		{
			get
			{
				return this._lk_address;
			}
			set
			{
				if ((this._lk_address != value))
				{
					this.Onlk_addressChanging(value);
					this.SendPropertyChanging();
					this._lk_address = value;
					this.SendPropertyChanged("lk_address");
					this.Onlk_addressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_adharNo", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string lk_adharNo
		{
			get
			{
				return this._lk_adharNo;
			}
			set
			{
				if ((this._lk_adharNo != value))
				{
					this.Onlk_adharNoChanging(value);
					this.SendPropertyChanging();
					this._lk_adharNo = value;
					this.SendPropertyChanged("lk_adharNo");
					this.Onlk_adharNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_cast", DbType="VarChar(4) NOT NULL", CanBeNull=false)]
		public string lk_cast
		{
			get
			{
				return this._lk_cast;
			}
			set
			{
				if ((this._lk_cast != value))
				{
					this.Onlk_castChanging(value);
					this.SendPropertyChanging();
					this._lk_cast = value;
					this.SendPropertyChanged("lk_cast");
					this.Onlk_castChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_religion", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string lk_religion
		{
			get
			{
				return this._lk_religion;
			}
			set
			{
				if ((this._lk_religion != value))
				{
					this.Onlk_religionChanging(value);
					this.SendPropertyChanging();
					this._lk_religion = value;
					this.SendPropertyChanged("lk_religion");
					this.Onlk_religionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lk_preSchool", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lk_preSchool
		{
			get
			{
				return this._lk_preSchool;
			}
			set
			{
				if ((this._lk_preSchool != value))
				{
					this.Onlk_preSchoolChanging(value);
					this.SendPropertyChanging();
					this._lk_preSchool = value;
					this.SendPropertyChanged("lk_preSchool");
					this.Onlk_preSchoolChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class lk_getLKGResult
	{
		
		private int _ID;
		
		private string _Name;
		
		private string _FatherName;
		
		private string _MotherName;
		
		private string _SrNo;
		
		private string _DateOfBirth;
		
		private string _DateOfAdmission;
		
		private string _Class;
		
		private string _Section;
		
		private string _ContactNo;
		
		private string _Address;
		
		private string _AdharNo;
		
		private string _Cast;
		
		private string _Religion;
		
		private string _PreSchool;
		
		public lk_getLKGResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FatherName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FatherName
		{
			get
			{
				return this._FatherName;
			}
			set
			{
				if ((this._FatherName != value))
				{
					this._FatherName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotherName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MotherName
		{
			get
			{
				return this._MotherName;
			}
			set
			{
				if ((this._MotherName != value))
				{
					this._MotherName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SrNo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SrNo
		{
			get
			{
				return this._SrNo;
			}
			set
			{
				if ((this._SrNo != value))
				{
					this._SrNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this._DateOfBirth = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfAdmission", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string DateOfAdmission
		{
			get
			{
				return this._DateOfAdmission;
			}
			set
			{
				if ((this._DateOfAdmission != value))
				{
					this._DateOfAdmission = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string Class
		{
			get
			{
				return this._Class;
			}
			set
			{
				if ((this._Class != value))
				{
					this._Class = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Section", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string Section
		{
			get
			{
				return this._Section;
			}
			set
			{
				if ((this._Section != value))
				{
					this._Section = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactNo", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string ContactNo
		{
			get
			{
				return this._ContactNo;
			}
			set
			{
				if ((this._ContactNo != value))
				{
					this._ContactNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdharNo", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string AdharNo
		{
			get
			{
				return this._AdharNo;
			}
			set
			{
				if ((this._AdharNo != value))
				{
					this._AdharNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cast", DbType="VarChar(4) NOT NULL", CanBeNull=false)]
		public string Cast
		{
			get
			{
				return this._Cast;
			}
			set
			{
				if ((this._Cast != value))
				{
					this._Cast = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Religion", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string Religion
		{
			get
			{
				return this._Religion;
			}
			set
			{
				if ((this._Religion != value))
				{
					this._Religion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PreSchool", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PreSchool
		{
			get
			{
				return this._PreSchool;
			}
			set
			{
				if ((this._PreSchool != value))
				{
					this._PreSchool = value;
				}
			}
		}
	}
	
	public partial class lk_searchLKGResult
	{
		
		private int _ID;
		
		private string _Name;
		
		private string _FatherName;
		
		private string _MotherName;
		
		private string _SrNo;
		
		private string _DateOfBirth;
		
		private string _DateOfAdmission;
		
		private string _Class;
		
		private string _Section;
		
		private string _ContactNo;
		
		private string _Address;
		
		private string _AdharNo;
		
		private string _Cast;
		
		private string _Religion;
		
		private string _PreSchool;
		
		public lk_searchLKGResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FatherName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FatherName
		{
			get
			{
				return this._FatherName;
			}
			set
			{
				if ((this._FatherName != value))
				{
					this._FatherName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotherName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MotherName
		{
			get
			{
				return this._MotherName;
			}
			set
			{
				if ((this._MotherName != value))
				{
					this._MotherName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SrNo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SrNo
		{
			get
			{
				return this._SrNo;
			}
			set
			{
				if ((this._SrNo != value))
				{
					this._SrNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this._DateOfBirth = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfAdmission", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string DateOfAdmission
		{
			get
			{
				return this._DateOfAdmission;
			}
			set
			{
				if ((this._DateOfAdmission != value))
				{
					this._DateOfAdmission = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string Class
		{
			get
			{
				return this._Class;
			}
			set
			{
				if ((this._Class != value))
				{
					this._Class = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Section", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string Section
		{
			get
			{
				return this._Section;
			}
			set
			{
				if ((this._Section != value))
				{
					this._Section = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactNo", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string ContactNo
		{
			get
			{
				return this._ContactNo;
			}
			set
			{
				if ((this._ContactNo != value))
				{
					this._ContactNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdharNo", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string AdharNo
		{
			get
			{
				return this._AdharNo;
			}
			set
			{
				if ((this._AdharNo != value))
				{
					this._AdharNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cast", DbType="VarChar(4) NOT NULL", CanBeNull=false)]
		public string Cast
		{
			get
			{
				return this._Cast;
			}
			set
			{
				if ((this._Cast != value))
				{
					this._Cast = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Religion", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string Religion
		{
			get
			{
				return this._Religion;
			}
			set
			{
				if ((this._Religion != value))
				{
					this._Religion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PreSchool", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PreSchool
		{
			get
			{
				return this._PreSchool;
			}
			set
			{
				if ((this._PreSchool != value))
				{
					this._PreSchool = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
