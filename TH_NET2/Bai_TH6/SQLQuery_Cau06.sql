USE DB_DATN

GO

SELECT macn as N'Mã chuyên ngành', CONVERT(varchar(10),macn) + ' - ' + tencn as N'Tên chuyên ngành'
FROM tbl_chuyennganh