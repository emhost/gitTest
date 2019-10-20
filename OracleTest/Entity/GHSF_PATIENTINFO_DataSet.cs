//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml;
using System.Runtime.Serialization;

namespace HYGHSF.Entity
{
	#region DataSetGHSF_PATIENTINFO
	/// 
	/// 对于GHSF_PATIENTINFO的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetGHSF_PATIENTINFO : DataSet
    {
		
		private DataTableGHSF_GHSF_PATIENTINFO tableGHSF_GHSF_PATIENTINFO;
		
        public DataSetGHSF_PATIENTINFO() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetGHSF_PATIENTINFO实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetGHSF_PATIENTINFO GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetGHSF_PATIENTINFO dataSet = (DataSetGHSF_PATIENTINFO)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetGHSF_PATIENTINFO entity = new DataSetGHSF_PATIENTINFO();
			entity.Relations.Clear();
			
			DataSet dataSet = this.GetChanges();
			foreach(DataTable dt in dataSet.Tables)
			{
				foreach(DataRow dr in dt.Rows)
				{
					if(dr.RowState == ds)
					{
						if(dr.RowState == DataRowState.Deleted)
							dr.RejectChanges();
						entity.Tables[dt.TableName].Rows.Add(dr.ItemArray);
						if(ds == DataRowState.Deleted)
							dr.Delete();
					}
				}
			}
			entity.AcceptChanges();
			return entity;
*/
			
			/*foreach(DataTable dt in this.Tables)
			{
				DataTable changeTable = dt.GetChanges(ds);
				if(changeTable != null)
				{
					entity.Tables.Remove(changeTable.TableName);
					entity.Tables.Add(changeTable.Copy());
				}
			}
			return entity;*/
		}
        
