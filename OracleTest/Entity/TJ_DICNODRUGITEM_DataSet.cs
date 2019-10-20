//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml;
using System.Runtime.Serialization;

namespace HYHISAPP.Entity
{
	#region DataSetTJ_DICNODRUGITEM
	/// 
	/// 对于TJ_DICNODRUGITEM的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetTJ_DICNODRUGITEM : DataSet
    {
		
		private DataTableTJ_TJ_DICNODRUGITEM tableTJ_TJ_DICNODRUGITEM;
		
        public DataSetTJ_DICNODRUGITEM() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetTJ_DICNODRUGITEM实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetTJ_DICNODRUGITEM GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetTJ_DICNODRUGITEM dataSet = (DataSetTJ_DICNODRUGITEM)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetTJ_DICNODRUGITEM entity = new DataSetTJ_DICNODRUGITEM();
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
        
        protected DataSetTJ_DICNODRUGITEM(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["TJ_TJ_DICNODRUGITEM"] != null)) 
                {
                    this.Tables.Add(new DataTableTJ_TJ_DICNODRUGITEM(ds.Tables["TJ_TJ_DICNODRUGITEM"]));
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
		/// 对于数据表TJ_TJ_DICNODRUGITEM的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableTJ_TJ_DICNODRUGITEM TJ_TJ_DICNODRUGITEM 
		{
			get
			{
				return this.tableTJ_TJ_DICNODRUGITEM;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetTJ_DICNODRUGITEM cln = ((DataSetTJ_DICNODRUGITEM)(base.Clone()));
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
			
			if ((ds.Tables["TJ_TJ_DICNODRUGITEM"] != null)) 
			{
				this.Tables.Add(new DataTableTJ_TJ_DICNODRUGITEM(ds.Tables["TJ_TJ_DICNODRUGITEM"]));
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
			
			this.tableTJ_TJ_DICNODRUGITEM = ((DataTableTJ_TJ_DICNODRUGITEM)(this.Tables["TJ_TJ_DICNODRUGITEM"]));
			if ((this.tableTJ_TJ_DICNODRUGITEM != null)) {
				this.tableTJ_TJ_DICNODRUGITEM.InitVars();
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
			
			this.tableTJ_TJ_DICNODRUGITEM = new DataTableTJ_TJ_DICNODRUGITEM();
			this.Tables.Add(this.tableTJ_TJ_DICNODRUGITEM);
			
		}
		
		private bool ShouldSerializeTJ_TJ_DICNODRUGITEM() 
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
	
    public delegate void RowChangeEventHandlerTJ_TJ_DICNODRUGITEM(object sender, RowChangeEventTJ_TJ_DICNODRUGITEM e);
	
	#region DataTableTJ_TJ_DICNODRUGITEM
	/// 
	/// 对于数据表TJ_TJ_DICNODRUGITEM的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableTJ_TJ_DICNODRUGITEM : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnEVITEMNAME;
		
        private DataColumn columnHISNITEMTYPE;
		
        private DataColumn columnLISUNIT;
		
        private DataColumn columnCREATE_DATE;
		
        private DataColumn columnCREATE_DEPT;
		
        private DataColumn columnCREATE_DOCT;
		
        private DataColumn columnLAST_DATE;
		
        private DataColumn columnLAST_DOCT;
		
        private DataColumn columnNITEMID;
		
        private DataColumn columnNNODRUGITEMPRICE;
		
        private DataColumn columnNNODRUGITEMUNIT;
		
        private DataColumn columnVDEPARTID;
		
        private DataColumn columnNISSTOP;
		
        private DataColumn columnNISPACK;
		
        private DataColumn columnVITEMDES;
		
        private DataColumn columnPINYINMA;
		
        private DataColumn columnWUBIMA;
		
        private DataColumn columnNCHARGETYPEID;
		
        private DataColumn columnVITEMNAME;
		
        private DataColumn columnDZHEKOU;
		
        private DataColumn columnNPFP;
		
        private DataColumn columnNJGLX;
		
        private DataColumn columnNCKSX;
		
        private DataColumn columnNCKXX;
		
        private DataColumn columnVPDTS;
		
        private DataColumn columnVPGTS;
		
        private DataColumn columnVZCTS;
		
        private DataColumn columnVYCTS;
		
        private DataColumn columnNCKZ;
		
        private DataColumn columnVNEGTS;
		
        private DataColumn columnVPOSTS;
		
        private DataColumn columnNHOSID;
		
        private DataColumn columnHISNITEMID;
		
        private DataColumn columnVITEMADDRESS;
		
        internal DataTableTJ_TJ_DICNODRUGITEM() : base("TJ_TJ_DICNODRUGITEM") 
        {
            this.InitClass();
        }
        
        internal DataTableTJ_TJ_DICNODRUGITEM(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnEVITEMNAME 
        {
            get 
            {
                return this.columnEVITEMNAME;
            }
        }
		
        public DataColumn ColumnHISNITEMTYPE 
        {
            get 
            {
                return this.columnHISNITEMTYPE;
            }
        }
		
        public DataColumn ColumnLISUNIT 
        {
            get 
            {
                return this.columnLISUNIT;
            }
        }
		
        public DataColumn ColumnCREATE_DATE 
        {
            get 
            {
                return this.columnCREATE_DATE;
            }
        }
		
        public DataColumn ColumnCREATE_DEPT 
        {
            get 
            {
                return this.columnCREATE_DEPT;
            }
        }
		
        public DataColumn ColumnCREATE_DOCT 
        {
            get 
            {
                return this.columnCREATE_DOCT;
            }
        }
		
        public DataColumn ColumnLAST_DATE 
        {
            get 
            {
                return this.columnLAST_DATE;
            }
        }
		
        public DataColumn ColumnLAST_DOCT 
        {
            get 
            {
                return this.columnLAST_DOCT;
            }
        }
		
        public DataColumn ColumnNITEMID 
        {
            get 
            {
                return this.columnNITEMID;
            }
        }
		
        public DataColumn ColumnNNODRUGITEMPRICE 
        {
            get 
            {
                return this.columnNNODRUGITEMPRICE;
            }
        }
		
        public DataColumn ColumnNNODRUGITEMUNIT 
        {
            get 
            {
                return this.columnNNODRUGITEMUNIT;
            }
        }
		
        public DataColumn ColumnVDEPARTID 
        {
            get 
            {
                return this.columnVDEPARTID;
            }
        }
		
        public DataColumn ColumnNISSTOP 
        {
            get 
            {
                return this.columnNISSTOP;
            }
        }
		
        public DataColumn ColumnNISPACK 
        {
            get 
            {
                return this.columnNISPACK;
            }
        }
		
        public DataColumn ColumnVITEMDES 
        {
            get 
            {
                return this.columnVITEMDES;
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
		
        public DataColumn ColumnNCHARGETYPEID 
        {
            get 
            {
                return this.columnNCHARGETYPEID;
            }
        }
		
        public DataColumn ColumnVITEMNAME 
        {
            get 
            {
                return this.columnVITEMNAME;
            }
        }
		
        public DataColumn ColumnDZHEKOU 
        {
            get 
            {
                return this.columnDZHEKOU;
            }
        }
		
        public DataColumn ColumnNPFP 
        {
            get 
            {
                return this.columnNPFP;
            }
        }
		
        public DataColumn ColumnNJGLX 
        {
            get 
            {
                return this.columnNJGLX;
            }
        }
		
        public DataColumn ColumnNCKSX 
        {
            get 
            {
                return this.columnNCKSX;
            }
        }
		
        public DataColumn ColumnNCKXX 
        {
            get 
            {
                return this.columnNCKXX;
            }
        }
		
        public DataColumn ColumnVPDTS 
        {
            get 
            {
                return this.columnVPDTS;
            }
        }
		
        public DataColumn ColumnVPGTS 
        {
            get 
            {
                return this.columnVPGTS;
            }
        }
		
        public DataColumn ColumnVZCTS 
        {
            get 
            {
                return this.columnVZCTS;
            }
        }
		
        public DataColumn ColumnVYCTS 
        {
            get 
            {
                return this.columnVYCTS;
            }
        }
		
        public DataColumn ColumnNCKZ 
        {
            get 
            {
                return this.columnNCKZ;
            }
        }
		
        public DataColumn ColumnVNEGTS 
        {
            get 
            {
                return this.columnVNEGTS;
            }
        }
		
        public DataColumn ColumnVPOSTS 
        {
            get 
            {
                return this.columnVPOSTS;
            }
        }
		
        public DataColumn ColumnNHOSID 
        {
            get 
            {
                return this.columnNHOSID;
            }
        }
		
        public DataColumn ColumnHISNITEMID 
        {
            get 
            {
                return this.columnHISNITEMID;
            }
        }
		
        public DataColumn ColumnVITEMADDRESS 
        {
            get 
            {
                return this.columnVITEMADDRESS;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowTJ_TJ_DICNODRUGITEM this[int index] 
        {
            get 
            {
                return ((RowTJ_TJ_DICNODRUGITEM)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerTJ_TJ_DICNODRUGITEM RowChangedTJ_TJ_DICNODRUGITEM;
        
        public event RowChangeEventHandlerTJ_TJ_DICNODRUGITEM RowChangingTJ_TJ_DICNODRUGITEM;
        
        public event RowChangeEventHandlerTJ_TJ_DICNODRUGITEM RowDeletedTJ_TJ_DICNODRUGITEM;
        
        public event RowChangeEventHandlerTJ_TJ_DICNODRUGITEM RowDeletingTJ_TJ_DICNODRUGITEM;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowTJ_TJ_DICNODRUGITEM(RowTJ_TJ_DICNODRUGITEM row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowTJ_TJ_DICNODRUGITEM AddRowTJ_TJ_DICNODRUGITEM(System.String EVITEMNAME,System.Int16 HISNITEMTYPE,System.String LISUNIT,System.DateTime CREATE_DATE,System.String CREATE_DEPT,System.String CREATE_DOCT,System.DateTime LAST_DATE,System.String LAST_DOCT,System.String NITEMID,System.Decimal NNODRUGITEMPRICE,System.Int32 NNODRUGITEMUNIT,System.String VDEPARTID,System.Int16 NISSTOP,System.Int16 NISPACK,System.String VITEMDES,System.String PINYINMA,System.String WUBIMA,System.Int32 NCHARGETYPEID,System.String VITEMNAME,System.Decimal DZHEKOU,System.Decimal NPFP,System.Int16 NJGLX,System.Decimal NCKSX,System.Decimal NCKXX,System.String VPDTS,System.String VPGTS,System.String VZCTS,System.String VYCTS,System.String NCKZ,System.String VNEGTS,System.String VPOSTS,System.Int32 NHOSID,System.String HISNITEMID,System.String VITEMADDRESS) 
        {
            RowTJ_TJ_DICNODRUGITEM row = ((RowTJ_TJ_DICNODRUGITEM)(this.NewRow()));
            row.ItemArray = new object[] {EVITEMNAME,HISNITEMTYPE,LISUNIT,CREATE_DATE,CREATE_DEPT,CREATE_DOCT,LAST_DATE,LAST_DOCT,NITEMID,NNODRUGITEMPRICE,NNODRUGITEMUNIT,VDEPARTID,NISSTOP,NISPACK,VITEMDES,PINYINMA,WUBIMA,NCHARGETYPEID,VITEMNAME,DZHEKOU,NPFP,NJGLX,NCKSX,NCKXX,VPDTS,VPGTS,VZCTS,VYCTS,NCKZ,VNEGTS,VPOSTS,NHOSID,HISNITEMID,VITEMADDRESS};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowTJ_TJ_DICNODRUGITEM FindByNITEMID(System.String NITEMID) {
            return ((RowTJ_TJ_DICNODRUGITEM)(this.Rows.Find(new object[] {
                        NITEMID})));
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
            DataTableTJ_TJ_DICNODRUGITEM cln = ((DataTableTJ_TJ_DICNODRUGITEM)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableTJ_TJ_DICNODRUGITEM();
        }
        
        internal void InitVars() 
        {	
            this.columnEVITEMNAME = this.Columns["EVITEMNAME"];
            this.columnHISNITEMTYPE = this.Columns["HISNITEMTYPE"];
            this.columnLISUNIT = this.Columns["LISUNIT"];
            this.columnCREATE_DATE = this.Columns["CREATE_DATE"];
            this.columnCREATE_DEPT = this.Columns["CREATE_DEPT"];
            this.columnCREATE_DOCT = this.Columns["CREATE_DOCT"];
            this.columnLAST_DATE = this.Columns["LAST_DATE"];
            this.columnLAST_DOCT = this.Columns["LAST_DOCT"];
            this.columnNITEMID = this.Columns["NITEMID"];
            this.columnNNODRUGITEMPRICE = this.Columns["NNODRUGITEMPRICE"];
            this.columnNNODRUGITEMUNIT = this.Columns["NNODRUGITEMUNIT"];
            this.columnVDEPARTID = this.Columns["VDEPARTID"];
            this.columnNISSTOP = this.Columns["NISSTOP"];
            this.columnNISPACK = this.Columns["NISPACK"];
            this.columnVITEMDES = this.Columns["VITEMDES"];
            this.columnPINYINMA = this.Columns["PINYINMA"];
            this.columnWUBIMA = this.Columns["WUBIMA"];
            this.columnNCHARGETYPEID = this.Columns["NCHARGETYPEID"];
            this.columnVITEMNAME = this.Columns["VITEMNAME"];
            this.columnDZHEKOU = this.Columns["DZHEKOU"];
            this.columnNPFP = this.Columns["NPFP"];
            this.columnNJGLX = this.Columns["NJGLX"];
            this.columnNCKSX = this.Columns["NCKSX"];
            this.columnNCKXX = this.Columns["NCKXX"];
            this.columnVPDTS = this.Columns["VPDTS"];
            this.columnVPGTS = this.Columns["VPGTS"];
            this.columnVZCTS = this.Columns["VZCTS"];
            this.columnVYCTS = this.Columns["VYCTS"];
            this.columnNCKZ = this.Columns["NCKZ"];
            this.columnVNEGTS = this.Columns["VNEGTS"];
            this.columnVPOSTS = this.Columns["VPOSTS"];
            this.columnNHOSID = this.Columns["NHOSID"];
            this.columnHISNITEMID = this.Columns["HISNITEMID"];
            this.columnVITEMADDRESS = this.Columns["VITEMADDRESS"];
        }
        
        private void InitClass() 
        {	
            this.columnEVITEMNAME = new DataColumn("EVITEMNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnEVITEMNAME.MaxLength = 60;
            this.columnEVITEMNAME.AllowDBNull = true;
            this.Columns.Add(this.columnEVITEMNAME);
			
            this.columnHISNITEMTYPE = new DataColumn("HISNITEMTYPE", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnHISNITEMTYPE.AllowDBNull = true;
            this.Columns.Add(this.columnHISNITEMTYPE);
			
            this.columnLISUNIT = new DataColumn("LISUNIT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnLISUNIT.MaxLength = 40;
            this.columnLISUNIT.AllowDBNull = true;
            this.Columns.Add(this.columnLISUNIT);
			
            this.columnCREATE_DATE = new DataColumn("CREATE_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnCREATE_DATE.AllowDBNull = true;
            this.Columns.Add(this.columnCREATE_DATE);
			
            this.columnCREATE_DEPT = new DataColumn("CREATE_DEPT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnCREATE_DEPT.MaxLength = 20;
            this.columnCREATE_DEPT.AllowDBNull = true;
            this.Columns.Add(this.columnCREATE_DEPT);
			
            this.columnCREATE_DOCT = new DataColumn("CREATE_DOCT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnCREATE_DOCT.MaxLength = 20;
            this.columnCREATE_DOCT.AllowDBNull = true;
            this.Columns.Add(this.columnCREATE_DOCT);
			
            this.columnLAST_DATE = new DataColumn("LAST_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnLAST_DATE.AllowDBNull = true;
            this.Columns.Add(this.columnLAST_DATE);
			
            this.columnLAST_DOCT = new DataColumn("LAST_DOCT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnLAST_DOCT.MaxLength = 20;
            this.columnLAST_DOCT.AllowDBNull = true;
            this.Columns.Add(this.columnLAST_DOCT);
			
            this.columnNITEMID = new DataColumn("NITEMID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNITEMID.MaxLength = 36;
            this.columnNITEMID.AllowDBNull = false;
            this.columnNITEMID.Unique = true;
            
            this.Columns.Add(this.columnNITEMID);
			
            this.columnNNODRUGITEMPRICE = new DataColumn("NNODRUGITEMPRICE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNNODRUGITEMPRICE.AllowDBNull = true;
            this.Columns.Add(this.columnNNODRUGITEMPRICE);
			
            this.columnNNODRUGITEMUNIT = new DataColumn("NNODRUGITEMUNIT", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNNODRUGITEMUNIT.AllowDBNull = true;
            this.Columns.Add(this.columnNNODRUGITEMUNIT);
			
            this.columnVDEPARTID = new DataColumn("VDEPARTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTID.MaxLength = 20;
            this.columnVDEPARTID.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTID);
			
            this.columnNISSTOP = new DataColumn("NISSTOP", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNISSTOP.AllowDBNull = false;
            this.Columns.Add(this.columnNISSTOP);
			
            this.columnNISPACK = new DataColumn("NISPACK", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNISPACK.AllowDBNull = false;
            this.Columns.Add(this.columnNISPACK);
			
            this.columnVITEMDES = new DataColumn("VITEMDES", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEMDES.MaxLength = 200;
            this.columnVITEMDES.AllowDBNull = true;
            this.Columns.Add(this.columnVITEMDES);
			
            this.columnPINYINMA = new DataColumn("PINYINMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPINYINMA.MaxLength = 60;
            this.columnPINYINMA.AllowDBNull = false;
            this.Columns.Add(this.columnPINYINMA);
			
            this.columnWUBIMA = new DataColumn("WUBIMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnWUBIMA.MaxLength = 40;
            this.columnWUBIMA.AllowDBNull = false;
            this.Columns.Add(this.columnWUBIMA);
			
            this.columnNCHARGETYPEID = new DataColumn("NCHARGETYPEID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNCHARGETYPEID.AllowDBNull = false;
            this.Columns.Add(this.columnNCHARGETYPEID);
			
            this.columnVITEMNAME = new DataColumn("VITEMNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEMNAME.MaxLength = 200;
            this.columnVITEMNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVITEMNAME);
			
            this.columnDZHEKOU = new DataColumn("DZHEKOU", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnDZHEKOU.AllowDBNull = true;
            this.Columns.Add(this.columnDZHEKOU);
			
            this.columnNPFP = new DataColumn("NPFP", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNPFP.AllowDBNull = true;
            this.Columns.Add(this.columnNPFP);
			
            this.columnNJGLX = new DataColumn("NJGLX", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNJGLX.AllowDBNull = true;
            this.Columns.Add(this.columnNJGLX);
			
            this.columnNCKSX = new DataColumn("NCKSX", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNCKSX.AllowDBNull = true;
            this.Columns.Add(this.columnNCKSX);
			
            this.columnNCKXX = new DataColumn("NCKXX", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNCKXX.AllowDBNull = true;
            this.Columns.Add(this.columnNCKXX);
			
            this.columnVPDTS = new DataColumn("VPDTS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPDTS.MaxLength = 225;
            this.columnVPDTS.AllowDBNull = true;
            this.Columns.Add(this.columnVPDTS);
			
            this.columnVPGTS = new DataColumn("VPGTS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPGTS.MaxLength = 225;
            this.columnVPGTS.AllowDBNull = true;
            this.Columns.Add(this.columnVPGTS);
			
            this.columnVZCTS = new DataColumn("VZCTS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVZCTS.MaxLength = 225;
            this.columnVZCTS.AllowDBNull = true;
            this.Columns.Add(this.columnVZCTS);
			
            this.columnVYCTS = new DataColumn("VYCTS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVYCTS.MaxLength = 225;
            this.columnVYCTS.AllowDBNull = true;
            this.Columns.Add(this.columnVYCTS);
			
            this.columnNCKZ = new DataColumn("NCKZ", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNCKZ.MaxLength = 10;
            this.columnNCKZ.AllowDBNull = true;
            this.Columns.Add(this.columnNCKZ);
			
            this.columnVNEGTS = new DataColumn("VNEGTS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNEGTS.MaxLength = 225;
            this.columnVNEGTS.AllowDBNull = true;
            this.Columns.Add(this.columnVNEGTS);
			
            this.columnVPOSTS = new DataColumn("VPOSTS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPOSTS.MaxLength = 225;
            this.columnVPOSTS.AllowDBNull = true;
            this.Columns.Add(this.columnVPOSTS);
			
            this.columnNHOSID = new DataColumn("NHOSID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNHOSID.AllowDBNull = true;
            this.Columns.Add(this.columnNHOSID);
			
            this.columnHISNITEMID = new DataColumn("HISNITEMID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnHISNITEMID.MaxLength = 20;
            this.columnHISNITEMID.AllowDBNull = true;
            this.Columns.Add(this.columnHISNITEMID);
			
            this.columnVITEMADDRESS = new DataColumn("VITEMADDRESS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEMADDRESS.MaxLength = 50;
            this.columnVITEMADDRESS.AllowDBNull = true;
            this.Columns.Add(this.columnVITEMADDRESS);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowTJ_TJ_DICNODRUGITEM NewRowTJ_TJ_DICNODRUGITEM() {
            return ((RowTJ_TJ_DICNODRUGITEM)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowTJ_TJ_DICNODRUGITEM(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowTJ_TJ_DICNODRUGITEM);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedTJ_TJ_DICNODRUGITEM != null)) {
                this.RowChangedTJ_TJ_DICNODRUGITEM(this, new RowChangeEventTJ_TJ_DICNODRUGITEM(((RowTJ_TJ_DICNODRUGITEM)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingTJ_TJ_DICNODRUGITEM != null)) {
                this.RowChangingTJ_TJ_DICNODRUGITEM(this, new RowChangeEventTJ_TJ_DICNODRUGITEM(((RowTJ_TJ_DICNODRUGITEM)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedTJ_TJ_DICNODRUGITEM != null)) {
                this.RowDeletedTJ_TJ_DICNODRUGITEM(this, new RowChangeEventTJ_TJ_DICNODRUGITEM(((RowTJ_TJ_DICNODRUGITEM)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingTJ_TJ_DICNODRUGITEM != null)) {
                this.RowDeletingTJ_TJ_DICNODRUGITEM(this, new RowChangeEventTJ_TJ_DICNODRUGITEM(((RowTJ_TJ_DICNODRUGITEM)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowTJ_TJ_DICNODRUGITEM(RowTJ_TJ_DICNODRUGITEM row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowTJ_TJ_DICNODRUGITEM
	/// 
	/// 数据表TJ_TJ_DICNODRUGITEM行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowTJ_TJ_DICNODRUGITEM : DataRow 
    {
        
        private DataTableTJ_TJ_DICNODRUGITEM tableTJ_TJ_DICNODRUGITEM;
        
        internal RowTJ_TJ_DICNODRUGITEM(DataRowBuilder rb) : base(rb) 
        {
            this.tableTJ_TJ_DICNODRUGITEM = ((DataTableTJ_TJ_DICNODRUGITEM)(this.Table));
        }        
		
		/// 
		/// 字段EVITEMNAME所映射的属性。
		/// 
        public System.String EVITEMNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnEVITEMNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnEVITEMNAME] = value;
            }
        }
        
		/// 
		/// 字段HISNITEMTYPE所映射的属性。
		/// 
        public System.Int16 HISNITEMTYPE
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnHISNITEMTYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnHISNITEMTYPE] = value;
            }
        }
        
		/// 
		/// 字段LISUNIT所映射的属性。
		/// 
        public System.String LISUNIT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnLISUNIT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnLISUNIT] = value;
            }
        }
        
		/// 
		/// 字段CREATE_DATE所映射的属性。
		/// 
        public System.DateTime CREATE_DATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DATE] = value;
            }
        }
        
		/// 
		/// 字段CREATE_DEPT所映射的属性。
		/// 
        public System.String CREATE_DEPT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DEPT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DEPT] = value;
            }
        }
        
		/// 
		/// 字段CREATE_DOCT所映射的属性。
		/// 
        public System.String CREATE_DOCT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DOCT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DOCT] = value;
            }
        }
        
		/// 
		/// 字段LAST_DATE所映射的属性。
		/// 
        public System.DateTime LAST_DATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnLAST_DATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnLAST_DATE] = value;
            }
        }
        
		/// 
		/// 字段LAST_DOCT所映射的属性。
		/// 
        public System.String LAST_DOCT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnLAST_DOCT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnLAST_DOCT] = value;
            }
        }
        
		/// 
		/// 字段NITEMID所映射的属性。
		/// 
        public System.String NITEMID
        {
            get 
            {	
                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNITEMID])); 
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNITEMID] = value;
            }
        }
        
		/// 
		/// 字段NNODRUGITEMPRICE所映射的属性。
		/// 
        public System.Decimal NNODRUGITEMPRICE
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNNODRUGITEMPRICE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNNODRUGITEMPRICE] = value;
            }
        }
        
		/// 
		/// 字段NNODRUGITEMUNIT所映射的属性。
		/// 
        public System.Int32 NNODRUGITEMUNIT
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNNODRUGITEMUNIT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNNODRUGITEMUNIT] = value;
            }
        }
        
		/// 
		/// 字段VDEPARTID所映射的属性。
		/// 
        public System.String VDEPARTID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVDEPARTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVDEPARTID] = value;
            }
        }
        
		/// 
		/// 字段NISSTOP所映射的属性。
		/// 
        public System.Int16 NISSTOP
        {
            get 
            {	
                return ((System.Int16)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNISSTOP])); 
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNISSTOP] = value;
            }
        }
        
		/// 
		/// 字段NISPACK所映射的属性。
		/// 
        public System.Int16 NISPACK
        {
            get 
            {	
                return ((System.Int16)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNISPACK])); 
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNISPACK] = value;
            }
        }
        
		/// 
		/// 字段VITEMDES所映射的属性。
		/// 
        public System.String VITEMDES
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMDES])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMDES] = value;
            }
        }
        
		/// 
		/// 字段PINYINMA所映射的属性。
		/// 
        public System.String PINYINMA
        {
            get 
            {	
                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnPINYINMA])); 
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnPINYINMA] = value;
            }
        }
        
		/// 
		/// 字段WUBIMA所映射的属性。
		/// 
        public System.String WUBIMA
        {
            get 
            {	
                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnWUBIMA])); 
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnWUBIMA] = value;
            }
        }
        
		/// 
		/// 字段NCHARGETYPEID所映射的属性。
		/// 
        public System.Int32 NCHARGETYPEID
        {
            get 
            {	
                return ((System.Int32)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNCHARGETYPEID])); 
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNCHARGETYPEID] = value;
            }
        }
        
		/// 
		/// 字段VITEMNAME所映射的属性。
		/// 
        public System.String VITEMNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMNAME] = value;
            }
        }
        
		/// 
		/// 字段DZHEKOU所映射的属性。
		/// 
        public System.Decimal DZHEKOU
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnDZHEKOU])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnDZHEKOU] = value;
            }
        }
        
		/// 
		/// 字段NPFP所映射的属性。
		/// 
        public System.Decimal NPFP
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNPFP])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNPFP] = value;
            }
        }
        
		/// 
		/// 字段NJGLX所映射的属性。
		/// 
        public System.Int16 NJGLX
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNJGLX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNJGLX] = value;
            }
        }
        
		/// 
		/// 字段NCKSX所映射的属性。
		/// 
        public System.Decimal NCKSX
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKSX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKSX] = value;
            }
        }
        
		/// 
		/// 字段NCKXX所映射的属性。
		/// 
        public System.Decimal NCKXX
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKXX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKXX] = value;
            }
        }
        
		/// 
		/// 字段VPDTS所映射的属性。
		/// 
        public System.String VPDTS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVPDTS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVPDTS] = value;
            }
        }
        
		/// 
		/// 字段VPGTS所映射的属性。
		/// 
        public System.String VPGTS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVPGTS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVPGTS] = value;
            }
        }
        
		/// 
		/// 字段VZCTS所映射的属性。
		/// 
        public System.String VZCTS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVZCTS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVZCTS] = value;
            }
        }
        
		/// 
		/// 字段VYCTS所映射的属性。
		/// 
        public System.String VYCTS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVYCTS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVYCTS] = value;
            }
        }
        
		/// 
		/// 字段NCKZ所映射的属性。
		/// 
        public System.String NCKZ
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKZ])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKZ] = value;
            }
        }
        
		/// 
		/// 字段VNEGTS所映射的属性。
		/// 
        public System.String VNEGTS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVNEGTS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVNEGTS] = value;
            }
        }
        
		/// 
		/// 字段VPOSTS所映射的属性。
		/// 
        public System.String VPOSTS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVPOSTS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVPOSTS] = value;
            }
        }
        
		/// 
		/// 字段NHOSID所映射的属性。
		/// 
        public System.Int32 NHOSID
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNHOSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNHOSID] = value;
            }
        }
        
		/// 
		/// 字段HISNITEMID所映射的属性。
		/// 
        public System.String HISNITEMID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnHISNITEMID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnHISNITEMID] = value;
            }
        }
        
		/// 
		/// 字段VITEMADDRESS所映射的属性。
		/// 
        public System.String VITEMADDRESS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMADDRESS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMADDRESS] = value;
            }
        }
        
		/// 
		/// 判断字段EVITEMNAME是否为空。
		/// 
        public bool IsEVITEMNAMENull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnEVITEMNAME);
        }

		/// 
		/// 设置字段EVITEMNAME为空值。
		/// 
        public void SetEVITEMNAMENull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnEVITEMNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段HISNITEMTYPE是否为空。
		/// 
        public bool IsHISNITEMTYPENull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnHISNITEMTYPE);
        }

		/// 
		/// 设置字段HISNITEMTYPE为空值。
		/// 
        public void SetHISNITEMTYPENull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnHISNITEMTYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段LISUNIT是否为空。
		/// 
        public bool IsLISUNITNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnLISUNIT);
        }

		/// 
		/// 设置字段LISUNIT为空值。
		/// 
        public void SetLISUNITNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnLISUNIT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段CREATE_DATE是否为空。
		/// 
        public bool IsCREATE_DATENull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DATE);
        }

		/// 
		/// 设置字段CREATE_DATE为空值。
		/// 
        public void SetCREATE_DATENull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段CREATE_DEPT是否为空。
		/// 
        public bool IsCREATE_DEPTNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DEPT);
        }

		/// 
		/// 设置字段CREATE_DEPT为空值。
		/// 
        public void SetCREATE_DEPTNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DEPT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段CREATE_DOCT是否为空。
		/// 
        public bool IsCREATE_DOCTNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DOCT);
        }

		/// 
		/// 设置字段CREATE_DOCT为空值。
		/// 
        public void SetCREATE_DOCTNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnCREATE_DOCT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段LAST_DATE是否为空。
		/// 
        public bool IsLAST_DATENull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnLAST_DATE);
        }

		/// 
		/// 设置字段LAST_DATE为空值。
		/// 
        public void SetLAST_DATENull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnLAST_DATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段LAST_DOCT是否为空。
		/// 
        public bool IsLAST_DOCTNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnLAST_DOCT);
        }

		/// 
		/// 设置字段LAST_DOCT为空值。
		/// 
        public void SetLAST_DOCTNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnLAST_DOCT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NNODRUGITEMPRICE是否为空。
		/// 
        public bool IsNNODRUGITEMPRICENull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnNNODRUGITEMPRICE);
        }

		/// 
		/// 设置字段NNODRUGITEMPRICE为空值。
		/// 
        public void SetNNODRUGITEMPRICENull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNNODRUGITEMPRICE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NNODRUGITEMUNIT是否为空。
		/// 
        public bool IsNNODRUGITEMUNITNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnNNODRUGITEMUNIT);
        }

		/// 
		/// 设置字段NNODRUGITEMUNIT为空值。
		/// 
        public void SetNNODRUGITEMUNITNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNNODRUGITEMUNIT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPARTID是否为空。
		/// 
        public bool IsVDEPARTIDNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnVDEPARTID);
        }

		/// 
		/// 设置字段VDEPARTID为空值。
		/// 
        public void SetVDEPARTIDNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVDEPARTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEMDES是否为空。
		/// 
        public bool IsVITEMDESNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMDES);
        }

		/// 
		/// 设置字段VITEMDES为空值。
		/// 
        public void SetVITEMDESNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMDES] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEMNAME是否为空。
		/// 
        public bool IsVITEMNAMENull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMNAME);
        }

		/// 
		/// 设置字段VITEMNAME为空值。
		/// 
        public void SetVITEMNAMENull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DZHEKOU是否为空。
		/// 
        public bool IsDZHEKOUNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnDZHEKOU);
        }

		/// 
		/// 设置字段DZHEKOU为空值。
		/// 
        public void SetDZHEKOUNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnDZHEKOU] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPFP是否为空。
		/// 
        public bool IsNPFPNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnNPFP);
        }

		/// 
		/// 设置字段NPFP为空值。
		/// 
        public void SetNPFPNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNPFP] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NJGLX是否为空。
		/// 
        public bool IsNJGLXNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnNJGLX);
        }

		/// 
		/// 设置字段NJGLX为空值。
		/// 
        public void SetNJGLXNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNJGLX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCKSX是否为空。
		/// 
        public bool IsNCKSXNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKSX);
        }

		/// 
		/// 设置字段NCKSX为空值。
		/// 
        public void SetNCKSXNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKSX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCKXX是否为空。
		/// 
        public bool IsNCKXXNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKXX);
        }

		/// 
		/// 设置字段NCKXX为空值。
		/// 
        public void SetNCKXXNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKXX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPDTS是否为空。
		/// 
        public bool IsVPDTSNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnVPDTS);
        }

		/// 
		/// 设置字段VPDTS为空值。
		/// 
        public void SetVPDTSNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVPDTS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPGTS是否为空。
		/// 
        public bool IsVPGTSNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnVPGTS);
        }

		/// 
		/// 设置字段VPGTS为空值。
		/// 
        public void SetVPGTSNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVPGTS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VZCTS是否为空。
		/// 
        public bool IsVZCTSNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnVZCTS);
        }

		/// 
		/// 设置字段VZCTS为空值。
		/// 
        public void SetVZCTSNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVZCTS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VYCTS是否为空。
		/// 
        public bool IsVYCTSNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnVYCTS);
        }

		/// 
		/// 设置字段VYCTS为空值。
		/// 
        public void SetVYCTSNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVYCTS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCKZ是否为空。
		/// 
        public bool IsNCKZNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKZ);
        }

		/// 
		/// 设置字段NCKZ为空值。
		/// 
        public void SetNCKZNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNCKZ] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNEGTS是否为空。
		/// 
        public bool IsVNEGTSNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnVNEGTS);
        }

		/// 
		/// 设置字段VNEGTS为空值。
		/// 
        public void SetVNEGTSNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVNEGTS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPOSTS是否为空。
		/// 
        public bool IsVPOSTSNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnVPOSTS);
        }

		/// 
		/// 设置字段VPOSTS为空值。
		/// 
        public void SetVPOSTSNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVPOSTS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHOSID是否为空。
		/// 
        public bool IsNHOSIDNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnNHOSID);
        }

		/// 
		/// 设置字段NHOSID为空值。
		/// 
        public void SetNHOSIDNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnNHOSID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段HISNITEMID是否为空。
		/// 
        public bool IsHISNITEMIDNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnHISNITEMID);
        }

		/// 
		/// 设置字段HISNITEMID为空值。
		/// 
        public void SetHISNITEMIDNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnHISNITEMID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEMADDRESS是否为空。
		/// 
        public bool IsVITEMADDRESSNull()
        {
            return this.IsNull(this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMADDRESS);
        }

		/// 
		/// 设置字段VITEMADDRESS为空值。
		/// 
        public void SetVITEMADDRESSNull() 
        {
            this[this.tableTJ_TJ_DICNODRUGITEM.ColumnVITEMADDRESS] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventTJ_TJ_DICNODRUGITEM : EventArgs {
        
        private RowTJ_TJ_DICNODRUGITEM eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventTJ_TJ_DICNODRUGITEM(RowTJ_TJ_DICNODRUGITEM row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowTJ_TJ_DICNODRUGITEM Row {
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
	