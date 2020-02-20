using log4net;
using RGiesecke.DllExport;
using System.Reflection;

namespace Catmanjan.Odbc
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/odbc/reference/develop-app/core-interface-conformance
    /// 
    /// List of functions that must be implemented for core interface conformance:
    /// 
    /// SQLAllocHandle
    /// SQLFreeHandle
    /// SQLFreeStmt 
    /// SQLBindCol
    /// SQLBindParameter 
    /// SQLNumParams
    /// SQLParamData 
    /// SQLPutData
    /// SQLCloseCursor
    /// SQLGetCursorName
    /// SQLSetCursorName
    /// SQLColAttribute
    /// SQLDescribeCol
    /// SQLNumResultCols
    /// SQLRowCount
    /// SQLColumns
    /// SQLGetTypeInfo
    /// SQLStatistics
    /// SQLTables
    /// SQLConnect
    /// SQLDataSources
    /// SQLDisconnect
    /// SQLDriverConnect
    /// SQLDrivers
    /// SQLExecDirect
    /// SQLExecute
    /// SQLPrepare
    /// SQLFetch 
    /// SQLFetchScroll 
    /// SQLGetData
    /// SQLGetConnectAttr
    /// SQLGetEnvAttr
    /// SQLGetStmtAttr
    /// SQLSetConnectAttr
    /// SQLSetEnvAttr
    /// SQLSetStmtAttr
    /// SQLCopyDesc
    /// SQLGetDescField
    /// SQLGetDescRec
    /// SQLSetDescField
    /// SQLSetDescRec
    /// SQLGetDiagField 
    /// SQLGetDiagRec
    /// SQLGetFunctions 
    /// SQLGetInfo
    /// SQLNativeSql
    /// SQLEndTran 
    /// SQLCancel 
    /// SQLSpecialColumns
    /// </summary>
    public class Driver
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        
        [DllExport]
        public short SQLAllocHandle(short HandleType, short InputHandle, out short OutputHandle)
        {
            _logger.Debug("SQLAllocHandle");

            OutputHandle = 0;
            return 0;
        }
    }
}