        protected DataSetGHSF_PATIENTINFO(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["GHSF_GHSF_PATIENTINFO"] != null)) 
                {
                    this.Tables.Add(new DataTableGHSF_GHSF_PATIENTINFO(ds.Tables["GHSF_GHSF_PATIENTINFO"]));
                }
				
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else
            {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		
		/// 
		/// 对于数据表GHSF_GHSF_PATIENTINFO的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableGHSF_GHSF_PATIENTINFO GHSF_GHSF_PATIENTINFO 
		{
			get
			{
				return this.tableGHSF_GHSF_PATIENTINFO;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetGHSF_PATIENTINFO cln = ((DataSetGHSF_PATIENTINFO)(base.Clone()));
			cln.InitVars();
			return cln;
		}
	    
		protected override bool ShouldSerializeTables() 
		{
			return false;
		}
	    
		protected override bool ShouldSerializeRelations() 
		{
			return false;
		}
	            
		protected override void ReadXmlSerializable(XmlReader reader) 
		{
			this.Reset();
			DataSet ds = new DataSet();
			ds.ReadXml(reader);
			
			if ((ds.Tables["GHSF_GHSF_PATIENTINFO"] != null)) 
			{
				this.Tables.Add(new DataTableGHSF_GHSF_PATIENTINFO(ds.Tables["GHSF_GHSF_PATIENTINFO"]));
			}
			
			this.DataSetName = ds.DataSetName;
			this.Prefix = ds.Prefix;
			this.Namespace = ds.Namespace;
			this.Locale = ds.Locale;
			this.CaseSensitive = ds.CaseSensitive;
			this.EnforceConstraints = ds.EnforceConstraints;
			this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
			this.InitVars();
		}
	            
		protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() 
		{
			System.IO.MemoryStream stream = new System.IO.MemoryStream();
			this.WriteXmlSchema(new XmlTextWriter(stream, null));
			stream.Position = 0;
			return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
		}
	        
		internal void InitVars() 
		{
			
			this.tableGHSF_GHSF_PATIENTINFO = ((DataTableGHSF_GHSF_PATIENTINFO)(this.Tables["GHSF_GHSF_PATIENTINFO"]));
			if ((this.tableGHSF_GHSF_PATIENTINFO != null)) {
				this.tableGHSF_GHSF_PATIENTINFO.InitVars();
			}
			
		}        
	    
		private void InitClass() 
		{
			this.DataSetName = "DeptDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.tempuri.org/DeptDataSet.xsd";
			this.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.CaseSensitive = false;
			this.EnforceConstraints = true;
			
			this.tableGHSF_GHSF_PATIENTINFO = new DataTableGHSF_GHSF_PATIENTINFO();
			this.Tables.Add(this.tableGHSF_GHSF_PATIENTINFO);
			
		}
		
		private bool ShouldSerializeGHSF_GHSF_PATIENTINFO() 
		{
			return false;
		}
		
		private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
			if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
				this.InitVars();
			}
		}
    }
	#endregion
	
	#region DataTable, DataRow Classes
	
    public delegate void RowChangeEventHandlerGHSF_GHSF_PATIENTINFO(object sender, RowChangeEventGHSF_GHSF_PATIENTINFO e);
	
	#region DataTableGHSF_GHSF_PATIENTINFO
	/// 
	/// 对于数据表GHSF_GHSF_PATIENTINFO的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableGHSF_GHSF_PATIENTINFO : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVPATIENTID;
		
        private DataColumn columnDCREATEDATE;
		
        private DataColumn columnVNAME;
		
        private DataColumn columnPINYINMA;
		
        private DataColumn columnWUBIMA;
		
        private DataColumn columnNSEX;
		
        private DataColumn columnDBIRTHDATE;
		
        private DataColumn columnVBIRTHPLACE;
		
        private DataColumn columnVBIRTHPLACEDETAIL;
		
        private DataColumn columnVNATION;
		
        private DataColumn columnVNATIONNAME;
		
        private DataColumn columnVIDTYPE;
		
        private DataColumn columnVIDNO;
		
        private DataColumn columnVUNITINCONTRACT;
		
        private DataColumn columnVUNITINCONTRACTNAME;
		
        private DataColumn columnVMAILINGADDRESS;
		
        private DataColumn columnVZIPID;
		
        private DataColumn columnVPHONENUMBERHOME;
		
        private DataColumn columnVPHONENUMBERBUSINESS;
		
        private DataColumn columnVLINKMAN;
		
        private DataColumn columnVRELATIONSHIP;
		
        private DataColumn columnVNEXTOFKINADDR;
		
        private DataColumn columnVNEXTOFKINZIPID;
		
        private DataColumn columnVPHONE;
		
        private DataColumn columnDLASTVISITDATE;
		
        private DataColumn columnNVIPINDICATOR;
		
        private DataColumn columnVOPERATORID;
		
        private DataColumn columnVDEGREE;
		
        private DataColumn columnVRACE;
		
        private DataColumn columnVRELIGION;
		
        private DataColumn columnVMOTHERLANGUAGE;
		
        private DataColumn columnVFOREIGNLANGUAGE;
		
        private DataColumn columnVVIPNO;
		
        private DataColumn columnVENGLISHNAME;
		
        private DataColumn columnVREMARKS;
		
        private DataColumn columnNCOUNTRY;
		
        private DataColumn columnNPROVINCES;
		
        private DataColumn columnNCITY;
		
        private DataColumn columnNSTREET;
		
        private DataColumn columnNPROFESSIONID;
		
        private DataColumn columnNIDENTITY;
		
        private DataColumn columnVPRESENTADDRESS;
		
        private DataColumn columnVISITNO;
		
        private DataColumn columnNMARRY;
		
        private DataColumn columnVORGAN;
		
        private DataColumn columnNDICAREAID;
		
        private DataColumn columnVDIAGNOSE;
		
        private DataColumn columnNDISEASEID;
		
        private DataColumn columnNZYZEXZ;
		
        private DataColumn columnNZYYPXZ;
		
        internal DataTableGHSF_GHSF_PATIENTINFO() : base("GHSF_GHSF_PATIENTINFO") 
        {
            this.InitClass();
        }
        
        internal DataTableGHSF_GHSF_PATIENTINFO(DataTable table) : base(table.TableName) 
        {
            if ((table.CaseSensitive != table.DataSet.CaseSensitive)) 
            {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) 
            {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace)) 
            {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
            this.DisplayExpression = table.DisplayExpression;
        }
        
		/// 
		/// 数据表包含的记录总数。
		/// 
        [System.ComponentModel.Browsable(false)]
        public int Count 
        {
            get 
            {
                return this.Rows.Count;
            }
        }
		
        public DataColumn ColumnVPATIENTID 
        {
            get 
            {
                return this.columnVPATIENTID;
            }
        }
		
        public DataColumn ColumnDCREATEDATE 
        {
            get 
            {
                return this.columnDCREATEDATE;
            }
        }
		
        public DataColumn ColumnVNAME 
        {
            get 
            {
                return this.columnVNAME;
            }
        }
		
        public DataColumn ColumnPINYINMA 
        {
            get 
            {
                return this.columnPINYINMA;
            }
        }
		
        public DataColumn ColumnWUBIMA 
        {
            get 
            {
                return this.columnWUBIMA;
            }
        }
		
        public DataColumn ColumnNSEX 
        {
            get 
            {
                return this.columnNSEX;
            }
        }
		
        public DataColumn ColumnDBIRTHDATE 
        {
            get 
            {
                return this.columnDBIRTHDATE;
            }
        }
		
        public DataColumn ColumnVBIRTHPLACE 
        {
            get 
            {
                return this.columnVBIRTHPLACE;
            }
        }
		
        public DataColumn ColumnVBIRTHPLACEDETAIL 
        {
            get 
            {
                return this.columnVBIRTHPLACEDETAIL;
            }
        }
		
        public DataColumn ColumnVNATION 
        {
            get 
            {
                return this.columnVNATION;
            }
        }
		
        public DataColumn ColumnVNATIONNAME 
        {
            get 
            {
                return this.columnVNATIONNAME;
            }
        }
		
        public DataColumn ColumnVIDTYPE 
        {
            get 
            {
                return this.columnVIDTYPE;
            }
        }
		
        public DataColumn ColumnVIDNO 
        {
            get 
            {
                return this.columnVIDNO;
            }
        }
		
        public DataColumn ColumnVUNITINCONTRACT 
        {
            get 
            {
                return this.columnVUNITINCONTRACT;
            }
        }
		
        public DataColumn ColumnVUNITINCONTRACTNAME 
        {
            get 
            {
                return this.columnVUNITINCONTRACTNAME;
            }
        }
		
        public DataColumn ColumnVMAILINGADDRESS 
        {
            get 
            {
                return this.columnVMAILINGADDRESS;
            }
        }
		
        public DataColumn ColumnVZIPID 
        {
            get 
            {
                return this.columnVZIPID;
            }
        }
		
        public DataColumn ColumnVPHONENUMBERHOME 
        {
            get 
            {
                return this.columnVPHONENUMBERHOME;
            }
        }
		
        public DataColumn ColumnVPHONENUMBERBUSINESS 
        {
            get 
            {
                return this.columnVPHONENUMBERBUSINESS;
            }
        }
		
        public DataColumn ColumnVLINKMAN 
        {
            get 
            {
                return this.columnVLINKMAN;
            }
        }
		
        public DataColumn ColumnVRELATIONSHIP 
        {
            get 
            {
                return this.columnVRELATIONSHIP;
            }
        }
		
        public DataColumn ColumnVNEXTOFKINADDR 
        {
            get 
            {
                return this.columnVNEXTOFKINADDR;
            }
        }
		
        public DataColumn ColumnVNEXTOFKINZIPID 
        {
            get 
            {
                return this.columnVNEXTOFKINZIPID;
            }
        }
		
        public DataColumn ColumnVPHONE 
        {
            get 
            {
                return this.columnVPHONE;
            }
        }
		
        public DataColumn ColumnDLASTVISITDATE 
        {
            get 
            {
                return this.columnDLASTVISITDATE;
            }
        }
		
        public DataColumn ColumnNVIPINDICATOR 
        {
            get 
            {
                return this.columnNVIPINDICATOR;
            }
        }
		
        public DataColumn ColumnVOPERATORID 
        {
            get 
            {
                return this.columnVOPERATORID;
            }
        }
		
        public DataColumn ColumnVDEGREE 
        {
            get 
            {
                return this.columnVDEGREE;
            }
        }
		
        public DataColumn ColumnVRACE 
        {
            get 
            {
                return this.columnVRACE;
            }
        }
		
        public DataColumn ColumnVRELIGION 
        {
            get 
            {
                return this.columnVRELIGION;
            }
        }
		
        public DataColumn ColumnVMOTHERLANGUAGE 
        {
            get 
            {
                return this.columnVMOTHERLANGUAGE;
            }
        }
		
        public DataColumn ColumnVFOREIGNLANGUAGE 
        {
            get 
            {
                return this.columnVFOREIGNLANGUAGE;
            }
        }
		
        public DataColumn ColumnVVIPNO 
        {
            get 
            {
                return this.columnVVIPNO;
            }
        }
		
        public DataColumn ColumnVENGLISHNAME 
        {
            get 
            {
                return this.columnVENGLISHNAME;
            }
        }
		
        public DataColumn ColumnVREMARKS 
        {
            get 
            {
                return this.columnVREMARKS;
            }
        }
		
        public DataColumn ColumnNCOUNTRY 
        {
            get 
            {
                return this.columnNCOUNTRY;
            }
        }
		
        public DataColumn ColumnNPROVINCES 
        {
            get 
            {
                return this.columnNPROVINCES;
            }
        }
		
        public DataColumn ColumnNCITY 
        {
            get 
            {
                return this.columnNCITY;
            }
        }
		
        public DataColumn ColumnNSTREET 
        {
            get 
            {
                return this.columnNSTREET;
            }
        }
		
        public DataColumn ColumnNPROFESSIONID 
        {
            get 
            {
                return this.columnNPROFESSIONID;
            }
        }
		
        public DataColumn ColumnNIDENTITY 
        {
            get 
            {
                return this.columnNIDENTITY;
            }
        }
		
        public DataColumn ColumnVPRESENTADDRESS 
        {
            get 
            {
                return this.columnVPRESENTADDRESS;
            }
        }
		
        public DataColumn ColumnVISITNO 
        {
            get 
            {
                return this.columnVISITNO;
            }
        }
		
        public DataColumn ColumnNMARRY 
        {
            get 
            {
                return this.columnNMARRY;
            }
        }
		
        public DataColumn ColumnVORGAN 
        {
            get 
            {
                return this.columnVORGAN;
            }
        }
		
        public DataColumn ColumnNDICAREAID 
        {
            get 
            {
                return this.columnNDICAREAID;
            }
        }
		
        public DataColumn ColumnVDIAGNOSE 
        {
            get 
            {
                return this.columnVDIAGNOSE;
            }
        }
		
        public DataColumn ColumnNDISEASEID 
        {
            get 
            {
                return this.columnNDISEASEID;
            }
        }
		
        public DataColumn ColumnNZYZEXZ 
        {
            get 
            {
                return this.columnNZYZEXZ;
            }
        }
		
        public DataColumn ColumnNZYYPXZ 
        {
            get 
            {
                return this.columnNZYYPXZ;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowGHSF_GHSF_PATIENTINFO this[int index] 
        {
            get 
            {
                return ((RowGHSF_GHSF_PATIENTINFO)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerGHSF_GHSF_PATIENTINFO RowChangedGHSF_GHSF_PATIENTINFO;
        
        public event RowChangeEventHandlerGHSF_GHSF_PATIENTINFO RowChangingGHSF_GHSF_PATIENTINFO;
        
        public event RowChangeEventHandlerGHSF_GHSF_PATIENTINFO RowDeletedGHSF_GHSF_PATIENTINFO;
        
        public event RowChangeEventHandlerGHSF_GHSF_PATIENTINFO RowDeletingGHSF_GHSF_PATIENTINFO;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowGHSF_GHSF_PATIENTINFO(RowGHSF_GHSF_PATIENTINFO row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowGHSF_GHSF_PATIENTINFO AddRowGHSF_GHSF_PATIENTINFO(System.String VPATIENTID,System.DateTime DCREATEDATE,System.String VNAME,System.String PINYINMA,System.String WUBIMA,System.Int16 NSEX,System.DateTime DBIRTHDATE,System.String VBIRTHPLACE,System.String VBIRTHPLACEDETAIL,System.String VNATION,System.String VNATIONNAME,System.String VIDTYPE,System.String VIDNO,System.String VUNITINCONTRACT,System.String VUNITINCONTRACTNAME,System.String VMAILINGADDRESS,System.String VZIPID,System.String VPHONENUMBERHOME,System.String VPHONENUMBERBUSINESS,System.String VLINKMAN,System.String VRELATIONSHIP,System.String VNEXTOFKINADDR,System.String VNEXTOFKINZIPID,System.String VPHONE,System.DateTime DLASTVISITDATE,System.Int16 NVIPINDICATOR,System.String VOPERATORID,System.String VDEGREE,System.String VRACE,System.String VRELIGION,System.String VMOTHERLANGUAGE,System.String VFOREIGNLANGUAGE,System.String VVIPNO,System.String VENGLISHNAME,System.String VREMARKS,System.Int32 NCOUNTRY,System.Int32 NPROVINCES,System.Int32 NCITY,System.Int32 NSTREET,System.Int32 NPROFESSIONID,System.String NIDENTITY,System.String VPRESENTADDRESS,System.String VISITNO,System.Int16 NMARRY,System.String VORGAN,System.Decimal NDICAREAID,System.String VDIAGNOSE,System.Int32 NDISEASEID,System.Decimal NZYZEXZ,System.Decimal NZYYPXZ) 
        {
            RowGHSF_GHSF_PATIENTINFO row = ((RowGHSF_GHSF_PATIENTINFO)(this.NewRow()));
            row.ItemArray = new object[] {VPATIENTID,DCREATEDATE,VNAME,PINYINMA,WUBIMA,NSEX,DBIRTHDATE,VBIRTHPLACE,VBIRTHPLACEDETAIL,VNATION,VNATIONNAME,VIDTYPE,VIDNO,VUNITINCONTRACT,VUNITINCONTRACTNAME,VMAILINGADDRESS,VZIPID,VPHONENUMBERHOME,VPHONENUMBERBUSINESS,VLINKMAN,VRELATIONSHIP,VNEXTOFKINADDR,VNEXTOFKINZIPID,VPHONE,DLASTVISITDATE,NVIPINDICATOR,VOPERATORID,VDEGREE,VRACE,VRELIGION,VMOTHERLANGUAGE,VFOREIGNLANGUAGE,VVIPNO,VENGLISHNAME,VREMARKS,NCOUNTRY,NPROVINCES,NCITY,NSTREET,NPROFESSIONID,NIDENTITY,VPRESENTADDRESS,VISITNO,NMARRY,VORGAN,NDICAREAID,VDIAGNOSE,NDISEASEID,NZYZEXZ,NZYYPXZ};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowGHSF_GHSF_PATIENTINFO FindByVPATIENTID(System.String VPATIENTID) {
            return ((RowGHSF_GHSF_PATIENTINFO)(this.Rows.Find(new object[] {
                        VPATIENTID})));
        }
		
		/// 
		/// 得到DataSet的列举器。
		/// 
        public System.Collections.IEnumerator GetEnumerator() {
            return this.Rows.GetEnumerator();
        }
        
		/// 
		/// Clone新的DataTable。
		/// 
        public override DataTable Clone() {
            DataTableGHSF_GHSF_PATIENTINFO cln = ((DataTableGHSF_GHSF_PATIENTINFO)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableGHSF_GHSF_PATIENTINFO();
        }
        
        internal void InitVars() 
        {	
            this.columnVPATIENTID = this.Columns["VPATIENTID"];
            this.columnDCREATEDATE = this.Columns["DCREATEDATE"];
            this.columnVNAME = this.Columns["VNAME"];
            this.columnPINYINMA = this.Columns["PINYINMA"];
            this.columnWUBIMA = this.Columns["WUBIMA"];
            this.columnNSEX = this.Columns["NSEX"];
            this.columnDBIRTHDATE = this.Columns["DBIRTHDATE"];
            this.columnVBIRTHPLACE = this.Columns["VBIRTHPLACE"];
            this.columnVBIRTHPLACEDETAIL = this.Columns["VBIRTHPLACEDETAIL"];
            this.columnVNATION = this.Columns["VNATION"];
            this.columnVNATIONNAME = this.Columns["VNATIONNAME"];
            this.columnVIDTYPE = this.Columns["VIDTYPE"];
            this.columnVIDNO = this.Columns["VIDNO"];
            this.columnVUNITINCONTRACT = this.Columns["VUNITINCONTRACT"];
            this.columnVUNITINCONTRACTNAME = this.Columns["VUNITINCONTRACTNAME"];
            this.columnVMAILINGADDRESS = this.Columns["VMAILINGADDRESS"];
            this.columnVZIPID = this.Columns["VZIPID"];
            this.columnVPHONENUMBERHOME = this.Columns["VPHONENUMBERHOME"];
            this.columnVPHONENUMBERBUSINESS = this.Columns["VPHONENUMBERBUSINESS"];
            this.columnVLINKMAN = this.Columns["VLINKMAN"];
            this.columnVRELATIONSHIP = this.Columns["VRELATIONSHIP"];
            this.columnVNEXTOFKINADDR = this.Columns["VNEXTOFKINADDR"];
            this.columnVNEXTOFKINZIPID = this.Columns["VNEXTOFKINZIPID"];
            this.columnVPHONE = this.Columns["VPHONE"];
            this.columnDLASTVISITDATE = this.Columns["DLASTVISITDATE"];
            this.columnNVIPINDICATOR = this.Columns["NVIPINDICATOR"];
            this.columnVOPERATORID = this.Columns["VOPERATORID"];
            this.columnVDEGREE = this.Columns["VDEGREE"];
            this.columnVRACE = this.Columns["VRACE"];
            this.columnVRELIGION = this.Columns["VRELIGION"];
            this.columnVMOTHERLANGUAGE = this.Columns["VMOTHERLANGUAGE"];
            this.columnVFOREIGNLANGUAGE = this.Columns["VFOREIGNLANGUAGE"];
            this.columnVVIPNO = this.Columns["VVIPNO"];
            this.columnVENGLISHNAME = this.Columns["VENGLISHNAME"];
            this.columnVREMARKS = this.Columns["VREMARKS"];
            this.columnNCOUNTRY = this.Columns["NCOUNTRY"];
            this.columnNPROVINCES = this.Columns["NPROVINCES"];
            this.columnNCITY = this.Columns["NCITY"];
            this.columnNSTREET = this.Columns["NSTREET"];
            this.columnNPROFESSIONID = this.Columns["NPROFESSIONID"];
            this.columnNIDENTITY = this.Columns["NIDENTITY"];
            this.columnVPRESENTADDRESS = this.Columns["VPRESENTADDRESS"];
            this.columnVISITNO = this.Columns["VISITNO"];
            this.columnNMARRY = this.Columns["NMARRY"];
            this.columnVORGAN = this.Columns["VORGAN"];
            this.columnNDICAREAID = this.Columns["NDICAREAID"];
            this.columnVDIAGNOSE = this.Columns["VDIAGNOSE"];
            this.columnNDISEASEID = this.Columns["NDISEASEID"];
            this.columnNZYZEXZ = this.Columns["NZYZEXZ"];
            this.columnNZYYPXZ = this.Columns["NZYYPXZ"];
        }
        
        private void InitClass() 
        {	
            this.columnVPATIENTID = new DataColumn("VPATIENTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENTID.MaxLength = 10;
            this.columnVPATIENTID.AllowDBNull = false;
            this.columnVPATIENTID.Unique = true;
            
            this.Columns.Add(this.columnVPATIENTID);
			
            this.columnDCREATEDATE = new DataColumn("DCREATEDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATEDATE.AllowDBNull = false;
            this.Columns.Add(this.columnDCREATEDATE);
			
            this.columnVNAME = new DataColumn("VNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNAME.MaxLength = 20;
            this.columnVNAME.AllowDBNull = false;
            this.Columns.Add(this.columnVNAME);
			
            this.columnPINYINMA = new DataColumn("PINYINMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPINYINMA.MaxLength = 20;
            this.columnPINYINMA.AllowDBNull = true;
            this.Columns.Add(this.columnPINYINMA);
			
            this.columnWUBIMA = new DataColumn("WUBIMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnWUBIMA.MaxLength = 20;
            this.columnWUBIMA.AllowDBNull = true;
            this.Columns.Add(this.columnWUBIMA);
			
            this.columnNSEX = new DataColumn("NSEX", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSEX.AllowDBNull = false;
            this.Columns.Add(this.columnNSEX);
			
            this.columnDBIRTHDATE = new DataColumn("DBIRTHDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDBIRTHDATE.AllowDBNull = false;
            this.Columns.Add(this.columnDBIRTHDATE);
			
            this.columnVBIRTHPLACE = new DataColumn("VBIRTHPLACE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVBIRTHPLACE.MaxLength = 6;
            this.columnVBIRTHPLACE.AllowDBNull = true;
            this.Columns.Add(this.columnVBIRTHPLACE);
			
            this.columnVBIRTHPLACEDETAIL = new DataColumn("VBIRTHPLACEDETAIL", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVBIRTHPLACEDETAIL.MaxLength = 50;
            this.columnVBIRTHPLACEDETAIL.AllowDBNull = true;
            this.Columns.Add(this.columnVBIRTHPLACEDETAIL);
			
            this.columnVNATION = new DataColumn("VNATION", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNATION.MaxLength = 10;
            this.columnVNATION.AllowDBNull = true;
            this.Columns.Add(this.columnVNATION);
			
            this.columnVNATIONNAME = new DataColumn("VNATIONNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNATIONNAME.MaxLength = 20;
            this.columnVNATIONNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVNATIONNAME);
			
            this.columnVIDTYPE = new DataColumn("VIDTYPE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVIDTYPE.MaxLength = 10;
            this.columnVIDTYPE.AllowDBNull = true;
            this.Columns.Add(this.columnVIDTYPE);
			
            this.columnVIDNO = new DataColumn("VIDNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVIDNO.MaxLength = 18;
            this.columnVIDNO.AllowDBNull = true;
            this.Columns.Add(this.columnVIDNO);
			
            this.columnVUNITINCONTRACT = new DataColumn("VUNITINCONTRACT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVUNITINCONTRACT.MaxLength = 10;
            this.columnVUNITINCONTRACT.AllowDBNull = true;
            this.Columns.Add(this.columnVUNITINCONTRACT);
			
            this.columnVUNITINCONTRACTNAME = new DataColumn("VUNITINCONTRACTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVUNITINCONTRACTNAME.MaxLength = 200;
            this.columnVUNITINCONTRACTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVUNITINCONTRACTNAME);
			
            this.columnVMAILINGADDRESS = new DataColumn("VMAILINGADDRESS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVMAILINGADDRESS.MaxLength = 50;
            this.columnVMAILINGADDRESS.AllowDBNull = true;
            this.Columns.Add(this.columnVMAILINGADDRESS);
			
            this.columnVZIPID = new DataColumn("VZIPID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVZIPID.MaxLength = 6;
            this.columnVZIPID.AllowDBNull = true;
            this.Columns.Add(this.columnVZIPID);
			
            this.columnVPHONENUMBERHOME = new DataColumn("VPHONENUMBERHOME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPHONENUMBERHOME.MaxLength = 16;
            this.columnVPHONENUMBERHOME.AllowDBNull = true;
            this.Columns.Add(this.columnVPHONENUMBERHOME);
			
            this.columnVPHONENUMBERBUSINESS = new DataColumn("VPHONENUMBERBUSINESS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPHONENUMBERBUSINESS.MaxLength = 16;
            this.columnVPHONENUMBERBUSINESS.AllowDBNull = true;
            this.Columns.Add(this.columnVPHONENUMBERBUSINESS);
			
            this.columnVLINKMAN = new DataColumn("VLINKMAN", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVLINKMAN.MaxLength = 20;
            this.columnVLINKMAN.AllowDBNull = true;
            this.Columns.Add(this.columnVLINKMAN);
			
            this.columnVRELATIONSHIP = new DataColumn("VRELATIONSHIP", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVRELATIONSHIP.MaxLength = 2;
            this.columnVRELATIONSHIP.AllowDBNull = true;
            this.Columns.Add(this.columnVRELATIONSHIP);
			
            this.columnVNEXTOFKINADDR = new DataColumn("VNEXTOFKINADDR", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNEXTOFKINADDR.MaxLength = 50;
            this.columnVNEXTOFKINADDR.AllowDBNull = true;
            this.Columns.Add(this.columnVNEXTOFKINADDR);
			
            this.columnVNEXTOFKINZIPID = new DataColumn("VNEXTOFKINZIPID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNEXTOFKINZIPID.MaxLength = 6;
            this.columnVNEXTOFKINZIPID.AllowDBNull = true;
            this.Columns.Add(this.columnVNEXTOFKINZIPID);
			
            this.columnVPHONE = new DataColumn("VPHONE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPHONE.MaxLength = 16;
            this.columnVPHONE.AllowDBNull = true;
            this.Columns.Add(this.columnVPHONE);
			
            this.columnDLASTVISITDATE = new DataColumn("DLASTVISITDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDLASTVISITDATE.AllowDBNull = true;
            this.Columns.Add(this.columnDLASTVISITDATE);
			
            this.columnNVIPINDICATOR = new DataColumn("NVIPINDICATOR", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNVIPINDICATOR.AllowDBNull = true;
            this.Columns.Add(this.columnNVIPINDICATOR);
			
            this.columnVOPERATORID = new DataColumn("VOPERATORID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVOPERATORID.MaxLength = 20;
            this.columnVOPERATORID.AllowDBNull = true;
            this.Columns.Add(this.columnVOPERATORID);
			
            this.columnVDEGREE = new DataColumn("VDEGREE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEGREE.MaxLength = 10;
            this.columnVDEGREE.AllowDBNull = true;
            this.Columns.Add(this.columnVDEGREE);
			
            this.columnVRACE = new DataColumn("VRACE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVRACE.MaxLength = 10;
            this.columnVRACE.AllowDBNull = true;
            this.Columns.Add(this.columnVRACE);
			
            this.columnVRELIGION = new DataColumn("VRELIGION", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVRELIGION.MaxLength = 16;
            this.columnVRELIGION.AllowDBNull = true;
            this.Columns.Add(this.columnVRELIGION);
			
            this.columnVMOTHERLANGUAGE = new DataColumn("VMOTHERLANGUAGE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVMOTHERLANGUAGE.MaxLength = 16;
            this.columnVMOTHERLANGUAGE.AllowDBNull = true;
            this.Columns.Add(this.columnVMOTHERLANGUAGE);
			
            this.columnVFOREIGNLANGUAGE = new DataColumn("VFOREIGNLANGUAGE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVFOREIGNLANGUAGE.MaxLength = 16;
            this.columnVFOREIGNLANGUAGE.AllowDBNull = true;
            this.Columns.Add(this.columnVFOREIGNLANGUAGE);
			
            this.columnVVIPNO = new DataColumn("VVIPNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVVIPNO.MaxLength = 18;
            this.columnVVIPNO.AllowDBNull = true;
            this.Columns.Add(this.columnVVIPNO);
			
            this.columnVENGLISHNAME = new DataColumn("VENGLISHNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVENGLISHNAME.MaxLength = 50;
            this.columnVENGLISHNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVENGLISHNAME);
			
            this.columnVREMARKS = new DataColumn("VREMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREMARKS.MaxLength = 50;
            this.columnVREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnVREMARKS);
			
            this.columnNCOUNTRY = new DataColumn("NCOUNTRY", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNCOUNTRY.AllowDBNull = true;
            this.Columns.Add(this.columnNCOUNTRY);
			
            this.columnNPROVINCES = new DataColumn("NPROVINCES", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNPROVINCES.AllowDBNull = true;
            this.Columns.Add(this.columnNPROVINCES);
			
            this.columnNCITY = new DataColumn("NCITY", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNCITY.AllowDBNull = true;
            this.Columns.Add(this.columnNCITY);
			
            this.columnNSTREET = new DataColumn("NSTREET", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNSTREET.AllowDBNull = true;
            this.Columns.Add(this.columnNSTREET);
			
            this.columnNPROFESSIONID = new DataColumn("NPROFESSIONID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNPROFESSIONID.AllowDBNull = true;
            this.Columns.Add(this.columnNPROFESSIONID);
			
            this.columnNIDENTITY = new DataColumn("NIDENTITY", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNIDENTITY.MaxLength = 10;
            this.columnNIDENTITY.AllowDBNull = true;
            this.Columns.Add(this.columnNIDENTITY);
			
            this.columnVPRESENTADDRESS = new DataColumn("VPRESENTADDRESS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESENTADDRESS.MaxLength = 100;
            this.columnVPRESENTADDRESS.AllowDBNull = true;
            this.Columns.Add(this.columnVPRESENTADDRESS);
			
            this.columnVISITNO = new DataColumn("VISITNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVISITNO.MaxLength = 10;
            this.columnVISITNO.AllowDBNull = true;
            this.Columns.Add(this.columnVISITNO);
			
            this.columnNMARRY = new DataColumn("NMARRY", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNMARRY.AllowDBNull = true;
            this.Columns.Add(this.columnNMARRY);
			
            this.columnVORGAN = new DataColumn("VORGAN", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVORGAN.MaxLength = 50;
            this.columnVORGAN.AllowDBNull = true;
            this.Columns.Add(this.columnVORGAN);
			
            this.columnNDICAREAID = new DataColumn("NDICAREAID", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNDICAREAID.AllowDBNull = true;
            this.Columns.Add(this.columnNDICAREAID);
			
            this.columnVDIAGNOSE = new DataColumn("VDIAGNOSE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDIAGNOSE.MaxLength = 100;
            this.columnVDIAGNOSE.AllowDBNull = true;
            this.Columns.Add(this.columnVDIAGNOSE);
			
            this.columnNDISEASEID = new DataColumn("NDISEASEID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNDISEASEID.AllowDBNull = true;
            this.Columns.Add(this.columnNDISEASEID);
			
            this.columnNZYZEXZ = new DataColumn("NZYZEXZ", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNZYZEXZ.AllowDBNull = true;
            this.Columns.Add(this.columnNZYZEXZ);
			
            this.columnNZYYPXZ = new DataColumn("NZYYPXZ", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNZYYPXZ.AllowDBNull = true;
            this.Columns.Add(this.columnNZYYPXZ);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowGHSF_GHSF_PATIENTINFO NewRowGHSF_GHSF_PATIENTINFO() {
            return ((RowGHSF_GHSF_PATIENTINFO)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowGHSF_GHSF_PATIENTINFO(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowGHSF_GHSF_PATIENTINFO);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedGHSF_GHSF_PATIENTINFO != null)) {
                this.RowChangedGHSF_GHSF_PATIENTINFO(this, new RowChangeEventGHSF_GHSF_PATIENTINFO(((RowGHSF_GHSF_PATIENTINFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingGHSF_GHSF_PATIENTINFO != null)) {
                this.RowChangingGHSF_GHSF_PATIENTINFO(this, new RowChangeEventGHSF_GHSF_PATIENTINFO(((RowGHSF_GHSF_PATIENTINFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedGHSF_GHSF_PATIENTINFO != null)) {
                this.RowDeletedGHSF_GHSF_PATIENTINFO(this, new RowChangeEventGHSF_GHSF_PATIENTINFO(((RowGHSF_GHSF_PATIENTINFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingGHSF_GHSF_PATIENTINFO != null)) {
                this.RowDeletingGHSF_GHSF_PATIENTINFO(this, new RowChangeEventGHSF_GHSF_PATIENTINFO(((RowGHSF_GHSF_PATIENTINFO)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowGHSF_GHSF_PATIENTINFO(RowGHSF_GHSF_PATIENTINFO row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowGHSF_GHSF_PATIENTINFO
	/// 
	/// 数据表GHSF_GHSF_PATIENTINFO行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowGHSF_GHSF_PATIENTINFO : DataRow 
    {
        
        private DataTableGHSF_GHSF_PATIENTINFO tableGHSF_GHSF_PATIENTINFO;
        
        internal RowGHSF_GHSF_PATIENTINFO(DataRowBuilder rb) : base(rb) 
        {
            this.tableGHSF_GHSF_PATIENTINFO = ((DataTableGHSF_GHSF_PATIENTINFO)(this.Table));
        }        
		
		/// 
		/// 字段VPATIENTID所映射的属性。
		/// 
        public System.String VPATIENTID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPATIENTID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPATIENTID] = value;
            }
        }
        
		/// 
		/// 字段DCREATEDATE所映射的属性。
		/// 
        public System.DateTime DCREATEDATE
        {
            get 
            {	
                return ((System.DateTime)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnDCREATEDATE])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnDCREATEDATE] = value;
            }
        }
        
		/// 
		/// 字段VNAME所映射的属性。
		/// 
        public System.String VNAME
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNAME])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNAME] = value;
            }
        }
        
		/// 
		/// 字段PINYINMA所映射的属性。
		/// 
        public System.String PINYINMA
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnPINYINMA])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnPINYINMA] = value;
            }
        }
        
		/// 
		/// 字段WUBIMA所映射的属性。
		/// 
        public System.String WUBIMA
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnWUBIMA])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnWUBIMA] = value;
            }
        }
        
		/// 
		/// 字段NSEX所映射的属性。
		/// 
        public System.Int16 NSEX
        {
            get 
            {	
                return ((System.Int16)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNSEX])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNSEX] = value;
            }
        }
        
		/// 
		/// 字段DBIRTHDATE所映射的属性。
		/// 
        public System.DateTime DBIRTHDATE
        {
            get 
            {	
                return ((System.DateTime)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnDBIRTHDATE])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnDBIRTHDATE] = value;
            }
        }
        
		/// 
		/// 字段VBIRTHPLACE所映射的属性。
		/// 
        public System.String VBIRTHPLACE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVBIRTHPLACE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVBIRTHPLACE] = value;
            }
        }
        
		/// 
		/// 字段VBIRTHPLACEDETAIL所映射的属性。
		/// 
        public System.String VBIRTHPLACEDETAIL
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVBIRTHPLACEDETAIL])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVBIRTHPLACEDETAIL] = value;
            }
        }
        
		/// 
		/// 字段VNATION所映射的属性。
		/// 
        public System.String VNATION
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNATION])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNATION] = value;
            }
        }
        
		/// 
		/// 字段VNATIONNAME所映射的属性。
		/// 
        public System.String VNATIONNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNATIONNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNATIONNAME] = value;
            }
        }
        
		/// 
		/// 字段VIDTYPE所映射的属性。
		/// 
        public System.String VIDTYPE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVIDTYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVIDTYPE] = value;
            }
        }
        
		/// 
		/// 字段VIDNO所映射的属性。
		/// 
        public System.String VIDNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVIDNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVIDNO] = value;
            }
        }
        
		/// 
		/// 字段VUNITINCONTRACT所映射的属性。
		/// 
        public System.String VUNITINCONTRACT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVUNITINCONTRACT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVUNITINCONTRACT] = value;
            }
        }
        
		/// 
		/// 字段VUNITINCONTRACTNAME所映射的属性。
		/// 
        public System.String VUNITINCONTRACTNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVUNITINCONTRACTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVUNITINCONTRACTNAME] = value;
            }
        }
        
		/// 
		/// 字段VMAILINGADDRESS所映射的属性。
		/// 
        public System.String VMAILINGADDRESS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVMAILINGADDRESS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVMAILINGADDRESS] = value;
            }
        }
        
		/// 
		/// 字段VZIPID所映射的属性。
		/// 
        public System.String VZIPID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVZIPID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVZIPID] = value;
            }
        }
        
		/// 
		/// 字段VPHONENUMBERHOME所映射的属性。
		/// 
        public System.String VPHONENUMBERHOME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONENUMBERHOME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONENUMBERHOME] = value;
            }
        }
        
		/// 
		/// 字段VPHONENUMBERBUSINESS所映射的属性。
		/// 
        public System.String VPHONENUMBERBUSINESS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONENUMBERBUSINESS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONENUMBERBUSINESS] = value;
            }
        }
        
		/// 
		/// 字段VLINKMAN所映射的属性。
		/// 
        public System.String VLINKMAN
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVLINKMAN])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVLINKMAN] = value;
            }
        }
        
		/// 
		/// 字段VRELATIONSHIP所映射的属性。
		/// 
        public System.String VRELATIONSHIP
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVRELATIONSHIP])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVRELATIONSHIP] = value;
            }
        }
        
		/// 
		/// 字段VNEXTOFKINADDR所映射的属性。
		/// 
        public System.String VNEXTOFKINADDR
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNEXTOFKINADDR])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNEXTOFKINADDR] = value;
            }
        }
        
		/// 
		/// 字段VNEXTOFKINZIPID所映射的属性。
		/// 
        public System.String VNEXTOFKINZIPID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNEXTOFKINZIPID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNEXTOFKINZIPID] = value;
            }
        }
        
		/// 
		/// 字段VPHONE所映射的属性。
		/// 
        public System.String VPHONE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONE] = value;
            }
        }
        
		/// 
		/// 字段DLASTVISITDATE所映射的属性。
		/// 
        public System.DateTime DLASTVISITDATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnDLASTVISITDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnDLASTVISITDATE] = value;
            }
        }
        
		/// 
		/// 字段NVIPINDICATOR所映射的属性。
		/// 
        public System.Int16 NVIPINDICATOR
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNVIPINDICATOR])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNVIPINDICATOR] = value;
            }
        }
        
		/// 
		/// 字段VOPERATORID所映射的属性。
		/// 
        public System.String VOPERATORID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVOPERATORID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVOPERATORID] = value;
            }
        }
        
		/// 
		/// 字段VDEGREE所映射的属性。
		/// 
        public System.String VDEGREE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVDEGREE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVDEGREE] = value;
            }
        }
        
		/// 
		/// 字段VRACE所映射的属性。
		/// 
        public System.String VRACE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVRACE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVRACE] = value;
            }
        }
        
		/// 
		/// 字段VRELIGION所映射的属性。
		/// 
        public System.String VRELIGION
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVRELIGION])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVRELIGION] = value;
            }
        }
        
		/// 
		/// 字段VMOTHERLANGUAGE所映射的属性。
		/// 
        public System.String VMOTHERLANGUAGE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVMOTHERLANGUAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVMOTHERLANGUAGE] = value;
            }
        }
        
		/// 
		/// 字段VFOREIGNLANGUAGE所映射的属性。
		/// 
        public System.String VFOREIGNLANGUAGE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVFOREIGNLANGUAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVFOREIGNLANGUAGE] = value;
            }
        }
        
		/// 
		/// 字段VVIPNO所映射的属性。
		/// 
        public System.String VVIPNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVVIPNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVVIPNO] = value;
            }
        }
        
		/// 
		/// 字段VENGLISHNAME所映射的属性。
		/// 
        public System.String VENGLISHNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVENGLISHNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVENGLISHNAME] = value;
            }
        }
        
		/// 
		/// 字段VREMARKS所映射的属性。
		/// 
        public System.String VREMARKS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVREMARKS] = value;
            }
        }
        
		/// 
		/// 字段NCOUNTRY所映射的属性。
		/// 
        public System.Int32 NCOUNTRY
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNCOUNTRY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNCOUNTRY] = value;
            }
        }
        
		/// 
		/// 字段NPROVINCES所映射的属性。
		/// 
        public System.Int32 NPROVINCES
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNPROVINCES])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNPROVINCES] = value;
            }
        }
        
		/// 
		/// 字段NCITY所映射的属性。
		/// 
        public System.Int32 NCITY
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNCITY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNCITY] = value;
            }
        }
        
		/// 
		/// 字段NSTREET所映射的属性。
		/// 
        public System.Int32 NSTREET
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNSTREET])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNSTREET] = value;
            }
        }
        
		/// 
		/// 字段NPROFESSIONID所映射的属性。
		/// 
        public System.Int32 NPROFESSIONID
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNPROFESSIONID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNPROFESSIONID] = value;
            }
        }
        
		/// 
		/// 字段NIDENTITY所映射的属性。
		/// 
        public System.String NIDENTITY
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNIDENTITY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNIDENTITY] = value;
            }
        }
        
		/// 
		/// 字段VPRESENTADDRESS所映射的属性。
		/// 
        public System.String VPRESENTADDRESS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPRESENTADDRESS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPRESENTADDRESS] = value;
            }
        }
        
		/// 
		/// 字段VISITNO所映射的属性。
		/// 
        public System.String VISITNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVISITNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVISITNO] = value;
            }
        }
        
		/// 
		/// 字段NMARRY所映射的属性。
		/// 
        public System.Int16 NMARRY
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNMARRY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNMARRY] = value;
            }
        }
        
		/// 
		/// 字段VORGAN所映射的属性。
		/// 
        public System.String VORGAN
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVORGAN])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVORGAN] = value;
            }
        }
        
		/// 
		/// 字段NDICAREAID所映射的属性。
		/// 
        public System.Decimal NDICAREAID
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNDICAREAID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNDICAREAID] = value;
            }
        }
        
		/// 
		/// 字段VDIAGNOSE所映射的属性。
		/// 
        public System.String VDIAGNOSE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVDIAGNOSE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVDIAGNOSE] = value;
            }
        }
        
		/// 
		/// 字段NDISEASEID所映射的属性。
		/// 
        public System.Int32 NDISEASEID
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNDISEASEID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNDISEASEID] = value;
            }
        }
        
		/// 
		/// 字段NZYZEXZ所映射的属性。
		/// 
        public System.Decimal NZYZEXZ
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNZYZEXZ])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNZYZEXZ] = value;
            }
        }
        
		/// 
		/// 字段NZYYPXZ所映射的属性。
		/// 
        public System.Decimal NZYYPXZ
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNZYYPXZ])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNZYYPXZ] = value;
            }
        }
        
		/// 
		/// 判断字段PINYINMA是否为空。
		/// 
        public bool IsPINYINMANull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnPINYINMA);
        }

		/// 
		/// 设置字段PINYINMA为空值。
		/// 
        public void SetPINYINMANull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnPINYINMA] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段WUBIMA是否为空。
		/// 
        public bool IsWUBIMANull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnWUBIMA);
        }

		/// 
		/// 设置字段WUBIMA为空值。
		/// 
        public void SetWUBIMANull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnWUBIMA] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VBIRTHPLACE是否为空。
		/// 
        public bool IsVBIRTHPLACENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVBIRTHPLACE);
        }

		/// 
		/// 设置字段VBIRTHPLACE为空值。
		/// 
        public void SetVBIRTHPLACENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVBIRTHPLACE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VBIRTHPLACEDETAIL是否为空。
		/// 
        public bool IsVBIRTHPLACEDETAILNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVBIRTHPLACEDETAIL);
        }

		/// 
		/// 设置字段VBIRTHPLACEDETAIL为空值。
		/// 
        public void SetVBIRTHPLACEDETAILNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVBIRTHPLACEDETAIL] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNATION是否为空。
		/// 
        public bool IsVNATIONNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVNATION);
        }

		/// 
		/// 设置字段VNATION为空值。
		/// 
        public void SetVNATIONNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNATION] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNATIONNAME是否为空。
		/// 
        public bool IsVNATIONNAMENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVNATIONNAME);
        }

		/// 
		/// 设置字段VNATIONNAME为空值。
		/// 
        public void SetVNATIONNAMENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNATIONNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VIDTYPE是否为空。
		/// 
        public bool IsVIDTYPENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVIDTYPE);
        }

		/// 
		/// 设置字段VIDTYPE为空值。
		/// 
        public void SetVIDTYPENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVIDTYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VIDNO是否为空。
		/// 
        public bool IsVIDNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVIDNO);
        }

		/// 
		/// 设置字段VIDNO为空值。
		/// 
        public void SetVIDNONull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVIDNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VUNITINCONTRACT是否为空。
		/// 
        public bool IsVUNITINCONTRACTNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVUNITINCONTRACT);
        }

		/// 
		/// 设置字段VUNITINCONTRACT为空值。
		/// 
        public void SetVUNITINCONTRACTNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVUNITINCONTRACT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VUNITINCONTRACTNAME是否为空。
		/// 
        public bool IsVUNITINCONTRACTNAMENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVUNITINCONTRACTNAME);
        }

		/// 
		/// 设置字段VUNITINCONTRACTNAME为空值。
		/// 
        public void SetVUNITINCONTRACTNAMENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVUNITINCONTRACTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VMAILINGADDRESS是否为空。
		/// 
        public bool IsVMAILINGADDRESSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVMAILINGADDRESS);
        }

		/// 
		/// 设置字段VMAILINGADDRESS为空值。
		/// 
        public void SetVMAILINGADDRESSNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVMAILINGADDRESS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VZIPID是否为空。
		/// 
        public bool IsVZIPIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVZIPID);
        }

		/// 
		/// 设置字段VZIPID为空值。
		/// 
        public void SetVZIPIDNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVZIPID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPHONENUMBERHOME是否为空。
		/// 
        public bool IsVPHONENUMBERHOMENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONENUMBERHOME);
        }

		/// 
		/// 设置字段VPHONENUMBERHOME为空值。
		/// 
        public void SetVPHONENUMBERHOMENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONENUMBERHOME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPHONENUMBERBUSINESS是否为空。
		/// 
        public bool IsVPHONENUMBERBUSINESSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONENUMBERBUSINESS);
        }

		/// 
		/// 设置字段VPHONENUMBERBUSINESS为空值。
		/// 
        public void SetVPHONENUMBERBUSINESSNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONENUMBERBUSINESS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VLINKMAN是否为空。
		/// 
        public bool IsVLINKMANNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVLINKMAN);
        }

		/// 
		/// 设置字段VLINKMAN为空值。
		/// 
        public void SetVLINKMANNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVLINKMAN] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VRELATIONSHIP是否为空。
		/// 
        public bool IsVRELATIONSHIPNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVRELATIONSHIP);
        }

		/// 
		/// 设置字段VRELATIONSHIP为空值。
		/// 
        public void SetVRELATIONSHIPNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVRELATIONSHIP] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNEXTOFKINADDR是否为空。
		/// 
        public bool IsVNEXTOFKINADDRNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVNEXTOFKINADDR);
        }

		/// 
		/// 设置字段VNEXTOFKINADDR为空值。
		/// 
        public void SetVNEXTOFKINADDRNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNEXTOFKINADDR] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNEXTOFKINZIPID是否为空。
		/// 
        public bool IsVNEXTOFKINZIPIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVNEXTOFKINZIPID);
        }

		/// 
		/// 设置字段VNEXTOFKINZIPID为空值。
		/// 
        public void SetVNEXTOFKINZIPIDNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVNEXTOFKINZIPID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPHONE是否为空。
		/// 
        public bool IsVPHONENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONE);
        }

		/// 
		/// 设置字段VPHONE为空值。
		/// 
        public void SetVPHONENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPHONE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DLASTVISITDATE是否为空。
		/// 
        public bool IsDLASTVISITDATENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnDLASTVISITDATE);
        }

		/// 
		/// 设置字段DLASTVISITDATE为空值。
		/// 
        public void SetDLASTVISITDATENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnDLASTVISITDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NVIPINDICATOR是否为空。
		/// 
        public bool IsNVIPINDICATORNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNVIPINDICATOR);
        }

		/// 
		/// 设置字段NVIPINDICATOR为空值。
		/// 
        public void SetNVIPINDICATORNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNVIPINDICATOR] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VOPERATORID是否为空。
		/// 
        public bool IsVOPERATORIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVOPERATORID);
        }

		/// 
		/// 设置字段VOPERATORID为空值。
		/// 
        public void SetVOPERATORIDNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVOPERATORID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEGREE是否为空。
		/// 
        public bool IsVDEGREENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVDEGREE);
        }

		/// 
		/// 设置字段VDEGREE为空值。
		/// 
        public void SetVDEGREENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVDEGREE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VRACE是否为空。
		/// 
        public bool IsVRACENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVRACE);
        }

		/// 
		/// 设置字段VRACE为空值。
		/// 
        public void SetVRACENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVRACE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VRELIGION是否为空。
		/// 
        public bool IsVRELIGIONNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVRELIGION);
        }

		/// 
		/// 设置字段VRELIGION为空值。
		/// 
        public void SetVRELIGIONNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVRELIGION] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VMOTHERLANGUAGE是否为空。
		/// 
        public bool IsVMOTHERLANGUAGENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVMOTHERLANGUAGE);
        }

		/// 
		/// 设置字段VMOTHERLANGUAGE为空值。
		/// 
        public void SetVMOTHERLANGUAGENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVMOTHERLANGUAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VFOREIGNLANGUAGE是否为空。
		/// 
        public bool IsVFOREIGNLANGUAGENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVFOREIGNLANGUAGE);
        }

		/// 
		/// 设置字段VFOREIGNLANGUAGE为空值。
		/// 
        public void SetVFOREIGNLANGUAGENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVFOREIGNLANGUAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VVIPNO是否为空。
		/// 
        public bool IsVVIPNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVVIPNO);
        }

		/// 
		/// 设置字段VVIPNO为空值。
		/// 
        public void SetVVIPNONull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVVIPNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VENGLISHNAME是否为空。
		/// 
        public bool IsVENGLISHNAMENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVENGLISHNAME);
        }

		/// 
		/// 设置字段VENGLISHNAME为空值。
		/// 
        public void SetVENGLISHNAMENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVENGLISHNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VREMARKS是否为空。
		/// 
        public bool IsVREMARKSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVREMARKS);
        }

		/// 
		/// 设置字段VREMARKS为空值。
		/// 
        public void SetVREMARKSNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCOUNTRY是否为空。
		/// 
        public bool IsNCOUNTRYNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNCOUNTRY);
        }

		/// 
		/// 设置字段NCOUNTRY为空值。
		/// 
        public void SetNCOUNTRYNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNCOUNTRY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPROVINCES是否为空。
		/// 
        public bool IsNPROVINCESNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNPROVINCES);
        }

		/// 
		/// 设置字段NPROVINCES为空值。
		/// 
        public void SetNPROVINCESNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNPROVINCES] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCITY是否为空。
		/// 
        public bool IsNCITYNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNCITY);
        }

		/// 
		/// 设置字段NCITY为空值。
		/// 
        public void SetNCITYNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNCITY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSTREET是否为空。
		/// 
        public bool IsNSTREETNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNSTREET);
        }

		/// 
		/// 设置字段NSTREET为空值。
		/// 
        public void SetNSTREETNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNSTREET] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPROFESSIONID是否为空。
		/// 
        public bool IsNPROFESSIONIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNPROFESSIONID);
        }

		/// 
		/// 设置字段NPROFESSIONID为空值。
		/// 
        public void SetNPROFESSIONIDNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNPROFESSIONID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NIDENTITY是否为空。
		/// 
        public bool IsNIDENTITYNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNIDENTITY);
        }

		/// 
		/// 设置字段NIDENTITY为空值。
		/// 
        public void SetNIDENTITYNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNIDENTITY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRESENTADDRESS是否为空。
		/// 
        public bool IsVPRESENTADDRESSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVPRESENTADDRESS);
        }

		/// 
		/// 设置字段VPRESENTADDRESS为空值。
		/// 
        public void SetVPRESENTADDRESSNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVPRESENTADDRESS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VISITNO是否为空。
		/// 
        public bool IsVISITNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVISITNO);
        }

		/// 
		/// 设置字段VISITNO为空值。
		/// 
        public void SetVISITNONull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVISITNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NMARRY是否为空。
		/// 
        public bool IsNMARRYNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNMARRY);
        }

		/// 
		/// 设置字段NMARRY为空值。
		/// 
        public void SetNMARRYNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNMARRY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VORGAN是否为空。
		/// 
        public bool IsVORGANNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVORGAN);
        }

		/// 
		/// 设置字段VORGAN为空值。
		/// 
        public void SetVORGANNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVORGAN] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDICAREAID是否为空。
		/// 
        public bool IsNDICAREAIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNDICAREAID);
        }

		/// 
		/// 设置字段NDICAREAID为空值。
		/// 
        public void SetNDICAREAIDNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNDICAREAID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDIAGNOSE是否为空。
		/// 
        public bool IsVDIAGNOSENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnVDIAGNOSE);
        }

		/// 
		/// 设置字段VDIAGNOSE为空值。
		/// 
        public void SetVDIAGNOSENull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnVDIAGNOSE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDISEASEID是否为空。
		/// 
        public bool IsNDISEASEIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNDISEASEID);
        }

		/// 
		/// 设置字段NDISEASEID为空值。
		/// 
        public void SetNDISEASEIDNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNDISEASEID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NZYZEXZ是否为空。
		/// 
        public bool IsNZYZEXZNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNZYZEXZ);
        }

		/// 
		/// 设置字段NZYZEXZ为空值。
		/// 
        public void SetNZYZEXZNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNZYZEXZ] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NZYYPXZ是否为空。
		/// 
        public bool IsNZYYPXZNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_PATIENTINFO.ColumnNZYYPXZ);
        }

		/// 
		/// 设置字段NZYYPXZ为空值。
		/// 
        public void SetNZYYPXZNull() 
        {
            this[this.tableGHSF_GHSF_PATIENTINFO.ColumnNZYYPXZ] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventGHSF_GHSF_PATIENTINFO : EventArgs {
        
        private RowGHSF_GHSF_PATIENTINFO eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventGHSF_GHSF_PATIENTINFO(RowGHSF_GHSF_PATIENTINFO row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowGHSF_GHSF_PATIENTINFO Row {
            get {
                return this.eventRow;
            }
        }
        
        public DataRowAction Action {
            get {
                return this.eventAction;
            }
        }
    }
	#endregion
    
	#endregion
}	
	