//
// Class	:	BDProductBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:24 PM
//

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Collections;
using System.Data.Common;
using System.IO;
using System.Xml;

namespace POS.DataLayer
{

	/// <summary>
	/// Class for the properties of the object
	/// </summary>
	public class BDProductFields
	{
		public const string ProductID                 = "ProductID";
		public const string ProductName               = "ProductName";
		public const string ProductGroupID            = "ProductGroupID";
		public const string ProductCode               = "ProductCode";
		public const string IsAcceptBatch             = "IsAcceptBatch";
		public const string ProductPrice              = "ProductPrice";
		public const string IsFixedPrice              = "IsFixedPrice";
		public const string HasDiscount               = "HasDiscount";
		public const string DiscountAmount            = "DiscountAmount";
		public const string DescountRatio             = "DescountRatio";
		public const string IsActive                  = "IsActive";
		public const string Notes                     = "Notes";
		public const string MinPrice                  = "MinPrice";
		public const string MaxPrice                  = "MaxPrice";
	}
	
	/// <summary>
	/// Data access class for the "BDProduct" table.
	/// </summary>
	[Serializable]
	public class BDProductBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_productIDNonDefault     	= null;
		private string         	_productNameNonDefault   	= null;
		private int?           	_productGroupIDNonDefault	= null;
		private string         	_productCodeNonDefault   	= null;
		private bool?          	_isAcceptBatchNonDefault 	= false;
		private decimal?       	_productPriceNonDefault  	= null;
		private bool?          	_isFixedPriceNonDefault  	= null;
		private bool?          	_hasDiscountNonDefault   	= null;
		private decimal?       	_discountAmountNonDefault	= null;
		private double?        	_descountRatioNonDefault 	= null;
		private bool?          	_isActiveNonDefault      	= null;
		private string         	_notesNonDefault         	= null;
		private decimal?       	_minPriceNonDefault      	= null;
		private decimal?       	_maxPriceNonDefault      	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public BDProductBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? ProductID
		{
			get 
			{ 
				return _productIDNonDefault;
			}
			set 
			{
			
				_productIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ProductName" field. Length must be between 0 and 255 characters. Mandatory.
		/// </summary>
		public string ProductName
		{
			get 
			{ 
				if(_productNameNonDefault==null)return _productNameNonDefault;
				else return _productNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 255)
					throw new ArgumentException("ProductName length must be between 0 and 255 characters.");

				
				if(value ==null)
				{
					_productNameNonDefault =null;//null value 
				}
				else
				{		           
					_productNameNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "ProductGroupID" field.  
		/// </summary>
		public int? ProductGroupID
		{
			get 
			{ 
				return _productGroupIDNonDefault;
			}
			set 
			{
			
				_productGroupIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ProductCode" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string ProductCode
		{
			get 
			{ 
				if(_productCodeNonDefault==null)return _productCodeNonDefault;
				else return _productCodeNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("ProductCode length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_productCodeNonDefault =null;//null value 
				}
				else
				{		           
					_productCodeNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "IsAcceptBatch" field.  Mandatory.
		/// </summary>
		public bool? IsAcceptBatch
		{
			get 
			{ 
				return _isAcceptBatchNonDefault;
			}
			set 
			{
			
				_isAcceptBatchNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ProductPrice" field.  
		/// </summary>
		public decimal? ProductPrice
		{
			get 
			{ 
				return _productPriceNonDefault;
			}
			set 
			{
			
				_productPriceNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "IsFixedPrice" field.  
		/// </summary>
		public bool? IsFixedPrice
		{
			get 
			{ 
				return _isFixedPriceNonDefault;
			}
			set 
			{
			
				_isFixedPriceNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "HasDiscount" field.  
		/// </summary>
		public bool? HasDiscount
		{
			get 
			{ 
				return _hasDiscountNonDefault;
			}
			set 
			{
			
				_hasDiscountNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "DiscountAmount" field.  
		/// </summary>
		public decimal? DiscountAmount
		{
			get 
			{ 
				return _discountAmountNonDefault;
			}
			set 
			{
			
				_discountAmountNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "DescountRatio" field.  
		/// </summary>
		public double? DescountRatio
		{
			get 
			{ 
				return _descountRatioNonDefault;
			}
			set 
			{
			
				_descountRatioNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "IsActive" field.  
		/// </summary>
		public bool? IsActive
		{
			get 
			{ 
				return _isActiveNonDefault;
			}
			set 
			{
			
				_isActiveNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "Notes" field. Length must be between 0 and 2147483647 characters. 
		/// </summary>
		public string Notes
		{
			get 
			{ 
				if(_notesNonDefault==null)return _notesNonDefault;
				else return _notesNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 2147483647)
					throw new ArgumentException("Notes length must be between 0 and 2147483647 characters.");

				
				if(value ==null)
				{
					_notesNonDefault =null;//null value 
				}
				else
				{		           
					_notesNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "MinPrice" field.  
		/// </summary>
		public decimal? MinPrice
		{
			get 
			{ 
				return _minPriceNonDefault;
			}
			set 
			{
			
				_minPriceNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "MaxPrice" field.  
		/// </summary>
		public decimal? MaxPrice
		{
			get 
			{ 
				return _maxPriceNonDefault;
			}
			set 
			{
			
				_maxPriceNonDefault = value; 
			}
		}

		#endregion
		
		#region Methods (Public)

		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		/// <param name="getBackValues" type="bool">Whether to get the default values inserted, from the database</param>
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_productName' as parameter 'ProductName' of the stored procedure.
			if(_productNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductName", _productNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductName", DBNull.Value );
			  
			// Pass the value of '_productGroupID' as parameter 'ProductGroupID' of the stored procedure.
			if(_productGroupIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductGroupID", _productGroupIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductGroupID", DBNull.Value );
			  
			// Pass the value of '_productCode' as parameter 'ProductCode' of the stored procedure.
			if(_productCodeNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductCode", _productCodeNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductCode", DBNull.Value );
			  
			// Pass the value of '_isAcceptBatch' as parameter 'IsAcceptBatch' of the stored procedure.
			if(_isAcceptBatchNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsAcceptBatch", _isAcceptBatchNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsAcceptBatch", DBNull.Value );
			  
			// Pass the value of '_productPrice' as parameter 'ProductPrice' of the stored procedure.
			if(_productPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductPrice", _productPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductPrice", DBNull.Value );
			  
			// Pass the value of '_isFixedPrice' as parameter 'IsFixedPrice' of the stored procedure.
			if(_isFixedPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsFixedPrice", _isFixedPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsFixedPrice", DBNull.Value );
			  
			// Pass the value of '_hasDiscount' as parameter 'HasDiscount' of the stored procedure.
			if(_hasDiscountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@HasDiscount", _hasDiscountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@HasDiscount", DBNull.Value );
			  
			// Pass the value of '_discountAmount' as parameter 'DiscountAmount' of the stored procedure.
			if(_discountAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DiscountAmount", _discountAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DiscountAmount", DBNull.Value );
			  
			// Pass the value of '_descountRatio' as parameter 'DescountRatio' of the stored procedure.
			if(_descountRatioNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DescountRatio", _descountRatioNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DescountRatio", DBNull.Value );
			  
			// Pass the value of '_isActive' as parameter 'IsActive' of the stored procedure.
			if(_isActiveNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsActive", _isActiveNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsActive", DBNull.Value );
			  
			// Pass the value of '_notes' as parameter 'Notes' of the stored procedure.
			if(_notesNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Notes", _notesNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Notes", DBNull.Value );
			  
			// Pass the value of '_minPrice' as parameter 'MinPrice' of the stored procedure.
			if(_minPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@MinPrice", _minPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@MinPrice", DBNull.Value );
			  
			// Pass the value of '_maxPrice' as parameter 'MaxPrice' of the stored procedure.
			if(_maxPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@MaxPrice", _maxPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@MaxPrice", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_BDProduct_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDProduct_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
				if (dr.Read())
				{
					PopulateObjectFromReader(this,dr);
				}
				dr.Close();
			}
			oDatabaseHelper.Dispose();	
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_productName' as parameter 'ProductName' of the stored procedure.
			if(_productNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductName", _productNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductName", DBNull.Value );
			// Pass the value of '_productGroupID' as parameter 'ProductGroupID' of the stored procedure.
			if(_productGroupIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductGroupID", _productGroupIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductGroupID", DBNull.Value );
			// Pass the value of '_productCode' as parameter 'ProductCode' of the stored procedure.
			if(_productCodeNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductCode", _productCodeNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductCode", DBNull.Value );
			// Pass the value of '_isAcceptBatch' as parameter 'IsAcceptBatch' of the stored procedure.
			if(_isAcceptBatchNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsAcceptBatch", _isAcceptBatchNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsAcceptBatch", DBNull.Value );
			// Pass the value of '_productPrice' as parameter 'ProductPrice' of the stored procedure.
			if(_productPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductPrice", _productPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductPrice", DBNull.Value );
			// Pass the value of '_isFixedPrice' as parameter 'IsFixedPrice' of the stored procedure.
			if(_isFixedPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsFixedPrice", _isFixedPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsFixedPrice", DBNull.Value );
			// Pass the value of '_hasDiscount' as parameter 'HasDiscount' of the stored procedure.
			if(_hasDiscountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@HasDiscount", _hasDiscountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@HasDiscount", DBNull.Value );
			// Pass the value of '_discountAmount' as parameter 'DiscountAmount' of the stored procedure.
			if(_discountAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DiscountAmount", _discountAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DiscountAmount", DBNull.Value );
			// Pass the value of '_descountRatio' as parameter 'DescountRatio' of the stored procedure.
			if(_descountRatioNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DescountRatio", _descountRatioNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DescountRatio", DBNull.Value );
			// Pass the value of '_isActive' as parameter 'IsActive' of the stored procedure.
			if(_isActiveNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsActive", _isActiveNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsActive", DBNull.Value );
			// Pass the value of '_notes' as parameter 'Notes' of the stored procedure.
			if(_notesNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Notes", _notesNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Notes", DBNull.Value );
			// Pass the value of '_minPrice' as parameter 'MinPrice' of the stored procedure.
			if(_minPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@MinPrice", _minPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@MinPrice", DBNull.Value );
			// Pass the value of '_maxPrice' as parameter 'MaxPrice' of the stored procedure.
			if(_maxPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@MaxPrice", _maxPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@MaxPrice", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDProduct_Insert", ref ExecutionState);
			oDatabaseHelper.Dispose();	
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Update one new row into the database using the property Information
		/// </summary>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
			oDatabaseHelper.AddParameter("@ProductID", _productIDNonDefault );
			
			// Pass the value of '_productName' as parameter 'ProductName' of the stored procedure.
			oDatabaseHelper.AddParameter("@ProductName", _productNameNonDefault );
			
			// Pass the value of '_productGroupID' as parameter 'ProductGroupID' of the stored procedure.
			oDatabaseHelper.AddParameter("@ProductGroupID", _productGroupIDNonDefault );
			
			// Pass the value of '_productCode' as parameter 'ProductCode' of the stored procedure.
			oDatabaseHelper.AddParameter("@ProductCode", _productCodeNonDefault );
			
			// Pass the value of '_isAcceptBatch' as parameter 'IsAcceptBatch' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsAcceptBatch", _isAcceptBatchNonDefault );
			
			// Pass the value of '_productPrice' as parameter 'ProductPrice' of the stored procedure.
			oDatabaseHelper.AddParameter("@ProductPrice", _productPriceNonDefault );
			
			// Pass the value of '_isFixedPrice' as parameter 'IsFixedPrice' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsFixedPrice", _isFixedPriceNonDefault );
			
			// Pass the value of '_hasDiscount' as parameter 'HasDiscount' of the stored procedure.
			oDatabaseHelper.AddParameter("@HasDiscount", _hasDiscountNonDefault );
			
			// Pass the value of '_discountAmount' as parameter 'DiscountAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@DiscountAmount", _discountAmountNonDefault );
			
			// Pass the value of '_descountRatio' as parameter 'DescountRatio' of the stored procedure.
			oDatabaseHelper.AddParameter("@DescountRatio", _descountRatioNonDefault );
			
			// Pass the value of '_isActive' as parameter 'IsActive' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsActive", _isActiveNonDefault );
			
			// Pass the value of '_notes' as parameter 'Notes' of the stored procedure.
			oDatabaseHelper.AddParameter("@Notes", _notesNonDefault );
			
			// Pass the value of '_minPrice' as parameter 'MinPrice' of the stored procedure.
			oDatabaseHelper.AddParameter("@MinPrice", _minPriceNonDefault );
			
			// Pass the value of '_maxPrice' as parameter 'MaxPrice' of the stored procedure.
			oDatabaseHelper.AddParameter("@MaxPrice", _maxPriceNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDProduct_Update", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the property Information
		/// </summary>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
			if(_productIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@ProductID", _productIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@ProductID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDProduct_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="BDProductPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(BDProductPrimaryKey pk) 
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
   oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
   
			oDatabaseHelper.ExecuteScalar("gsp_BDProduct_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDProductFields">Field of the class BDProduct</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteByField(string field, object fieldValue)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@Field",field);
			oDatabaseHelper.AddParameter("@Value", fieldValue );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDProduct_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDProductPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDProduct</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDProduct SelectOne(BDProductPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDProduct_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				BDProduct obj=new BDProduct();	
				PopulateObjectFromReader(obj,dr);
				dr.Close();              
				oDatabaseHelper.Dispose();
				return obj;
			}
			else
			{
				dr.Close();
				oDatabaseHelper.Dispose();
				return null;
			}
			
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class BDProduct in the form of object of BDProductCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDProductCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDProduct_SelectAll", ref ExecutionState);
			BDProductCollection BDProductCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDProductCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDProduct</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDProduct in the form of an object of class BDProductCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDProductCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@Field",field);
			oDatabaseHelper.AddParameter("@Value", fieldValue );
			oDatabaseHelper.AddParameter("@Value2", fieldValue2 );
			oDatabaseHelper.AddParameter("@Operation", OperationCollection.Operation[(int)typeOperation] );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDProduct_SelectByField", ref ExecutionState);
			BDProductCollection BDProductCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDProductCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class BDProduct in the form of object of BDProductCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDProductCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDProduct_SelectAllPaged", ref ExecutionState);
			BDProductCollection BDProductCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDProductCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDProduct</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDProduct in the form of an object of class BDProductCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDProductCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@Field",field);
			oDatabaseHelper.AddParameter("@Value", fieldValue );
			oDatabaseHelper.AddParameter("@Value2", fieldValue2 );
			oDatabaseHelper.AddParameter("@Operation", OperationCollection.Operation[(int)typeOperation] );
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages );
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDProduct_SelectByFieldPaged", ref ExecutionState);
			BDProductCollection BDProductCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDProductCollection;
			
		}

		/// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static int SelectAllCount()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();			
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_BDProduct_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		#endregion	
		
		#region Methods (Private)

		/// <summary>
		/// tests a string to be a well formed xml or not,
		/// it throws ArgumentException when string text is not well formed.otherwise this 
		/// method is executed silently .
		/// </summary>
		/// <param name="text" type="string">xml string to validate.</param>
		/// <param name="fieldName" type="string">field Name to validate.</param>
		/// <exception cref="System.ArgumentException"> throws ArgumentException when text is not well formed parameter.otherwise this 
		/// method is executed silently .</exception>
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void IsValidXmlString(string text,string fieldName)
		{
			XmlTextReader r = new XmlTextReader(new StringReader(text));
			try
			{
				while (r.Read())
				{
				  /*do nothing ,just continue as long as xml is valid*/ 
				}
			}
			catch(Exception)
			{
				throw new ArgumentException ("Field ("+fieldName+") xml text argument isn't well formed");				
			}
			finally
			{
				r.Close();
			
			}
		  //end silently(well formed xml)
		}    
		/// <summary>
		/// Populates the fields of a single objects from the columns found in an open reader.
		/// </summary>
		/// <param name="obj" type="BDProduct">Object of BDProduct to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(BDProductBase obj,IDataReader rdr) 
		{

			obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(BDProductFields.ProductID));
			obj.ProductName = rdr.GetString(rdr.GetOrdinal(BDProductFields.ProductName));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.ProductGroupID)))
			{
				obj.ProductGroupID = rdr.GetInt32(rdr.GetOrdinal(BDProductFields.ProductGroupID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.ProductCode)))
			{
				obj.ProductCode = rdr.GetString(rdr.GetOrdinal(BDProductFields.ProductCode));
			}
			
			obj.IsAcceptBatch = rdr.GetBoolean(rdr.GetOrdinal(BDProductFields.IsAcceptBatch));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.ProductPrice)))
			{
				obj.ProductPrice = rdr.GetDecimal(rdr.GetOrdinal(BDProductFields.ProductPrice));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.IsFixedPrice)))
			{
				obj.IsFixedPrice = rdr.GetBoolean(rdr.GetOrdinal(BDProductFields.IsFixedPrice));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.HasDiscount)))
			{
				obj.HasDiscount = rdr.GetBoolean(rdr.GetOrdinal(BDProductFields.HasDiscount));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.DiscountAmount)))
			{
				obj.DiscountAmount = rdr.GetDecimal(rdr.GetOrdinal(BDProductFields.DiscountAmount));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.DescountRatio)))
			{
				obj.DescountRatio = rdr.GetDouble(rdr.GetOrdinal(BDProductFields.DescountRatio));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.IsActive)))
			{
				obj.IsActive = rdr.GetBoolean(rdr.GetOrdinal(BDProductFields.IsActive));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.Notes)))
			{
				obj.Notes = rdr.GetString(rdr.GetOrdinal(BDProductFields.Notes));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.MinPrice)))
			{
				obj.MinPrice = rdr.GetDecimal(rdr.GetOrdinal(BDProductFields.MinPrice));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.MaxPrice)))
			{
				obj.MaxPrice = rdr.GetDecimal(rdr.GetOrdinal(BDProductFields.MaxPrice));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of BDProductCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static BDProductCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			BDProductCollection list = new BDProductCollection();
			
			while (rdr.Read())
			{
				BDProduct obj = new BDProduct();
				PopulateObjectFromReader(obj,rdr);
				list.Add(obj);
			}
			return list;
			
		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of BDProductCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:24 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static BDProductCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			BDProductCollection list = new BDProductCollection();
			
            if (rdr.Read())
			{
				BDProduct obj = new BDProduct();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new BDProduct();
					PopulateObjectFromReader(obj, rdr);
					list.Add(obj);
				}
				oDatabaseHelper.Dispose();
				return list;
			}
			else
			{
				oDatabaseHelper.Dispose();
				return null;
			}
			
		}

	
	#endregion

	}
}
