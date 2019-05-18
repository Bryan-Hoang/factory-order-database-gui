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

namespace Order_System_UI
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="model")]
	public partial class TransportLinkDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTransportationDataLog(TransportationDataLog instance);
    partial void UpdateTransportationDataLog(TransportationDataLog instance);
    partial void DeleteTransportationDataLog(TransportationDataLog instance);
    #endregion
		
		public TransportLinkDataContext() : 
				base(global::Order_System_UI.Properties.Settings.Default.modelConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TransportLinkDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransportLinkDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransportLinkDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransportLinkDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TransportationDataLog> TransportationDataLogs
		{
			get
			{
				return this.GetTable<TransportationDataLog>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TransportationDataLog")]
	public partial class TransportationDataLog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name_of_Seller;
		
		private string _Truck_Company;
		
		private string _Quality;
		
		private string _Weight;
		
		private string _Price;
		
		private string _Number_of_Bags;
		
		private string _Freight_Charges;
		
		private string _Shipment_Number;
		
		private string _Date_of_Arrival;
		
		private string _Total_Cost;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnName_of_SellerChanging(string value);
    partial void OnName_of_SellerChanged();
    partial void OnTruck_CompanyChanging(string value);
    partial void OnTruck_CompanyChanged();
    partial void OnQualityChanging(string value);
    partial void OnQualityChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnPriceChanging(string value);
    partial void OnPriceChanged();
    partial void OnNumber_of_BagsChanging(string value);
    partial void OnNumber_of_BagsChanged();
    partial void OnFreight_ChargesChanging(string value);
    partial void OnFreight_ChargesChanged();
    partial void OnShipment_NumberChanging(string value);
    partial void OnShipment_NumberChanged();
    partial void OnDate_of_ArrivalChanging(string value);
    partial void OnDate_of_ArrivalChanged();
    partial void OnTotal_CostChanging(string value);
    partial void OnTotal_CostChanged();
    #endregion
		
		public TransportationDataLog()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Name of Seller]", Storage="_Name_of_Seller", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name_of_Seller
		{
			get
			{
				return this._Name_of_Seller;
			}
			set
			{
				if ((this._Name_of_Seller != value))
				{
					this.OnName_of_SellerChanging(value);
					this.SendPropertyChanging();
					this._Name_of_Seller = value;
					this.SendPropertyChanged("Name_of_Seller");
					this.OnName_of_SellerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Truck Company]", Storage="_Truck_Company", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Truck_Company
		{
			get
			{
				return this._Truck_Company;
			}
			set
			{
				if ((this._Truck_Company != value))
				{
					this.OnTruck_CompanyChanging(value);
					this.SendPropertyChanging();
					this._Truck_Company = value;
					this.SendPropertyChanged("Truck_Company");
					this.OnTruck_CompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quality", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Quality
		{
			get
			{
				return this._Quality;
			}
			set
			{
				if ((this._Quality != value))
				{
					this.OnQualityChanging(value);
					this.SendPropertyChanging();
					this._Quality = value;
					this.SendPropertyChanged("Quality");
					this.OnQualityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Number of Bags]", Storage="_Number_of_Bags", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Number_of_Bags
		{
			get
			{
				return this._Number_of_Bags;
			}
			set
			{
				if ((this._Number_of_Bags != value))
				{
					this.OnNumber_of_BagsChanging(value);
					this.SendPropertyChanging();
					this._Number_of_Bags = value;
					this.SendPropertyChanged("Number_of_Bags");
					this.OnNumber_of_BagsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Freight Charges]", Storage="_Freight_Charges", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Freight_Charges
		{
			get
			{
				return this._Freight_Charges;
			}
			set
			{
				if ((this._Freight_Charges != value))
				{
					this.OnFreight_ChargesChanging(value);
					this.SendPropertyChanging();
					this._Freight_Charges = value;
					this.SendPropertyChanged("Freight_Charges");
					this.OnFreight_ChargesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Shipment Number]", Storage="_Shipment_Number", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Shipment_Number
		{
			get
			{
				return this._Shipment_Number;
			}
			set
			{
				if ((this._Shipment_Number != value))
				{
					this.OnShipment_NumberChanging(value);
					this.SendPropertyChanging();
					this._Shipment_Number = value;
					this.SendPropertyChanged("Shipment_Number");
					this.OnShipment_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Date of Arrival]", Storage="_Date_of_Arrival", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Date_of_Arrival
		{
			get
			{
				return this._Date_of_Arrival;
			}
			set
			{
				if ((this._Date_of_Arrival != value))
				{
					this.OnDate_of_ArrivalChanging(value);
					this.SendPropertyChanging();
					this._Date_of_Arrival = value;
					this.SendPropertyChanged("Date_of_Arrival");
					this.OnDate_of_ArrivalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Total Cost]", Storage="_Total_Cost", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Total_Cost
		{
			get
			{
				return this._Total_Cost;
			}
			set
			{
				if ((this._Total_Cost != value))
				{
					this.OnTotal_CostChanging(value);
					this.SendPropertyChanging();
					this._Total_Cost = value;
					this.SendPropertyChanged("Total_Cost");
					this.OnTotal_CostChanged();
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