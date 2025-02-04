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

namespace HangszerUzlet
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HangszerUzlet")]
	public partial class HangszerDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHangszer(Hangszer instance);
    partial void UpdateHangszer(Hangszer instance);
    partial void DeleteHangszer(Hangszer instance);
    partial void InsertHangszerTipus(HangszerTipus instance);
    partial void UpdateHangszerTipus(HangszerTipus instance);
    partial void DeleteHangszerTipus(HangszerTipus instance);
    #endregion
		
		public HangszerDBDataContext() : 
				base(global::HangszerUzlet.Properties.Settings.Default.HangszerUzletConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HangszerDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HangszerDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HangszerDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HangszerDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Hangszer> Hangszers
		{
			get
			{
				return this.GetTable<Hangszer>();
			}
		}
		
		public System.Data.Linq.Table<HangszerTipus> HangszerTipus
		{
			get
			{
				return this.GetTable<HangszerTipus>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Hangszer")]
	public partial class Hangszer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nev;
		
		private string _Tipus;
		
		private System.Nullable<int> _Ar;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNevChanging(string value);
    partial void OnNevChanged();
    partial void OnTipusChanging(string value);
    partial void OnTipusChanged();
    partial void OnArChanging(System.Nullable<int> value);
    partial void OnArChanged();
    #endregion
		
		public Hangszer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nev", DbType="NVarChar(50)")]
		public string Nev
		{
			get
			{
				return this._Nev;
			}
			set
			{
				if ((this._Nev != value))
				{
					this.OnNevChanging(value);
					this.SendPropertyChanging();
					this._Nev = value;
					this.SendPropertyChanged("Nev");
					this.OnNevChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tipus", DbType="NVarChar(50)")]
		public string Tipus
		{
			get
			{
				return this._Tipus;
			}
			set
			{
				if ((this._Tipus != value))
				{
					this.OnTipusChanging(value);
					this.SendPropertyChanging();
					this._Tipus = value;
					this.SendPropertyChanged("Tipus");
					this.OnTipusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ar", DbType="Int")]
		public System.Nullable<int> Ar
		{
			get
			{
				return this._Ar;
			}
			set
			{
				if ((this._Ar != value))
				{
					this.OnArChanging(value);
					this.SendPropertyChanging();
					this._Ar = value;
					this.SendPropertyChanged("Ar");
					this.OnArChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HangszerTipus")]
	public partial class HangszerTipus : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nev;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNevChanging(string value);
    partial void OnNevChanged();
    #endregion
		
		public HangszerTipus()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nev", DbType="NVarChar(50)")]
		public string Nev
		{
			get
			{
				return this._Nev;
			}
			set
			{
				if ((this._Nev != value))
				{
					this.OnNevChanging(value);
					this.SendPropertyChanging();
					this._Nev = value;
					this.SendPropertyChanged("Nev");
					this.OnNevChanged();
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
}
#pragma warning restore 1591
