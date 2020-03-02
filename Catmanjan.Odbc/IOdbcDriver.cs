using System;
using System.Runtime.InteropServices;
using System.Text;
using static Catmanjan.Odbc.ODBC32;

namespace Catmanjan.Odbc
{
    internal interface IOdbcDriver
    {
        RetCode SQLAllocHandle(SQL_HANDLE HandleType, IntPtr InputHandle, out IntPtr OutputHandle);
        RetCode SQLBindCol(IntPtr StatementHandle, ushort ColumnNumber, SQL_C TargetType, HandleRef TargetValue, IntPtr BufferLength, IntPtr StrLen_or_Ind);
        RetCode SQLBindParameter(IntPtr StatementHandle, ushort ParameterNumber, short ParamDirection, SQL_C SQLCType, short SQLType, IntPtr cbColDef, IntPtr ibScale, HandleRef rgbValue, IntPtr BufferLength, HandleRef StrLen_or_Ind);
        RetCode SQLCancel(IntPtr StatementHandle);
        RetCode SQLCloseCursor(IntPtr StatementHandle);
        RetCode SQLColAttributeW(IntPtr StatementHandle, ushort ColumnNumber, ushort FieldIdentifier, IntPtr CharacterAttribute, ushort BufferLength, out ushort StringLength, out IntPtr NumericAttribute);
        RetCode SQLColumnsW(IntPtr StatementHandle, [In, MarshalAs(UnmanagedType.LPWStr)] string CatalogName, ushort NameLen1, [In, MarshalAs(UnmanagedType.LPWStr)] string SchemaName, ushort NameLen2, [In, MarshalAs(UnmanagedType.LPWStr)] string TableName, ushort NameLen3, [In, MarshalAs(UnmanagedType.LPWStr)] string ColumnName, ushort NameLen4);
        RetCode SQLDisconnect(IntPtr ConnectionHandle);
        RetCode SQLDriverConnectW(IntPtr hdbc, IntPtr hwnd, [In, MarshalAs(UnmanagedType.LPWStr)] string connectionstring, ushort cbConnectionstring, IntPtr connectionstringout, ushort cbConnectionstringoutMax, out ushort cbConnectionstringout, ushort  fDriverCompletion);
        RetCode SQLEndTran(SQL_HANDLE HandleType, IntPtr Handle, ushort CompletionType);
        RetCode SQLExecDirectW(IntPtr StatementHandle, [In, MarshalAs(UnmanagedType.LPWStr)] string StatementText, int TextLength);
        RetCode SQLExecute(IntPtr StatementHandle);
        RetCode SQLFetch(IntPtr StatementHandle);
        RetCode SQLFreeHandle(IntPtr HandleType, IntPtr StatementHandle);
        RetCode SQLFreeStmt(IntPtr StatementHandle, STMT Option);
        RetCode SQLGetConnectAttrW(IntPtr ConnectionHandle, SQL_ATTR Attribute, byte[] Value, int BufferLength, out int StringLength);
        RetCode SQLGetData(IntPtr StatementHandle, ushort ColumnNumber, SQL_C TargetType, IntPtr TargetValue, IntPtr BufferLength, out IntPtr StrLen_or_Ind);
        RetCode SQLGetDescFieldW(IntPtr StatementHandle, short RecNumber, SQL_DESC FieldIdentifier, IntPtr ValuePointer, int BufferLength, out int StringLength);
        RetCode SQLGetDiagRecW(SQL_HANDLE HandleType, IntPtr Handle, ushort RecNumber, StringBuilder rchState, out int NativeError, StringBuilder MessageText, ushort BufferLength, out ushort TextLength);
        RetCode SQLGetDiagFieldW(SQL_HANDLE HandleType, IntPtr Handle, ushort RecNumber, ushort DiagIdentifier, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder rchState, ushort BufferLength, out ushort StringLength);
    }
}
